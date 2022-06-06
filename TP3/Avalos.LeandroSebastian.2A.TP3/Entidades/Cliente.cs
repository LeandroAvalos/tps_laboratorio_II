using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(SeguroBasico))]
    [XmlInclude(typeof(SeguroIntermedio))]
    [XmlInclude(typeof(SeguroContraTodo))]
    public class Cliente : IDatosRequeridos
    {
        private int numeroDeCliente;
        private int documento;
        private string nombre;
        private string apellido;
        private double numeroTelefonico;
        private string direccionParticular;
        private int edad;
        private bool enServicio;
        Servicios servicio;

        /// <summary>
        /// Constructor sin parametros para poder serializar.
        /// </summary>
        public Cliente()
        {

        }

        /// <summary>
        /// Constructor que instancia un Cliente.
        /// </summary>
        /// <param name="numeroDeCliente">Numero de cliente del cliente.</param>
        /// <param name="documento">Numero de documento del cliente.</param>
        /// <param name="nombre">Nombre del cliente.</param>
        /// <param name="apellido">Apellido del cliente.</param>
        /// <param name="numeroTelefonico">Numero de telefono del cliente.</param>
        /// <param name="direccionParticular">Direccion particular del cliente.</param>
        /// <param name="edad">Edad del cliente.</param>
        /// <param name="enServicio">Estado activo o no del cliente</param>
        /// <param name="servicio">Servicio contratado por el cliente.</param>
        public Cliente(int numeroDeCliente, int documento, string nombre, string apellido, double numeroTelefonico, string direccionParticular, int edad, bool enServicio , Servicios servicio)
        {
            this.numeroDeCliente = numeroDeCliente;
            this.documento = documento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.numeroTelefonico = numeroTelefonico;
            this.direccionParticular = direccionParticular;
            this.edad = edad;
            this.enServicio = true;
            this.servicio = servicio;
        }

        /// <summary>
        /// Propiedad de lectura y escritura del numero de cliente.
        /// </summary>
        public int NumeroDeCliente
        {
            get { return this.numeroDeCliente; }
            set { this.numeroDeCliente = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del numero del documento.
        /// </summary>
        public int Documento
        {
            get { return this.documento; }
            set { this.documento = value; }   
        }
        /// <summary>
        /// Propiedad de lectura y escritura del nombre.
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del apellido.
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del numero de telefono.
        /// </summary>
        public double NumeroTelefonico
        {
            get { return this.numeroTelefonico; }
            set { this.numeroTelefonico = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de la direccion.
        /// </summary>
        public string DireccionParticular
        {
            get { return this.direccionParticular; }
            set { this.direccionParticular = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de la edad.
        /// </summary>
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del estado activo o no del cliente.
        /// </summary>
        public bool EnServicio
        {
            get { return this.enServicio; }
            set { this.enServicio = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del servicio adquirido por el cliente.
        /// </summary>
        public Servicios Servicio
        {
            get { return this.servicio; }
            set { this.servicio = value; }
        }

        /// <summary>
        /// Metodo que muestra los datos del cliente.
        /// </summary>
        /// <returns>Retorna una string con los datos del cliente.</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Datos del cliente:\n");

            sb.AppendLine($"Numero de cliente: {this.NumeroDeCliente}");
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Edad: {this.Edad}");
            sb.AppendLine($"Documento: {this.Documento}");
            sb.AppendLine($"Numero de telefono: {this.NumeroTelefonico}");
            sb.AppendLine($"Direccion particular: {this.DireccionParticular}\n");
            sb.Append(servicio.Mostrar());

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador == para comparar si dos clientes son iguales mediante su numero de cliente.
        /// </summary>
        /// <param name="c1">Primer cliente a comparar.</param>
        /// <param name="c2">Segundo cliente a comparar.</param>
        /// <returns>Devuelve true si son iguales los clientes. De lo contrario devuelve false.</returns>
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numeroDeCliente == c2.numeroDeCliente || c1.documento == c2.documento;
        }

        /// <summary>
        /// Sobrecarga del operador != para comparar si dos clientes son distintos mediante su numero de cliente.
        /// </summary>
        /// <param name="c1">Primer cliente a comparar.</param>
        /// <param name="c2">Segundo cliente a comparar.</param>
        /// <returns>Devuelve false si los clientes son distintos. De lo contrario devuelve true.</returns>
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        /// <summary>
        /// Sobrecarga del operador == para comparar si el numero de cliente de un cliente coincide con el numero de cliente pasado por parametro.
        /// </summary>
        /// <param name="c1">Cliente a comparar.</param>
        /// <param name="numCliente">Numero de cliente a comparar.</param>
        /// <returns>Devuelve true si el numero de cliente del cliente es igual al numero de cliente pasado por parametro. De lo contrario devuelve false.</returns>
        public static bool operator ==(Cliente c1, int numCliente)
        {
            return c1.numeroDeCliente == numCliente;
        }

        /// <summary>
        /// Sobrecarga del operador != para comparar si el numero de cliente de un cliente es distinto al numero de cliente pasado por parametro.
        /// </summary>
        /// <param name="c1">Cliente a comparar.</param>
        /// <param name="numCliente">Numero de cliente a comparar.</param>
        /// <returns>Devuelve false si el numero de cliente del cliente es distinto al numero de cliente pasado por parametro. De lo contrario devuelve true.</returns>
        public static bool operator !=(Cliente c1, int numCliente)
        {
            return !(c1 == numCliente);
        }
    }
}
