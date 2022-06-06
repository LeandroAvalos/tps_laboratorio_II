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
    public partial class FrmMenuSucursales : Form
    {
        private AdministracionDeLaEmpresa unaAdministracion;

        /// <summary>
        /// Constructor que Instancia un formulario MenuSucursales.
        /// </summary>
        /// <param name="unaAdministracion">AdministracionDeLaEmpresa recibida por parametro.</param>
        public FrmMenuSucursales(AdministracionDeLaEmpresa unaAdministracion)
        {
            InitializeComponent();
            this.unaAdministracion = unaAdministracion;
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
        /// Evento Click del boton agregar sucursal. Instancia un formulario de tipo AgregarSucursal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            FrmAgregarSucursal frmAgregarSucursal = new FrmAgregarSucursal(unaAdministracion);

            frmAgregarSucursal.ShowDialog();
        }

        /// <summary>
        /// Evento Click del boton ver sucursales. Instancia un formulario de tipo MostrarDatosDelSistema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerSucursales_Click(object sender, EventArgs e)
        {
            FrmMostrarDatosDelSistema frmMostrarDatosDelSistema = new FrmMostrarDatosDelSistema(unaAdministracion);

            frmMostrarDatosDelSistema.MostrarSucursales();

            frmMostrarDatosDelSistema.ShowDialog();
        }
    }
}
