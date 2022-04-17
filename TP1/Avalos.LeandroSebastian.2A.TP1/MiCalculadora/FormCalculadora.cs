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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que cuando se inicializa el form carga con valores el combo box de operadores y limpia todo lo que se ve en pantalla.
        /// </summary>
        /// <param name="sender">Parametro referido a quien provoco el evento</param>
        /// <param name="e">Parametro que contiene data del evento</param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.Items.Add("");
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("/");
            Limpiar();
        }

        /// <summary>
        /// Evento que al hacer click en el boton limpiar, limpia todo lo que se ve en pantalla
        /// </summary>
        /// <param name="sender">Parametro referido a quien provoco el evento</param>
        /// <param name="e">Parametro que contiene data del evento</param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Metodo para limpiar lo que se muestra en el Form.
        /// </summary>
        private void Limpiar()
        {
            cmbOperador.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
        }

        /// <summary>
        /// Evento que al hacer click en el boton cerrar, cierra el form.
        /// </summary>
        /// <param name="sender">Parametro referido a quien provoco el evento</param>
        /// <param name="e">Parametro que contiene data del evento</param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo para realizar la operacion que corresponda entre dos numeros
        /// </summary>
        /// <param name="numero1">String que contiene el primer numero</param>
        /// <param name="numero2">String que contiene el segundo numero</param>
        /// <param name="operador">String que contiene el operador</param>
        /// <returns>Retorna el resultado de la operacion realzada entre dos numeros</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operador1 = new Operando(numero1);
            Operando operador2 = new Operando(numero2);
            char operadorConvertido = char.Parse(operador);

            return Calculadora.Operar(operador1, operador2, operadorConvertido);
        }

        /// <summary>
        /// Evento que al hacer click en el boton operar, realiza la operacion matematica correspondiente.
        /// </summary>
        /// <param name="sender">Parametro referido a quien provoco el evento</param>
        /// <param name="e">Parametro que contiene data del evento</param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string resultado;
            double numeroChequeadoUno;
            double numeroChequeadoDos;

            if (cmbOperador.Text == "")
            {
                cmbOperador.Text = "+";
            }

            if (txtNumero1.Text == "")
            {
                txtNumero1.Text = "0";
            }
            if (txtNumero2.Text == "")
            {
                txtNumero2.Text = "0";
            }

            if (double.TryParse(txtNumero1.Text.Replace(".", ","), out numeroChequeadoUno) == false)
            {
                numeroChequeadoUno = 0;
            }
            if (double.TryParse(txtNumero2.Text.Replace(".", ","), out numeroChequeadoDos) == false)
            {
                numeroChequeadoDos = 0;
            }
            resultado = FormCalculadora.Operar(numeroChequeadoUno.ToString(), numeroChequeadoDos.ToString(), cmbOperador.Text).ToString();

            if (double.Parse(resultado) == double.MinValue)
            {
                lblResultado.Text = "Error.No se puede dividir por 0";
            }
            else
            {
                lblResultado.Text = resultado;
            }

            lstOperaciones.Items.Add($"{numeroChequeadoUno} {cmbOperador.Text} {numeroChequeadoDos} = {resultado}");
        }

        /// <summary>
        /// Evento que al hacer click en el boton Convertir a Binario, convierte el resultado de la operacion en Binario.
        /// </summary>
        /// <param name="sender">Parametro referido a quien provoco el evento</param>
        /// <param name="e">Parametro que contiene data del evento</param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
                lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);
            }
            else
            {
                lblResultado.Text = "Error";
            }
        }

        /// <summary>
        /// Evento que al hacer click en el boton Convertir a Decimal, convierte el resultado de la operacion en Decimal.
        /// </summary>
        /// <param name="sender">Parametro referido a quien provoco el evento</param>
        /// <param name="e">Parametro que contiene data del evento</param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
                lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
            }
            else
            {
                lblResultado.Text = "Error";
            }
        }

        /// <summary>
        /// Evento que se ejecuta al querer cerrar el Form, el cual da un mensaje preguntando al usuario si quiere salir.
        /// </summary>
        /// <param name="sender">Parametro referido a quien provoco el evento</param>
        /// <param name="e">Parametro que contiene data del evento</param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult chequeado = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (chequeado == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (chequeado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
