using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SeguroContraTodo : Servicios
    {
        /// <summary>
        /// Constructor sin parametros necesario para la serializacion.
        /// </summary>
        public SeguroContraTodo()
        {

        }
        /// <summary>
        /// Constructor que instancia un seguro contra todo.
        /// </summary>
        /// <param name="anioDelVehiculo">Año del vehiculo recibido por parametro.</param>
        /// <param name="marcaDelVehiculo">Marca del vehiculo recibido por parametro.</param>
        /// <param name="modeloDelVehiculo">Modelo del vehiculo recibido por parametro.</param>
        public SeguroContraTodo(int anioDelVehiculo, string marcaDelVehiculo, string modeloDelVehiculo) : base(10000, anioDelVehiculo, marcaDelVehiculo, modeloDelVehiculo)
        {

        }

        /// <summary>
        /// Propiedad de lectura y escritura de Cobertura por choque. El setter esta vacio porque no lo utilizo pero necesito que este por la serializacion.
        /// </summary>
        public override bool CoberturaPorChoque
        {
            get { return true; }
            set { }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de Cobertura por Robo. El setter esta vacio porque no lo utilizo pero necesito que este por la serializacion.
        /// </summary>
        public override bool CoberturaPorRobo
        {
            get { return true; }
            set { }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de Cobertura por Granizo. El setter esta vacio porque no lo utilizo pero necesito que este por la serializacion.
        /// </summary>
        public override bool CoberturaPorGranizo
        {
            get { return true; }
            set { }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de Cobertura por Incendio parcial.. El setter esta vacio porque no lo utilizo pero necesito que este por la serializacion.
        /// </summary>
        public override bool CoberturaPorIncendioParcial
        {
            get { return true; }
            set { }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de Cobertura de Parabrisas y luneta. El setter esta vacio porque no lo utilizo pero necesito que este por la serializacion.
        /// </summary>
        public override bool CoberturaDeParabrisasYLuneta
        {
            get { return true; }
            set { }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de Cobertura de Reposicion de airbag. El setter esta vacio porque no lo utilizo pero necesito que este por la serializacion.
        /// </summary>
        public override bool CoberturaReposicionDeAirbag
        {
            get { return true; }
            set { }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de Cobertura de Seguro del conductor. El setter esta vacio porque no lo utilizo pero necesito que este por la serializacion.
        /// </summary>
        public override bool CoberturaSeguroDelConductor
        {
            get { return true; }
            set { }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de Cobertura por Accidente total. El setter esta vacio porque no lo utilizo pero necesito que este por la serializacion.
        /// </summary>
        public override bool CoberturaPorAccidenteTotal
        {
            get { return true; }
            set { }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de Cobertura por Incendio total. El setter esta vacio porque no lo utilizo pero necesito que este por la serializacion.
        /// </summary>
        public override bool CoberturaPorIncendioTotal
        {
            get { return true; }
            set { }
        }
    }
}
