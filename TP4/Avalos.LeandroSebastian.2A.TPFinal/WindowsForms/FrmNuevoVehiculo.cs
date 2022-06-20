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
    public partial class FrmNuevoVehiculo : Form
    {
        private AdministracionDeLaEmpresa unaAdministracion;
        private int indice;
        private string mensaje = $"Se modifico el vehiculo de un cliente en el sistema el {DateTime.Now:f}";

        /// <summary>
        /// Constructor que instancia un formulario de tipo NuevoVehiculo.
        /// </summary>
        /// <param name="unaAdministracion"></param>
        /// <param name="indice"></param>
        public FrmNuevoVehiculo(AdministracionDeLaEmpresa unaAdministracion, int indice)
        {
            InitializeComponent();
            this.unaAdministracion = unaAdministracion;
            this.indice = indice;
        }

        /// <summary>
        /// Evento CheckedChanged para chequear si el radio button de seguro basico esta activo y si es asi cargar un archivo txt con informacion del seguro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbSeguroBasico_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSeguroBasico.Checked == true)
            {
                rtbInformacionSeguros.Text = GestionDeArchivos<string>.Txt_Reader($"{AppDomain.CurrentDomain.BaseDirectory}" + @"SeguroBasico.txt");
            }
            else
            {
                rtbInformacionSeguros.Clear();
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
                rtbInformacionSeguros.Text = GestionDeArchivos<string>.Txt_Reader($"{AppDomain.CurrentDomain.BaseDirectory}" + @"SeguroIntermedio.txt");
            }
            else
            {
                rtbInformacionSeguros.Clear();
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
                rtbInformacionSeguros.Text = GestionDeArchivos<string>.Txt_Reader($"{AppDomain.CurrentDomain.BaseDirectory}" + @"SeguroContraTodo.txt");
            }
            else
            {
                rtbInformacionSeguros.Clear();
            }
        }

        /// <summary>
        /// Metodo que dependiendo que radio button esta activo devuelve una string correspondiente al seguro elegido.
        /// </summary>
        /// <returns>Devuelve la string correspondiente al seguro seleccionado.</returns>
        private string SeguroChecked()
        {
            string seguro;
            if (rdbSeguroBasico.Checked == true)
            {
                seguro = "SeguroBasico";
            }
            else if (rdbSeguroIntermedio.Checked == true)
            {
                seguro = "SeguroIntermedio";
            }
            else
            {
                seguro = "SeguroContraTodo";
            }

            return seguro;
        }

        /// <summary>
        /// Evento Click del boton cancelar. Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento Key Press que chequea que en los text box solo haya letras, que se pueda borrar y poner espacios.
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
        /// Evento Key Press que chequea que en los text box solo haya numeros y se pueda borrar.
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
        /// Evento Validating que valida que en el text box AñoDelVehiculo no hay ni mas ni menos de 4 digitos. En caso de no ser asi disparar un error providing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validar_TextBoxAnioDelVehiculo(object sender, CancelEventArgs e)
        {
            if (txtAnioDelVehiculo.Text.Length != 4)
            {
                e.Cancel = true;

                epDatoDeLetrasIncorrecto.SetError((Control)sender, "El campo debe contener 4 digitos");
                epDatoDeLetrasIncorrecto.BlinkRate = 500;
                epDatoDeLetrasIncorrecto.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
        }

        /// <summary>
        /// Evento Validated que cancela el error providing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validado_TextBoxAnioDelVehiculo(object sender, EventArgs e)
        {
            epDatoDeLetrasIncorrecto.Clear();
        }

        /// <summary>
        /// Evento Validating para text box de numeros y letras. Chequea que no haya espacios vacios ni sea null y que como minimo tenga 4 caracteres. En caso de no ser asi se disparar un error providing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validar_TextBoxesDeNumerosYTexto(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text) || ((TextBox)sender).Text.Length < 3 || !Regex.IsMatch(((TextBox)sender).Text, @"^[a-zA-Z0-9\s]+$"))
            {
                e.Cancel = true;

                epDatoDeLetrasIncorrecto.SetError((Control)sender, "El campo debe contener de 3 a 20 caracteres");
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
        /// Evento Load en el cual se carga en el richtextbox la informacion del seguro basico.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNuevoVehiculo_Load(object sender, EventArgs e)
        {
            rtbInformacionSeguros.Text = GestionDeArchivos<string>.Txt_Reader($"{AppDomain.CurrentDomain.BaseDirectory}" + @"SeguroBasico.txt");
        }

        /// <summary>
        /// Evento Click del boton aceptar. Se chequea que no haya campos vacios y dependiendo del string que devuelva SeguroChecked se entra a un case correspondiente
        /// para instanciar un seguro y modificar el que actualmente tenga el cliente. Se serializan los datos en formato xml y se registra en un txt
        /// la operacion realizada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {        
            try
            {
                if (!chequearCamposVacios())
                {
                    switch (SeguroChecked())
                    {
                        case "SeguroBasico":
                            unaAdministracion.ListaDeClientes[indice].Servicio = new SeguroBasico(int.Parse(txtAnioDelVehiculo.Text), txtMarcaDelVehiculo.Text, txtModeloDelVehiculo.Text);
                            break;
                        case "SeguroIntermedio":
                            unaAdministracion.ListaDeClientes[indice].Servicio = new SeguroIntermedio(int.Parse(txtAnioDelVehiculo.Text), txtMarcaDelVehiculo.Text, txtModeloDelVehiculo.Text);
                            break;
                        case "SeguroContraTodo":
                            unaAdministracion.ListaDeClientes[indice].Servicio = new SeguroContraTodo(int.Parse(txtAnioDelVehiculo.Text), txtMarcaDelVehiculo.Text, txtModeloDelVehiculo.Text);
                            break;
                    }
                    GestionDeArchivos<List<Cliente>>.Xml_Serializer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"Clientes.xml", unaAdministracion.ListaDeClientes);
                    GestionDeArchivos<string>.Txt_Writer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"HistorialDeActividades.txt", mensaje,true);
                    MessageBox.Show("Se actualizo el vehiculo exitosamente!", "Actualizacion exitosa!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
            catch (CamposVaciosException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArchivosException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ops... Ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo para chequear que los text box no esten vacios. Caso contrario se lanza una excepcion de tipo CamposVaciosException.
        /// </summary>
        /// <returns>Devuelve false si no hay campos vacios. Caso contrario lanza una excepcion de tipo CamposVaciosException.</returns>
        private bool chequearCamposVacios()
        {
            bool esValido = false;

            if (string.IsNullOrWhiteSpace(txtAnioDelVehiculo.Text) || string.IsNullOrWhiteSpace(txtMarcaDelVehiculo.Text) || string.IsNullOrWhiteSpace(txtModeloDelVehiculo.Text))
            {
                throw new CamposVaciosException("Se deben completar todos los campos para aceptar");
            }
            return esValido;
        }
    }
}
