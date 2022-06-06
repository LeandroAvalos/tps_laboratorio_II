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
    public partial class FrmBuenaVidaSeguros : Form
    {
        private AdministracionDeLaEmpresa unaAdministracion;
        private string mensaje = $"Se dio de baja un cliente en el sistema el {DateTime.Now:f}";

        /// <summary>
        /// Constructor que instancia al formulario princiapl.
        /// </summary>
        public FrmBuenaVidaSeguros()
        {
            InitializeComponent();
            this.unaAdministracion = new AdministracionDeLaEmpresa();
        }

        /// <summary>
        /// Evento Click del boton alta cliente que instancia un formulario de alta cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frmAltaCliente = new FrmAltaCliente(unaAdministracion);

            frmAltaCliente.ShowDialog();
        }

        /// <summary>
        /// Evento Load que chequea si los archivos serializados en formato xml y json correspondientes a las listas de clientes y sucursales existen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBuenaVidaSeguros_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}" + @"Clientes.xml"))
            {
                this.unaAdministracion.ListaDeClientes = GestionDeArchivosSerializados<List<Cliente>>.Xml_Reader($"{AppDomain.CurrentDomain.BaseDirectory}" + @"Clientes.xml");
            }

            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}" + @"Sucursales.json"))
            {
                this.unaAdministracion.ListaDeSecursales = GestionDeArchivosSerializados<List<Sucursales>>.Json_Reader($"{AppDomain.CurrentDomain.BaseDirectory}" + @"Sucursales.json");
            }
        }

        /// <summary>
        /// Evento Click del boton salir para cerrar el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento Click del boton clientes activos. Instancia un formulario MostrarDatosDelSistema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientesActivos_Click(object sender, EventArgs e)
        {
            FrmMostrarDatosDelSistema clientesActivosYSucursales = new FrmMostrarDatosDelSistema(unaAdministracion);

            clientesActivosYSucursales.MostrarClientesActivos();

            clientesActivosYSucursales.ShowDialog();
        }

        /// <summary>
        /// Evento Click del boton modificar cliente. Instancia un formulario ChequeoDeDatos para saber si el cliente existe y si existe se instancia un formulario OpcionesModificacion para realizar las modificaciones pertinentes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (unaAdministracion.ListaDeClientes.Count > 0)
            {
                FrmChequeoDeDatos frmChequeoDeDatos = new FrmChequeoDeDatos("Chequeo de numero de cliente", "Por favor ingrese el numero de cliente"
                , unaAdministracion, "numeroDeCliente", 0);

                frmChequeoDeDatos.ShowDialog();

                if (frmChequeoDeDatos.DialogResult == DialogResult.OK && unaAdministracion.ListaDeClientes[frmChequeoDeDatos.Indice].EnServicio == true)
                {
                    FrmOpcionesModificacion frmOpcionesModificacion = new FrmOpcionesModificacion(unaAdministracion, frmChequeoDeDatos.Indice);

                    frmOpcionesModificacion.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay clientes para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        /// <summary>
        /// Evento Click del boton baja cliente. Instancia un formulario ChequeoDeDAtos para chequear si el cliente existe 
        /// y si existe se pregunta si realmente se quiere dar de baja. Si se elige que si, se cambia el estado de la persona a false para hacer una baja logica,
        /// se serializa el cambio en la lista y se genera un txt con lo ocurrido. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            if(unaAdministracion.ListaDeClientes.Count > 0)
            {
                FrmChequeoDeDatos frmChequeoDeDatos = new FrmChequeoDeDatos("Chequeo de numero de cliente", "Por favor ingrese el numero de cliente"
                , unaAdministracion, "numeroDeCliente", 0);

                frmChequeoDeDatos.ShowDialog();

                if (frmChequeoDeDatos.DialogResult == DialogResult.OK && unaAdministracion.ListaDeClientes[frmChequeoDeDatos.Indice].EnServicio == true)
                {
                    DialogResult chequeo = MessageBox.Show("Esta seguro que quiere dar de baja a este cliente?", "Dar de baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (chequeo == DialogResult.Yes)
                    {
                        try
                        {
                            this.unaAdministracion.ListaDeClientes[frmChequeoDeDatos.Indice].EnServicio = false;
                            GestionDeArchivosSerializados<List<Cliente>>.Xml_Serializer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"Clientes.xml", unaAdministracion.ListaDeClientes);
                            GestionDeArchivosTxt.Txt_Writer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"HistorialDeActividades.txt", mensaje,true);
                            MessageBox.Show("Se ah dado de baja al cliente exitosamente", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    else
                    {
                        MessageBox.Show("Se ah cancelado la baja", "Baja cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay clientes para dar de baja", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento Click del boton sucursales. Instancia un formulario MenuSucursales.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSucursales_Click(object sender, EventArgs e)
        {
            FrmMenuSucursales frmMenuSucursales = new FrmMenuSucursales(unaAdministracion);

            frmMenuSucursales.ShowDialog();
        }

        /// <summary>
        /// Evento Click del boton HistorialDeActividades. Instancia un formulario MostrarDatosDelSistema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistorialDeActividades_Click(object sender, EventArgs e)
        {
            FrmMostrarDatosDelSistema frmMostrarDatosDelSistema = new FrmMostrarDatosDelSistema(unaAdministracion);

            frmMostrarDatosDelSistema.MostrarHistorial();

            frmMostrarDatosDelSistema.ShowDialog();
        }
    }
}
