using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsForms
{
    public partial class FrmAltaCliente : Form
    {
        private AdministracionDeLaEmpresa unaAdministracion;
        private string mensaje = $"Se dio de alta un cliente en el sistema el {DateTime.Now:f}";
        /// <summary>
        /// Constructor que instancia un formulario para dar de alta un cliente.
        /// </summary>
        /// <param name="unaAdministracion">AdministracionDeLaEmpresa pasada por parametro.</param>
        public FrmAltaCliente(AdministracionDeLaEmpresa unaAdministracion)
        {
            InitializeComponent();
            this.unaAdministracion = unaAdministracion;
        }

        /// <summary>
        /// Evento CheckedChanged para chequear si el radio button de seguro basico esta activo y si es asi cargar un archivo txt con informacion del seguro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbSeguroBasico_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbSeguroBasico.Checked == true)
            {
                richTextBox1.Text = GestionDeArchivosTxt.Txt_Reader($"{AppDomain.CurrentDomain.BaseDirectory}" + @"SeguroBasico.txt");
            }
            else
            {
                richTextBox1.Clear();
            }
        }

        /// <summary>
        /// Evento CheckedChanged para chequear si el radio button de seguro intermedio esta activo y si es asi cargar un archivo txt con informacion del seguro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbSeguroIntermedio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSeguroIntermedio.Checked == true)
            {
                richTextBox1.Text = GestionDeArchivosTxt.Txt_Reader($"{AppDomain.CurrentDomain.BaseDirectory}" + @"SeguroIntermedio.txt");
            }
            else
            {
                richTextBox1.Clear();
            }
        }

        /// <summary>
        /// Evento CheckedChanged para chequear si el radio button de seguro contra todo esta activo y si es asi cargar un archivo txt con informacion del seguro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbSeguroContraTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSeguroContraTodo.Checked == true)
            {
                richTextBox1.Text = GestionDeArchivosTxt.Txt_Reader($"{AppDomain.CurrentDomain.BaseDirectory}" + @"SeguroContraTodo.txt");
            }
            else
            {
                richTextBox1.Clear();
            }
        }

        /// <summary>
        /// Evento Click del boton aceptar en el cual se chequea si los campos estan vacios y de no ser asi se agrega un cliente a la administracion, se serializa su informacion y se genera un txt del momento en que esto se realizo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!chequearCamposVacios())
                {
                    int proximoNumeroDeCliente = int.Parse(GestionDeArchivosTxt.Txt_Reader($"{AppDomain.CurrentDomain.BaseDirectory}" + @"NumeroCliente.txt"));
                    unaAdministracion += AltaDelCliente(proximoNumeroDeCliente);
                    GestionDeArchivosSerializados<List<Cliente>>.Xml_Serializer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"Clientes.xml", unaAdministracion.ListaDeClientes);
                    GestionDeArchivosTxt.Txt_Writer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"HistorialDeActividades.txt", mensaje, true);
                    proximoNumeroDeCliente += 1;
                    GestionDeArchivosTxt.Txt_Writer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"NumeroCliente.txt", proximoNumeroDeCliente.ToString(),false);
                    MessageBox.Show("Se dio de alta al cliente exitosamente!", "Alta exitosa!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                } 
            }
            catch (CamposVaciosException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (AgregarClienteException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArchivosException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento Key Press para chequear que en los text box solo hayan letras, se pueda borrar y dejar espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCaracter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Evento Key Press para chequear que en los text box solo hayan numeros y se pueda borrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCaracterNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Metodo para disparar un error providing para el text box de dni, telefono y año del vehiculo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ErrorProviding_Error(object sender, CancelEventArgs e)
        {
            e.Cancel = true;

            epDatoDeLetrasIncorrecto.SetError((Control)sender, "Se requieren 4 digitos para Año del vehiculo\n10 digitos para Telefono\n8 digitos para el DNI");
            epDatoDeLetrasIncorrecto.BlinkRate = 500;
            epDatoDeLetrasIncorrecto.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
        }

        /// <summary>
        /// Evento Validating para chequear que el text box de año del vehiculo no supere los 4 digitos. De ser asi se llama al metodo ErrorProviding para que se dispare el error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validar_TextBoxAnioDelVehiculo(object sender, CancelEventArgs e)
        {
            if (txtAnioDelVehiculo.Text.Length != 4)
            {
                ErrorProviding_Error(sender, e);
            }
        }

        /// <summary>
        /// Evento Validating para chequear que el text box de dni no supere los 8 digitos. De ser asi se llama al metodo ErrorProviding para que se dispare el error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validar_TextBoxDni(object sender, CancelEventArgs e)
        {
            if (txtDni.Text.Length != 8)
            {
                ErrorProviding_Error(sender, e);
            }
        }

        /// <summary>
        /// Evento Validating para chequear que el text box de telefono no supere los 10 digitos. De ser asi se llama al metodo ErrorProviding para que se dispare el error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validar_TextBoxTelefono(object sender, CancelEventArgs e)
        {
            if (txtNumeroDeTelefono.Text.Length != 10)
            {
                ErrorProviding_Error(sender, e);
            }
        }

        /// <summary>
        /// Evento Validated que cancela el error providing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validados_TextBoxesDeNumeros(object sender, EventArgs e)
        {
            epDatoDeLetrasIncorrecto.Clear();
        }

        /// <summary>
        /// Evento Validating para text box de numeros y letras que chequea que no sea null o este vacio. De lo contrario dispara un error providing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validar_TextBoxesDeNumerosYTexto(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text) || ((TextBox)sender).Text.Length < 3 || !Regex.IsMatch(((TextBox)sender).Text, @"^[a-zA-Z0-9\s]+$"))
            {
                e.Cancel = true;

                epDatoDeLetrasIncorrecto.SetError((Control)sender, "El campo requiere de 3 a 20 caracteres");
                epDatoDeLetrasIncorrecto.BlinkRate = 500;
                epDatoDeLetrasIncorrecto.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
        }

        /// <summary>
        /// Evento Validated que cancela el error providing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validados_TextBoxesDeNumerosYTexto(object sender, EventArgs e)
        {
            epDatoDeLetrasIncorrecto.Clear();
        }

        /// <summary>
        /// Evento Load del form que carga un txt con la informacion del seguro basico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = GestionDeArchivosTxt.Txt_Reader($"{AppDomain.CurrentDomain.BaseDirectory}" + @"SeguroBasico.txt");
        }

        /// <summary>
        /// Metodo que chequea que no hayan text box vacios y devuelve false. De lo contrario lanza una excepcion de tipo CamposVaciosExcepcion.
        /// </summary>
        /// <returns></returns>
        private bool chequearCamposVacios()
        {
            bool esValido = false;

            if(string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtAnioDelVehiculo.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtNumeroDeTelefono.Text) || string.IsNullOrWhiteSpace(txtMarcaDelVehiculo.Text) ||
                string.IsNullOrWhiteSpace(txtDomicilio.Text) || string.IsNullOrWhiteSpace(txtModeloDelVehiculo.Text))
            {
                throw new CamposVaciosException("Se deben completar todos los campos para aceptar");
            }
            return esValido;       
        }

        /// <summary>
        /// Evento Click del boton cancelar que cierra el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo que instancia un Cliente con el seguro que le corresponde en base al radio button que este seleccionado. 
        /// </summary>
        /// <param name="proximoNumeroDeCliente">Numero de cliente que le correspondera al cliente instanciado.</param>
        /// <returns>Devuelve el cliente instanciado.</returns>
        private Cliente AltaDelCliente(int proximoNumeroDeCliente)
        {
            Cliente cliente;
            if(rdbSeguroBasico.Checked == true)
            {
                cliente = new Cliente(proximoNumeroDeCliente, int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, double.Parse(txtNumeroDeTelefono.Text), txtDomicilio.Text, (int)numericUpDownEdad.Value, true, new SeguroBasico(int.Parse(txtAnioDelVehiculo.Text), txtMarcaDelVehiculo.Text, txtModeloDelVehiculo.Text));
            }
            else if(rdbSeguroIntermedio.Checked == true)
            {
                cliente = new Cliente(proximoNumeroDeCliente, int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, double.Parse(txtNumeroDeTelefono.Text), txtDomicilio.Text, (int)numericUpDownEdad.Value, true, new SeguroIntermedio(int.Parse(txtAnioDelVehiculo.Text), txtMarcaDelVehiculo.Text, txtModeloDelVehiculo.Text));
            }
            else
            {
                cliente = new Cliente(proximoNumeroDeCliente, int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, double.Parse(txtNumeroDeTelefono.Text), txtDomicilio.Text, (int)numericUpDownEdad.Value, true, new SeguroContraTodo(int.Parse(txtAnioDelVehiculo.Text), txtMarcaDelVehiculo.Text, txtModeloDelVehiculo.Text));
            }

            return cliente;
        }
    }
}

