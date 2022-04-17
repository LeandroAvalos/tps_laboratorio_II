using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Metodo para validar que el char pasado por parametro sea + - * o /
        /// </summary>
        /// <param name="operador">Char a verificar si es un operador valido</param>
        /// <returns>Retornara el operador correspondiente si este era correcto, de lo contrario retornara + por default</returns>
        private static char ValidarOperador(char operador)
        {
            char operadorValido;

            if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
            {
                operadorValido = '+';
            }
            else
            {
                operadorValido = operador;
            }
            return operadorValido;
        }

        /// <summary>
        /// Metodo que realiza la operacion que corresponda entre dos objetos
        /// </summary>
        /// <param name="numero1">Primer objeto pasado por parametro</param>
        /// <param name="numero2">Segundo objeto pasado por parametro</param>
        /// <param name="operador">Char que contiene la operacion a realizar entre los objetos</param>
        /// <returns>Retorna la operacion realizada entre los dos objetos</returns>
        public static double Operar(Operando numero1, Operando numero2, char operador)
        {
            char operadorValido;
            operadorValido = ValidarOperador(operador);
            double resultado;

            switch (operadorValido)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                default:
                    resultado = numero1 / numero2;
                    break;
            }
            return resultado;
        }
    }
}
