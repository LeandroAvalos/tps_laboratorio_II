using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsForms
{
    public partial class FrmAgregarSucursal : Form
    {
        private AdministracionDeLaEmpresa unaAdministracion;
        /// <summary>
        /// Constructor para instanciar un formulario para agregar una sucursal.
        /// </summary>
        /// <param name="unaAdministracion">AdministracionDeLaEmpresa pasada por parametro.</param>
        public FrmAgregarSucursal(AdministracionDeLaEmpresa unaAdministracion)
        {
            InitializeComponent();
            this.unaAdministracion = unaAdministracion;
        }

        /// <summary>
        /// Evento load donde se cargan los combo box de dias y horas y se los inicializa con el primer indice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAgregarSucursal_Load(object sender, EventArgs e)
        {
            this.CargarComboBoxDias();
            this.CargarComboBoxHoras();
            cmbAbiertoDe.SelectedIndex = 0;
            cmbAbiertoHasta.SelectedIndex = 0;
            cmbHorarioApertura.SelectedIndex = 0;
            cmbHorarioCierre.SelectedIndex = 0;
        }

        /// <summary>
        /// Metodo que carga con valores el combo box de dias.
        /// </summary>
        private void CargarComboBoxDias()
        {
            string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"};

            for (int i = 0; i < dias.GetLength(0); i++)
            {
                cmbAbiertoDe.Items.Add(dias[i]);
                cmbAbiertoHasta.Items.Add(dias[i]);
            }
        }

        /// <summary>
        /// Metodo que carga con valores el combo box de horas.
        /// </summary>
        private void CargarComboBoxHoras()
        {
            string[] horas = { "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00"
                    , "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "24:00" };

            for (int i = 0; i < horas.GetLength(0); i++)
            {
                cmbHorarioApertura.Items.Add(horas[i]);
                cmbHorarioCierre.Items.Add(horas[i]);
            }
        }

        /// <summary>
        /// Evento Key Press para validar que solo se pueden ingresar letras en un text box.
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
        /// Evento Key Press que valida que solo se puedan usar numeros en un text box.
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
        /// Evento del boton cancelar para cerrar el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void brnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento para validar que el text box de telefono contenga 10 digitos. Si no los contiene se dispara un error provider hasta que los digitos sean introducidos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validar_TextBoxTelefono(object sender, CancelEventArgs e)
        {
            if (txtTelefono.Text.Length != 10)
            {
                e.Cancel = true;

                epDatoDeLetrasIncorrecto.SetError((Control)sender, "El campo requiere 10 caracteres numericos");
                epDatoDeLetrasIncorrecto.BlinkRate = 500;
                epDatoDeLetrasIncorrecto.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
        }

        /// <summary>
        /// Evento que cancela el error provider si los 10 digitos fueron introducidos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validado_TextBoxTelefono(object sender, EventArgs e)
        {
            epDatoDeLetrasIncorrecto.Clear();
        }

        /// <summary>
        /// Evento que valida que no sea null o este vacios los text box que requieran letras y numeros. En caso de que eso pase se dispara un error provider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validar_TextBoxesDeNumerosYTexto(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                e.Cancel = true;

                epDatoDeLetrasIncorrecto.SetError((Control)sender, "El campo es requerido");
                epDatoDeLetrasIncorrecto.BlinkRate = 500;
                epDatoDeLetrasIncorrecto.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }
        }
        /// <summary>
        /// Evento que cancela el error provider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validados_TextBoxesDeNumerosYTexto(object sender, EventArgs e)
        {
            epDatoDeLetrasIncorrecto.Clear();
        }

        /// <summary>
        /// Metodo que chequea que no haya ningun campo vacio. De lo contrario lanza una excepcion de tipo CamposVaciosExcepcion.
        /// </summary>
        /// <returns>Devuelve false si no hay ningun campo vacio. De lo contrario lanza una excepcion de tipo CamposVaciosExcepcion.</returns>
        private bool chequearCamposVacios()
        {
            bool esValido = false;

            if (string.IsNullOrWhiteSpace(txtBarrioDeLaSucursal.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtCodigoDeLaSucursal.Text))
            {
                throw new CamposVaciosException("Se deben completar todos los campos para aceptar");
            }
            return esValido;
        }

        /// <summary>
        /// Evento Click del boton aceptar para agregar una sucursal mediante el metodo AgregarSucursal y capturar posibles excepciones que se hayan lanzado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!chequearCamposVacios())
                {
                    this.AgregarSucursal();
                    this.Close();
                }
            }
            catch (CamposVaciosException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ops... Ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo que instancia una sucursal para agregarla a la lista de sucursales, serializa en formato json la sucursal añadida y añade en un txt el momento en que se añadio la sucursal.
        /// </summary>
        private void AgregarSucursal()
        {
            Sucursales unaSucursal = new Sucursales(txtBarrioDeLaSucursal.Text, double.Parse(txtTelefono.Text), txtDireccion.Text, txtCodigoDeLaSucursal.Text,
                (string)cmbAbiertoDe.SelectedItem, (string)cmbAbiertoHasta.SelectedItem, (string)cmbHorarioApertura.SelectedItem, (string)cmbHorarioCierre.SelectedItem);

            string mensaje = $"Se agrego una sucursal al sistema el {DateTime.Now:f}";

            try
            {
                unaAdministracion += unaSucursal;
                GestionDeArchivosSerializados<List<Sucursales>>.Json_Serializer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"Sucursales.json", unaAdministracion.ListaDeSecursales);
                GestionDeArchivosTxt.Txt_Writer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"HistorialDeActividades.txt", mensaje,true);
                MessageBox.Show("Se agrego la sucursal al sistema exitosamente!", "Sucursal adherida exitosamente!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
