using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Servicios
    {
        protected int precio;
        protected int anioDelVehiculo;
        protected string marcaDelVehiculo;
        protected string modeloDelVehiculo;

        /// <summary>
        /// Constructor sin parametros necesario para la serializacion.
        /// </summary>
        public Servicios()
        {

        }

        /// <summary>
        /// Constructor que inicializa un servicio.
        /// </summary>
        /// <param name="precio">Precio pasado por parametro.</param>
        /// <param name="anioDelVehiculo">Año del vehiculo pasado por parametro.</param>
        /// <param name="marcaDelVehiculo">Marca del vehiculo pasado por parametro.</param>
        /// <param name="modeloDelVehiculo">Modelo del vehiculo pasado por parametro.</param>
        public Servicios(int precio, int anioDelVehiculo, string marcaDelVehiculo, string modeloDelVehiculo)
        {
            this.precio = precio;
            this.anioDelVehiculo = anioDelVehiculo;
            this.marcaDelVehiculo = marcaDelVehiculo;
            this.modeloDelVehiculo = modeloDelVehiculo;
        }

        /// <summary>
        /// Propiedad de lectura y escritura de precio.
        /// </summary>
        public int Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de año del vehiculo.
        /// </summary>
        public int AnioDelVehiculo
        {
            get { return this.anioDelVehiculo; }
            set { this.anioDelVehiculo = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de marca del vehiculo.
        /// </summary>
        public string MarcaDelVehiculo
        {
            get { return this.marcaDelVehiculo; }
            set { this.marcaDelVehiculo = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de modelo del vehiculo.
        /// </summary>
        public string ModeloDelVehiculo
        {
            get { return this.modeloDelVehiculo; }
            set { this.modeloDelVehiculo = value; }   
        }

        /// <summary>
        /// Propiedad de lectura y escritura abstracta que debera ser implementada por las clases derivadas.
        /// </summary>
        public abstract bool CoberturaPorChoque { get; set; }
        /// <summary>
        /// Propiedad de lectura y escritura abstracta que debera ser implementada por las clases derivadas.
        /// </summary>
        public abstract bool CoberturaPorRobo { get; set; }
        /// <summary>
        /// Propiedad de lectura y escritura abstracta que debera ser implementada por las clases derivadas.
        /// </summary>
        public abstract bool CoberturaPorGranizo { get; set; }
        /// <summary>
        /// Propiedad de lectura y escritura abstracta que debera ser implementada por las clases derivadas.
        /// </summary>
        public abstract bool CoberturaPorIncendioParcial { get; set; }
        /// <summary>
        /// Propiedad de lectura y escritura abstracta que debera ser implementada por las clases derivadas.
        /// </summary>
        public abstract bool CoberturaDeParabrisasYLuneta { get; set; }
        /// <summary>
        /// Propiedad de lectura y escritura abstracta que debera ser implementada por las clases derivadas.
        /// </summary>
        public abstract bool CoberturaReposicionDeAirbag { get; set; }
        /// <summary>
        /// Propiedad de lectura y escritura abstracta que debera ser implementada por las clases derivadas.
        /// </summary>
        public abstract bool CoberturaSeguroDelConductor { get; set; }
        /// <summary>
        /// Propiedad de lectura y escritura abstracta que debera ser implementada por las clases derivadas.
        /// </summary>
        public abstract bool CoberturaPorAccidenteTotal { get; set; }
        /// <summary>
        /// Propiedad de lectura y escritura abstracta que debera ser implementada por las clases derivadas.
        /// </summary>
        public abstract bool CoberturaPorIncendioTotal { get; set; }

        /// <summary>
        /// Metodo para mostrar un servicio.
        /// </summary>
        /// <returns>Devuelve una string con los datos del servicio.</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Datos del Seguro\n");

            sb.AppendLine($"Tipo de seguro: {this.GetType().Name}");
            sb.AppendLine($"Precio: {this.Precio}$");
            sb.AppendLine($"Año del vehiculo: {this.AnioDelVehiculo}");
            sb.AppendLine($"Marca del vehiculo: {this.MarcaDelVehiculo}");
            sb.AppendLine($"Modelo del vehiculo: {this.ModeloDelVehiculo}");
            sb.AppendLine("\nCoberturas:");
            
            if (CoberturaPorChoque)
            {
                sb.AppendLine($" -> Tiene cobertura por choque");
            }
           
            if (CoberturaPorRobo)
            {
                sb.AppendLine($" -> Tiene cobertura por robo");
            }
            
            if (CoberturaPorGranizo)
            {
                sb.AppendLine($" -> Tiene cobertura por granizo");
            }

            if (CoberturaPorIncendioParcial)
            {
                sb.AppendLine($" -> Tiene cobertura por incendio parcial");
            }
            else
            {
                sb.AppendLine($" -> No tiene cobertura por incendio parcial");
            }

            if (CoberturaDeParabrisasYLuneta)
            {
                sb.AppendLine($" -> Tiene cobertura de parabrisas y luneta");
            }
            else
            {
                sb.AppendLine($" -> No tiene cobertura de parabrisas y luneta");
            }

            if (CoberturaReposicionDeAirbag)
            {
                sb.AppendLine($" -> Tiene cobertura de reposicion de airbag");
            }
            else
            {
                sb.AppendLine($" -> No tiene cobertura de reposicion de airbag");
            }

            if (CoberturaSeguroDelConductor)
            {
                sb.AppendLine($" -> Tiene cobertura de seguro del conductor");
            }
            else
            {
                sb.AppendLine($" -> No tiene cobertura de seguro del conductor");
            }

            if (CoberturaPorAccidenteTotal)
            {
                sb.AppendLine($" -> Tiene cobertura por accidente total");
            }
            else
            {
                sb.AppendLine($" -> No tiene cobertura por accidente total");
            }

            if (CoberturaPorIncendioTotal)
            {
                sb.AppendLine($" -> Tiene cobertura por incendio total\n");
            }
            else
            {
                sb.AppendLine($" -> No tiene cobertura por incendio total\n");
            }

            return sb.ToString();
        }
    }
}
