using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Propiedad que setea el valor del atributo numero en la clase Operando
        /// </summary>
        private string Numero
        {
            set { this.numero = ValidarOperando(value); }
        }

        /// <summary>
        /// Constructor sin parametros que se encarga de iniciar el atributo en 0.
        /// </summary>
        public Operando() :this("0")
        {

        }

        /// <summary>
        /// Constructor que recibe como parametro un double.
        /// </summary>
        /// <param name="numero">Double recibido para asignarlo en el atributo del objeto</param>
        public Operando(double numero) :this(numero.ToString())
        {

        }

        /// <summary>
        /// Constructor que recibe como parametro un string.
        /// </summary>
        /// <param name="strNumero">String recibido para asignarlo en el atributo del objeto</param>
        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        /// <summary>
        /// Metodo para validar si el string pasado por parametro es un numero
        /// </summary>
        /// <param name="strNumero">String a chequear si es un numero</param>
        /// <returns>Retorna un double si el string era realmente un numero, de lo contrario retornara 0</returns>
        private double ValidarOperando(string strNumero)
        {
            double numeroValidado;
            if (double.TryParse(strNumero, out numeroValidado) == false)
            {
                numeroValidado = 0;
            }

            return numeroValidado;
        }

        /// <summary>
        /// Metodo para validar si el string pasado por parametro es un numero Binario
        /// </summary>
        /// <param name="binario">String a chequear si es un numero Binario</param>
        /// <returns>Retorna true si el string contiene 1 o 0, de lo contrario retornara false</returns>
        private static bool EsBinario(string binario)
        {
            bool esValido = true;

            foreach (char caracter in binario)
            {
                if (caracter != '0' && caracter != '1')
                {
                    esValido = false;
                    break;
                }
            }
            return esValido;
        }

        /// <summary>
        /// Metodo para convertir un numero Binario en Decimal
        /// </summary>
        /// <param name="binario">String que contiene el numero Binario para convertir en Decimal</param>
        /// <returns>Retorna el numero Binario convertido a Decimal en forma de string</returns>
        public static string BinarioDecimal(string binario)
        {
            int resultado = 0;
            int cantidadCaracteres = binario.Length;
            string resultadoBinario = "";
            if (Operando.EsBinario(binario) == true)
            {
                foreach (char caracter in binario)
                {
                    cantidadCaracteres--;
                    if (caracter == '1')
                    {
                        resultado += (int)Math.Pow(2, cantidadCaracteres);
                    }
                }
                resultadoBinario += resultado;
            }
            else
            {
                resultadoBinario = "Valor invalido";
            }
            return resultadoBinario;
        }

        /// <summary>
        /// Metodo para convertir un numero Decimal a Binario
        /// </summary>
        /// <param name="numero">Double que recibe para convertirlo a Binario</param>
        /// <returns>Retorna el numero Decimal convertido a Binario en forma de string</returns>
        public static string DecimalBinario(double numero)
        {
            string numeroAConvertir = "";
            double numeroAbsoluto = Math.Abs(numero);
            int doubleAEntero = (int)numeroAbsoluto;

            if (doubleAEntero > 0)
            {
                while (doubleAEntero != 0)
                {
                    if (doubleAEntero % 2 == 0)
                    {
                        numeroAConvertir = 0 + numeroAConvertir;

                    }
                    else if (doubleAEntero % 2 == 1)
                    {
                        numeroAConvertir = 1 + numeroAConvertir;
                    }

                    doubleAEntero /= 2;
                }
            }
            else
            {
                if (doubleAEntero == 0)
                {
                    numeroAConvertir = "0";
                }
                else
                {
                    numeroAConvertir = "Valor invalido";
                }
            }

            return numeroAConvertir;
        }

        /// <summary>
        /// Sobrecarga del metodo DecimalBinario en el cual ahora recibe un string en vez de un double
        /// </summary>
        /// <param name="numero">String que recibe para convertila en Binario</param>
        /// <returns>Retorna el numero Decimal convertido a Binario en forma de string</returns>
        public static string DecimalBinario(string numero)
        {
            string numeroAConvertir = "Valor Invalido";
            double numeroParseado = 0;

            if (double.TryParse(numero, out numeroParseado))
            {
                numeroAConvertir = DecimalBinario(numeroParseado);
            }

            return numeroAConvertir;
        }

        /// <summary>
        /// Sobrecarga del operador + para sumar los atributos de dos objetos.
        /// </summary>
        /// <param name="n1">Primer objeto pasado por parametro</param>
        /// <param name="n2">Segundo objeto pasado por parametro</param>
        /// <returns>Retorna la suma de los atributos de dos objetos</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador - para restar los atributos de dos objetos.
        /// </summary>
        /// <param name="n1">Primer objeto pasado por parametro</param>
        /// <param name="n2">Segundo objeto pasado por parametro</param>
        /// <returns>Retorna la resta de los atributos de dos objetos</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador * para multiplicar los atributos de dos objetos.
        /// </summary>
        /// <param name="n1">Primer objeto pasado por parametro</param>
        /// <param name="n2">Segundo objeto pasado por parametro</param>
        /// <returns>Retorna la multiplicacion de los atributos de dos objetos</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            double resultado;

            resultado = n1.numero * n2.numero;

            if(resultado == -0)
            {
                resultado = 0;
            }
           
            return resultado;
        }

        /// <summary>
        /// Sobrecarga del operador / para dividir los atributos de dos objetos.
        /// </summary>
        /// <param name="n1">Primer objeto pasado por parametro</param>
        /// <param name="n2">Segundo objeto pasado por parametro</param>
        /// <returns>Retorna la division de los atributos de dos objetos</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double resultado;
            if (n2.numero == 0)
            {
                resultado = double.MinValue;
            }
            else
            {
                resultado = n1.numero / n2.numero;
            }

            return resultado;
        }
    }
}
