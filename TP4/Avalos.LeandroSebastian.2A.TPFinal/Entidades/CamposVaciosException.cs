using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CamposVaciosException : Exception
    {
        /// <summary>
        /// Constructor que instancia excepciones de tipo CamposVaciosException.
        /// </summary>
        /// <param name="mensaje">Mensaje que se lanzara cuando ocurra la excepcion.</param>
        public CamposVaciosException(string mensaje) :this(mensaje, null)
        {

        }

        /// <summary>
        /// Constructor que instancia excepciones de tipo CamposVaciosException.
        /// </summary>
        /// <param name="mensaje">Mensaje que se lanzara cuando ocurra la excepcion.</param>
        /// <param name="innerException">Proporciona información sobre la excepcion interna.</param>
        public CamposVaciosException(string mensaje, Exception innerException) :base(mensaje,innerException)
        {

        }
    }
}
