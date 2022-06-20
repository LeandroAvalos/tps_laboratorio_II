using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IDatosRequeridos
    {
        /// <summary>
        /// Propiedad de lectura y escritura que debera implementarse por la interfaz.
        /// </summary>
        double NumeroTelefonico { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que debera implementarse por la interfaz.
        /// </summary>
        string DireccionParticular { get; set; }

        /// <summary>
        /// Metodo para mostrar informacion que debera implementarse por la interfaz.
        /// </summary>
        /// <returns>Devolvera una string con datos.</returns>
        string Mostrar();
    }
}
