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
    public partial class FrmChequeoDeDatos : Form
    {
        private AdministracionDeLaEmpresa unaAdministracion;
        private string datoRecibido;
        private int indice;
        private int criterio;
        private string mensaje = $"Se modifico un cliente en el sistema el {DateTime.Now:f}";

        /// <summary>
        /// Propiedad de solo lectura que devuelve un indice especifico en la lista de clientes.
        /// </summary>
        public int Indice
        {
            get { return this.indice; }
        }

        /// <summary>
        /// Constructor que instancia un formulario Chequedo de datos.
        /// </summary>
        /// <param name="titulo">Titulo pasado por parametro para titulo del formulario.</param>
        /// <param name="txtDatoAPedir">Texto pasado por parametro para cargarlo en el label.</param>
        /// <param name="unaAdministracion">AdministracionDeLaEmpresa pasada por parametro.</param>
        /// <param name="datoRecibido">Dato a chequear para luego en el switch saber a que case entrar.</param>
        /// <param name="criterio">Dato a chequear para saber si es la primera vez que se ingreso o no al text box de ChequeoDeDatos.</param>
        public FrmChequeoDeDatos(string titulo, string txtDatoAPedir, AdministracionDeLaEmpresa unaAdministracion, string datoRecibido, int criterio)
        {
            InitializeComponent();
            this.Text = titulo;
            lblDatoAPedir.Text = txtDatoAPedir;
            this.unaAdministracion = unaAdministracion;
            this.datoRecibido = datoRecibido;
            this.criterio = criterio;
        }

        /// <summary>
        /// Sobrecarga de constructor que instancia un formulario Chequedo de datos.
        /// </summary>
        /// <param name="titulo">Titulo pasado por parametro para titulo del formulario.</param>
        /// <param name="txtDatoAPedir">Texto pasado por parametro para cargarlo en el label.</param>
        /// <param name="unaAdministracion">AdministracionDeLaEmpresa pasada por parametro.</param>
        /// <param name="datoRecibido">Dato a chequear para luego en el switch saber a que case entrar.</param>
        /// <param name="criterio">Dato a chequear para saber si es la primera vez que se ingreso o no al text box de ChequeoDeDatos.</param>
        /// <param name="indice">Dato recibido del indice de la persona a la que se le va a aplicar la modificacion.</param>
        public FrmChequeoDeDatos(string titulo, string txtDatoAPedir, AdministracionDeLaEmpresa unaAdministracion, string datoRecibido, int criterio,int indice) :this(titulo, txtDatoAPedir, unaAdministracion, datoRecibido, criterio)
        {
            this.indice = indice;
        }

        /// <summary>
        /// Event Click del boton Cancelar. Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento Click del boton Aceptar. Si el criterio es 0 Mediante la funcion BuscarClientePorNumeroCliente se busca el indice de la persona a modificar.
        /// Luego mediante un switch se chequea que no sea un indice negativo y que la persona tenga su estado EnServicio en true.
        /// De ser asi dependiendo de lo que se haya recibido en datoRecibido se entra al case del switch que corresponda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (criterio == 0)
                {
                    indice = unaAdministracion.BuscarClientePorNumeroCliente(txtDatoAPedir.Text);
                }
                switch (datoRecibido)
                {
                    case "numeroDeCliente":
                        if (indice >= 0 && unaAdministracion.ListaDeClientes[indice].EnServicio == true)
                        {
                            MessageBox.Show("El cliente se encuentra en el sistema, proceda a modificarlo", "Acceder a modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("El cliente no se encuentra en el sistema o no esta activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "nombre":
                        if (!string.IsNullOrEmpty(txtDatoAPedir.Text) && FrmChequeoDeDatos.SonLetras(txtDatoAPedir.Text))
                        {                          
                            unaAdministracion.ListaDeClientes[Indice].Nombre = txtDatoAPedir.Text;
                            MessageBox.Show("Nombre reemplazado con exito", "Actualizacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GestionDeArchivosSerializados<List<Cliente>>.Xml_Serializer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"Clientes.xml", unaAdministracion.ListaDeClientes);
                            GestionDeArchivosTxt.Txt_Writer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"HistorialDeActividades.txt", mensaje,true);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar solamente letras y no debe quedar en blanco el cuadro de texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case "apellido":
                        if (!string.IsNullOrEmpty(txtDatoAPedir.Text) && FrmChequeoDeDatos.SonLetras(txtDatoAPedir.Text))
                        {                           
                            unaAdministracion.ListaDeClientes[indice].Apellido = txtDatoAPedir.Text;
                            MessageBox.Show("Apellido reemplazado con exito", "Actualizacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GestionDeArchivosSerializados<List<Cliente>>.Xml_Serializer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"Clientes.xml", unaAdministracion.ListaDeClientes);
                            GestionDeArchivosTxt.Txt_Writer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"HistorialDeActividades.txt", mensaje,true);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar solamente letras y no debe quedar en blanco el cuadro de texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case "telefono":
                        if (!string.IsNullOrEmpty(txtDatoAPedir.Text) && txtDatoAPedir.Text.All(char.IsDigit) && txtDatoAPedir.Text.Length == 10)
                        {                       
                            unaAdministracion.ListaDeClientes[indice].NumeroTelefonico = double.Parse(txtDatoAPedir.Text);
                            MessageBox.Show("Telefono reemplazado con exito", "Actualizacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GestionDeArchivosSerializados<List<Cliente>>.Xml_Serializer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"Clientes.xml", unaAdministracion.ListaDeClientes);
                            GestionDeArchivosTxt.Txt_Writer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"HistorialDeActividades.txt", mensaje,true);
                            this.Close();
                        }
                        else
                        {
                            txtDatoAPedir.MaxLength = 10;
                            MessageBox.Show("Debe ingresar solamente numeros, no dejar el cuadro de texto en blanco y el numero debe tener 10 caracteres numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case "domicilio":
                        if (!string.IsNullOrEmpty(txtDatoAPedir.Text) && Regex.IsMatch(txtDatoAPedir.Text, @"^[a-zA-Z0-9\s]+$"))
                        {                      
                            unaAdministracion.ListaDeClientes[indice].DireccionParticular = txtDatoAPedir.Text;
                            MessageBox.Show("Domicilio reemplazado con exito", "Actualizacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GestionDeArchivosSerializados<List<Cliente>>.Xml_Serializer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"Clientes.xml", unaAdministracion.ListaDeClientes);
                            GestionDeArchivosTxt.Txt_Writer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"HistorialDeActividades.txt", mensaje,true);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No debe quedar en blanco el cuadro de texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                }
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
        /// Metodo para validar que la cadena de texto recibida por parametro solo contenga letras.
        /// </summary>
        /// <param name="cadena">Cadena de texto recibida por parametro.</param>
        /// <returns>Devuelve false si la cadena no contiene letras. Caso contrario devuelve true si son solo letras.</returns>
        private static bool SonLetras(string cadena)
        {
            foreach (char unCaracter in cadena)
            {
                if(!char.IsLetter(unCaracter) && unCaracter != 32)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
