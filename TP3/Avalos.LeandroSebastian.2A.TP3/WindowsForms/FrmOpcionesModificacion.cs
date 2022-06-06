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
    public partial class FrmOpcionesModificacion : Form
    {
        private AdministracionDeLaEmpresa unaAdministracion;
        private int indice;

        /// <summary>
        /// Constructor que instancia un formulario de tipo OpcionesModificacion.
        /// </summary>
        /// <param name="unaAdministracion">AdministracionDeLaEmpresa pasada por parametro.</param>
        /// <param name="indice">Dato del indice de la persona a ser modificada.</param>
        public FrmOpcionesModificacion(AdministracionDeLaEmpresa unaAdministracion, int indice)
        {
            InitializeComponent();
            this.unaAdministracion = unaAdministracion;
            this.indice = indice;
        }

        /// <summary>
        /// Evento Click del boton modificar nombre. Instancia un formulario de tipo ChequeoDeDatos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarNombre_Click(object sender, EventArgs e)
        {
            FrmChequeoDeDatos frmChequeoDeDatos = new FrmChequeoDeDatos("Modificacion del nombre", 
                "Por favor Ingrese el nuevo nombre", unaAdministracion, "nombre",1, indice);

            frmChequeoDeDatos.ShowDialog();
        }

        /// <summary>
        /// Evento Click del boton salir. Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento Click del boton modificar apellido. Instancia un formulario de tipo ChequeoDeDatos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarApellido_Click(object sender, EventArgs e)
        {
            FrmChequeoDeDatos frmChequeoDeDatos = new FrmChequeoDeDatos("Modificacion del apellido"
                , "Por favor Ingrese el nuevo apellido", unaAdministracion, "apellido", 1, indice);

            frmChequeoDeDatos.ShowDialog();
        }

        /// <summary>
        /// Evento Click del boton modificar telefono. Instancia un formulario de tipo ChequeoDeDatos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarTelefono_Click(object sender, EventArgs e)
        {
            FrmChequeoDeDatos frmChequeoDeDatos = new FrmChequeoDeDatos("Modificacion del telefono"
                , "Por favor Ingrese el nuevo telefono", unaAdministracion, "telefono", 1, indice);

            frmChequeoDeDatos.ShowDialog();
        }

        /// <summary>
        /// Evento Click del boton modificar domicilio. Instancia un formulario de tipo ChequeoDeDatos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarDomicilio_Click(object sender, EventArgs e)
        {
            FrmChequeoDeDatos frmChequeoDeDatos = new FrmChequeoDeDatos("Modificacion del domicilio"
                , "Por favor Ingrese el nuevo domicilio", unaAdministracion, "domicilio", 1, indice);

            frmChequeoDeDatos.ShowDialog();
        }

        /// <summary>
        /// Evento Click del boton cambiar de vehiculo. Instancia un formulario de tipo NuevoVehiculo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCambiarDeVehiculo_Click(object sender, EventArgs e)
        {
            FrmNuevoVehiculo frmNuevoVehiculo = new FrmNuevoVehiculo(unaAdministracion, indice);

            frmNuevoVehiculo.ShowDialog();
        }
    }
}
