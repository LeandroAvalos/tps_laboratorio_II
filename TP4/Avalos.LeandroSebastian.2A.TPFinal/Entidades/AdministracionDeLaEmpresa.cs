using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AdministracionDeLaEmpresa
    {
        private List<Cliente> listaDeClientes;

        public delegate void DelegadoMensajeID();
        public static event DelegadoMensajeID EventoMensajeID;

        /// <summary>
        /// Propiedad de lectura y escritura que devuelve la lista de clientes.
        /// </summary>
        public List<Cliente> ListaDeClientes
        {
            get { return this.listaDeClientes; }
            set { this.listaDeClientes = value; }
        }

        /// <summary>
        /// Constructor que inicializa las listas de clientes
        /// </summary>
        public AdministracionDeLaEmpresa()
        {
            this.listaDeClientes = new List<Cliente>();
        }

        /// <summary>
        /// Metodo que muestra los datos de los clientes que ya se encuentren en la lista de clientes.
        /// </summary>
        /// <returns>Retorna una string con los datos del cliente.</returns>
        public string Mostrar()
        {
            StringBuilder datosCliente = new StringBuilder();

            foreach (Cliente uncliente in listaDeClientes)
            {
                datosCliente.Append(uncliente.Mostrar());
            }

            return datosCliente.ToString();
        }

        /// <summary>
        /// Metodo que busca si un cliente se encuentra en la lista por numero de cliente.
        /// </summary>
        /// <param name="numeroCliente">Numero de cliente a chequear para comprobar si el cliente se encuentra en la lista.</param>
        /// <returns>Devuelve el indice en el que se encuentra el cliente en la lista. De lo contrario devuelve -1 si no hubo coincidencia.</returns>
        public int BuscarClientePorNumeroCliente(string numeroCliente)
        {
            int indice = -1;
            int contador = 0;

            foreach (Cliente unCliente in listaDeClientes)
            {
                if (unCliente == int.Parse(numeroCliente))
                {
                    indice = contador;
                    EventoMensajeID.Invoke();
                    break;
                }
                contador++;
            }
            return indice;
        }

        /// <summary>
        /// Sobrecarga del operador == para chequear si el cliente se encuentra en la lista de clientes de la Administracion.
        /// </summary>
        /// <param name="unaAdmin">AdministracionDeLaEmpresa que contiene la lista de clientes.</param>
        /// <param name="unCliente">Cliente a chequear si se encuentra en la lista.</param>
        /// <returns>Devuelve True si el cliente se encuentra en la lista. De lo contrario devuelve False.</returns>
        public static bool operator ==(AdministracionDeLaEmpresa unaAdmin, Cliente unCliente)
        {
            bool esValido = false;

            foreach (Cliente cliente in unaAdmin.listaDeClientes)
            {
                if (cliente == unCliente)
                {
                    esValido = true;
                    break;
                }
            }
            return esValido;
        }

        /// <summary>
        /// Sobrecarga del operador != para chequear si el cliente no se encuentra en la lista de clientes de la Administracion.
        /// </summary>
        /// <param name="unaAdmin">AdministracionDeLaEmpresa que contiene la lista de clientes.</param>
        /// <param name="unCliente">Cliente a chequear si no se encuentra en la lista.</param>
        /// <returns>Devuelve False si el cliente no se encuentra en la lista. De lo contrario devuelve True.</returns>
        public static bool operator !=(AdministracionDeLaEmpresa unaAdmin, Cliente unCliente)
        {
            return !(unaAdmin == unCliente);
        }

        /// <summary>
        /// Sobrecarga del operador == para chequear si un cliente se encuentra en la lista de clientes de la Administracion por medio de un numero de cliente.
        /// </summary>
        /// <param name="unaAdmin">AdministracionDeLaEmpresa que contiene la lista de clientes.</param>
        /// <param name="numCliente">Numero de cliente a chequear si se encuentra en la lista.</param>
        /// <returns>Devuelve True si el cliente se encuentra en la lista. De lo contrario devuelve False.</returns>
        public static bool operator ==(AdministracionDeLaEmpresa unaAdmin, int numCliente)
        {
            bool esValido = false;

            foreach (Cliente cliente in unaAdmin.listaDeClientes)
            {
                if (cliente == numCliente)
                {
                    esValido = true;
                    break;
                }
            }
            return esValido;
        }

        /// <summary>
        /// Sobrecarga del operador != para chequear si un cliente no se encuentra en la lista de clientes de la Administracion por medio de un numero de cliente.
        /// </summary>
        /// <param name="unaAdmin">AdministracionDeLaEmpresa que contiene la lista de clientes.</param>
        /// <param name="numCliente">Numero de cliente a chequear si no se encuentra en la lista.</param>
        /// <returns>Devuelve False si el cliente no se encuentra en la lista. De lo contrario devuelve True.</returns>
        public static bool operator !=(AdministracionDeLaEmpresa unaAdmin, int numCliente)
        {
            return !(unaAdmin == numCliente);
        }

        /// <summary>
        /// Sobrecarga del operador + que agrega un cliente a la lista de clientes de AdministracionDeLaEmpresa si este no se encuentra.
        /// </summary>
        /// <param name="unaAdmin">AdministracionDeLaEmpresa que contiene la lista donde se agregara el cliente.</param>
        /// <param name="unCliente">Cliente a agregar.</param>
        /// <returns>Devuelve una AdministracionDeLaEmpresa con el cliente ya agregado.</returns>
        public static AdministracionDeLaEmpresa operator +(AdministracionDeLaEmpresa unaAdmin, Cliente unCliente)
        {
            if (unaAdmin != unCliente)
            {
                unaAdmin.listaDeClientes.Add(unCliente);
            }
            else
            {
                throw new AgregarClienteException("El cliente con este dni ya se encuentra en el sistema.");
            }
            return unaAdmin;
        }
    }
}