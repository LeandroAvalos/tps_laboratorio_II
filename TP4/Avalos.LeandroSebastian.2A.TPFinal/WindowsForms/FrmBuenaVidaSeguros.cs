using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsForms
{
    public partial class FrmBuenaVidaSeguros : Form
    {
        private AdministracionDeLaEmpresa unaAdministracion;
        private string mensaje = $"Se dio de baja un cliente en el sistema el {DateTime.Now:f}";
        private Random random;

        public delegate void DelegadoHilos(ProgressBar barraProgresiva, Label tituloBarra);
        private DelegadoHilos delegadoHilos;

        public delegate void DelegadoApagadoEncendido(ProgressBar barraProgresiva);
        public event DelegadoApagadoEncendido EventoApagarYPrender;


        /// <summary>
        /// Constructor que instancia al formulario princiapl.
        /// </summary>
        public FrmBuenaVidaSeguros()
        {
            InitializeComponent();
            this.unaAdministracion = new AdministracionDeLaEmpresa();
            this.random = new Random();
            this.EventoApagarYPrender += ApagarYPrenderBoton;
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
        /// Evento Load que chequea si el archivos serializado en formato xml correspondiente a las lista de clientes existe e inicia el hilo segundaario para la progress bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBuenaVidaSeguros_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}" + @"Clientes.xml"))
            {
                this.unaAdministracion.ListaDeClientes = GestionDeArchivos<List<Cliente>>.Xml_Reader($"{AppDomain.CurrentDomain.BaseDirectory}" + @"Clientes.xml");
            }

            this.IniciarHilo();
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
                            GestionDeArchivos<List<Cliente>>.Xml_Serializer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"Clientes.xml", unaAdministracion.ListaDeClientes);
                            GestionDeArchivos<string>.Txt_Writer($"{AppDomain.CurrentDomain.BaseDirectory}" + @"HistorialDeActividades.txt", mensaje,true);
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

        /// <summary>
        /// Metodo para iniciar la Task que correra en segundo plano la progress bar
        /// </summary>
        private void IniciarHilo()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            Task task = new Task(() => ArranqueDeProceso(progressBar, lblBarraDeProgreso, cancellationTokenSource), token);
            task.Start();         
        }

        /// <summary>
        /// Metodo que mientras la progress bar no este en su valor maximo llamara a el metodo IncrementoDeBarraProgreso para incrementar su valor
        /// y esto lo realiza en un intervalo randomn de 0,1ms a 1 segundo
        /// </summary>
        /// <param name="barraProgresiva">Barra de progreso enviada por parametro</param>
        /// <param name="tituloBarra">Label que pertenece al progreso de la barra de progreso</param>
        private void ArranqueDeProceso(ProgressBar barraProgresiva, Label tituloBarra, CancellationTokenSource cancellationTokenSource)
        {
            while (barraProgresiva.Value < barraProgresiva.Maximum && !cancellationTokenSource.IsCancellationRequested)
            {
                Thread.Sleep(random.Next(100, 400));
                IncrementoDeBarraProgreso(barraProgresiva, tituloBarra);
            }
        }

        /// <summary>
        /// Metodo que incrementa el valor de la barra de progreso y va actualizando el valor en el Label de la barra de progreso.
        /// </summary>
        /// <param name="barraProgresiva">Barra de progreso enviada por parametro</param>
        /// <param name="tituloBarra">Label que pertenece al progreso de la barra de progreso</param>
        private void IncrementoDeBarraProgreso(ProgressBar barraProgresiva, Label tituloBarra)
        {
            if (this.InvokeRequired)
            {
                delegadoHilos = IncrementoDeBarraProgreso;
                object[] parametros = new object[] { barraProgresiva, tituloBarra };
                this.Invoke(delegadoHilos,parametros);
            }
            else
            {
                barraProgresiva.Increment(1);
                tituloBarra.Text = $"Cargando datos de sucursales.. {barraProgresiva.Value}%";

                EventoApagarYPrender.Invoke(barraProgresiva);
            }
        }

        /// <summary>
        /// Metodo que corresponde al EventoApagarYPrender el cual si el valor de la barra de progreso es menor al maximo desabilita el boton de las sucursales
        /// y si el valor es igual al maximo envia un mensaje y desabilita la barra y el label de la barra.
        /// </summary>
        /// <param name="barraProgresiva">Barra de progreso enviada por parametro</param>
        public void ApagarYPrenderBoton(ProgressBar barraProgresiva)
        {
            if(barraProgresiva.Value < barraProgresiva.Maximum)
            {
                btnSucursales.Enabled = false;
            }
            else if(barraProgresiva.Value == barraProgresiva.Maximum)
            {
                btnSucursales.Enabled = true;
                MessageBox.Show("Se han terminado de cargar los archivos de las sucursales.\nYa puede acceder al boton de sucursales.", "Carga de archivos Completa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                barraProgresiva.Visible = false;
                lblBarraDeProgreso.Visible = false;
            }
        }
    }
}
