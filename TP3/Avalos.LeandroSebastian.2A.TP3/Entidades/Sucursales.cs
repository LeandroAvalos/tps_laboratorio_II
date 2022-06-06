using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursales : IDatosRequeridos
    {
        private string barrio;
        private double numeroTelefonico;
        private string direccionParticular;
        private string codigoDeSecursal;
        private string abiertoDe;
        private string abiertoHasta;
        private string apertura;
        private string cierre;

        /// <summary>
        /// Constructor sin parametros necesario para la serializacion.
        /// </summary>
        public Sucursales()
        {

        }

        /// <summary>
        /// Constructor que instancia una sucursal.
        /// </summary>
        /// <param name="barrio">Barrio pasado por parametro.</param>
        /// <param name="numeroTelefonico">Numero de telefono pasado por parametro.</param>
        /// <param name="direccionParticular">Direccion pasada por parametro.</param>
        /// <param name="codigoDeSecursal">Codigo de la sucursal pasado por parametro.</param>
        /// <param name="abiertoDe">Desde que dia abre la sucursal pasada por parametro.</param>
        /// <param name="abiertoHasta">Hasta que dia abre la sucursal pasada por parametro.</param>
        /// <param name="apertura">Horario de apertura pasada por parametro.</param>
        /// <param name="cierre">Horario de cierre pasado por parametro.</param>
        public Sucursales(string barrio, double numeroTelefonico, string direccionParticular, string codigoDeSecursal
            ,string abiertoDe, string abiertoHasta, string apertura, string cierre)
        {
            this.barrio = barrio;
            this.numeroTelefonico = numeroTelefonico;
            this.direccionParticular = direccionParticular;
            this.codigoDeSecursal = codigoDeSecursal;
            this.abiertoDe = abiertoDe;
            this.abiertoHasta = abiertoHasta;
            this.apertura = apertura;
            this.cierre = cierre;
        }

        /// <summary>
        /// Propiedad de lectura y escritura de barrio.
        /// </summary>
        public string Barrio
        {
            get { return this.barrio; }
            set { this.barrio = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de numero de telefono.
        /// </summary>
        public double NumeroTelefonico
        {
            get { return this.numeroTelefonico; }
            set { this.numeroTelefonico = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de la direccion de la sucursal..
        /// </summary>
        public string DireccionParticular
        {
            get { return this.direccionParticular; }
            set { this.direccionParticular = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del codigo de la sucursal.
        /// </summary>
        public string CodigoDeSucursal
        {
            get { return this.codigoDeSecursal; }
            set { this.codigoDeSecursal = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura desde que dia abre la sucursal.
        /// </summary>
        public string AbiertoDe
        {
            get { return this.abiertoDe; }
            set { this.abiertoDe = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura hasta que dia abre la sucursal.
        /// </summary>
        public string AbiertoHasta
        {
            get { return this.abiertoHasta; }
            set { this.abiertoHasta = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura horario de apertura de la sucursal.
        /// </summary>
        public string Apertura
        {
            get { return this.apertura; }
            set { this.apertura = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura horario de cierre de la sucursal.
        /// </summary>
        public string Cierre
        {
            get { return this.cierre; }
            set { this.cierre = value; }
        }

        /// <summary>
        /// Metodo para mostrar los datos de una sucursal.
        /// </summary>
        /// <returns>Devuelve una string con los datos de la sucursal.</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Datos de la sucursal: \n");

            sb.AppendLine($"Nombre de la sucursal: {this.barrio}");
            sb.AppendLine($"Numero de telefono: {this.numeroTelefonico}");
            sb.AppendLine($"Direccion: {this.direccionParticular}");
            sb.AppendLine($"Codigo de la sucursal: {this.codigoDeSecursal}");
            sb.AppendLine($"Abierto de: {this.abiertoDe} a {this.abiertoHasta}");
            sb.AppendLine($"Horario de apertura y cierre: {this.apertura}hs a {this.cierre}hs\n");

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador == para comparar si dos sucursales son iguales mediante su numero de telefono y su direccion.
        /// </summary>
        /// <param name="sucursal1">Primera sucursal a comparar.</param>
        /// <param name="sucursal2">Segunda sucursal a comparar.</param>
        /// <returns>Devuelve true si las dos sucursales son iguales. De lo contrario devuelve false.</returns>
        public static bool operator ==(Sucursales sucursal1, Sucursales sucursal2)
        {
            return sucursal1.direccionParticular == sucursal2.direccionParticular; 
        }

        /// <summary>
        /// Sobrecarga del operador != para comparar si dos sucursales son no iguales.
        /// </summary>
        /// <param name="sucursal1">Primera sucursal a comparar.</param>
        /// <param name="sucursal2">Segunda sucursal a comparar.</param>
        /// <returns>Devuelve false si las dos sucursales no son iguales. De lo contrario devuelve true.</returns>
        public static bool operator !=(Sucursales sucursal1, Sucursales sucursal2)
        {
            return !(sucursal1 == sucursal2);
        }
    }
}
