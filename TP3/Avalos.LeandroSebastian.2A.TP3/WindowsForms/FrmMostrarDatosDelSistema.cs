using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsForms
{
    public partial class FrmMostrarDatosDelSistema : Form
    {
        private AdministracionDeLaEmpresa unaAdministracion;

        /// <summary>
        /// Constructor que instancia un formulario MostrarDatosDelSistema.
        /// </summary>
        /// <param name="unaAdministracion">AdministracionDeLaEmpresa pasada por parametro.</param>
        public FrmMostrarDatosDelSistema(AdministracionDeLaEmpresa unaAdministracion)
        {
            InitializeComponent();
            this.unaAdministracion = unaAdministracion;
        }

        /// <summary>
        /// Metodo que recorre la lista de clientes e imprime en un richtextbox los clientes con estado activo.
        /// </summary>
        public void MostrarClientesActivos()
        {
            this.Text = "Listado de clientes activos";
            if(unaAdministracion.ListaDeClientes.Count > 0)
            {
                foreach (Cliente unCliente in unaAdministracion.ListaDeClientes)
                {
                    if (unCliente.EnServicio == true)
                    {
                        rtbMostrarDatos.Text += unCliente.Mostrar();
                    }
                }
            }
            else
            {
                rtbMostrarDatos.Text = "No hay clientes activos para mostrar";
            }
        }

        /// <summary>
        /// Meotodo que recorre la lista de sucursales y las imprime en el richtextbox.
        /// </summary>
        public void MostrarSucursales()
        {
            this.Text = "Listado de sucursales";
            if(unaAdministracion.ListaDeSecursales.Count > 0)
            {
                foreach (Sucursales unaSucursal in unaAdministracion.ListaDeSecursales)
                {
                    rtbMostrarDatos.Text += unaSucursal.Mostrar();
                }
            }
            else
            {
                rtbMostrarDatos.Text = "No hay sucursales para mostrar";
            }
        }

        /// <summary>
        /// Metodo que lee el archivo txt HistorialDeActividades y las imprime en el richtextbox.
        /// </summary>
        public void MostrarHistorial()
        {
            this.Text = "Historial de actividades";
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}" + @"HistorialDeActividades.txt"))
            {
                rtbMostrarDatos.Text += GestionDeArchivosTxt.Txt_Reader($"{AppDomain.CurrentDomain.BaseDirectory}" + @"HistorialDeActividades.txt");
            }
            else
            {
                rtbMostrarDatos.Text = "No hay un historial para mostrar";
            }  
        }
    }
}
