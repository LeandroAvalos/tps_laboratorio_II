using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Testeos
{
    [TestClass]
    public class AdministracionDeLaEmpresaTest
    {
        [TestMethod]
        public void BuscarClientePorNumeroCliente_SiElClienteSeEncuentraEnLaLista_DeberiaDevolverElIndice()
        {
            //Arrange
            AdministracionDeLaEmpresa unaAdmin = new AdministracionDeLaEmpresa();
            Cliente clienteUno = new Cliente(1, 36399374, "Sergio", "Perez", 1164987456, "Calle falsa 123", 25, true, new SeguroBasico(2022, "Honda", "Civic"));
            Cliente clienteDos = new Cliente(2, 40569874, "Ramon", "Falcon", 1123456897, "Falsa calle 321", 30, false, new SeguroBasico(2020, "Fiat", "147"));
            unaAdmin += clienteUno;
            unaAdmin += clienteDos;
            int expected = 1;
            int actual;

            //Act
            actual = unaAdmin.BuscarClientePorNumeroCliente("2");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BuscarClientePorNumeroCliente_SiElClienteNoSeEncuentraEnLaLista_DeberiaDevolverMenosUno()
        {
            //Arrange
            AdministracionDeLaEmpresa unaAdmin = new AdministracionDeLaEmpresa();
            Cliente clienteUno = new Cliente(1, 36399374, "Sergio", "Perez", 1164987456, "Calle falsa 123", 25, true, new SeguroBasico(2022, "Honda", "Civic"));
            Cliente clienteDos = new Cliente(2, 40654598, "Ramon", "Falcon", 1123456897, "Falsa calle 321", 30, false, new SeguroBasico(2020, "Fiat", "147"));
            unaAdmin += clienteUno;
            unaAdmin += clienteDos;
            int expected = -1;
            int actual;

            //Act
            actual = unaAdmin.BuscarClientePorNumeroCliente("3");

            //Assert
            Assert.AreEqual(expected, actual);
        }  

        [TestMethod]
        [ExpectedException(typeof(AgregarClienteException))]
        public void SobrecargaMas_SiSeIntentaAgregarUnClienteYSeEncuentraEnLaLista_DeberiaLanzarAgregarClienteException()
        {
            //Arrange
            AdministracionDeLaEmpresa unaAdmin = new AdministracionDeLaEmpresa();
            Cliente clienteUno = new Cliente(1, 36399374, "Sergio", "Perez", 1164987456, "Calle falsa 123", 25, true, new SeguroBasico(2022, "Honda", "Civic"));
            Cliente clienteDos = new Cliente(2, 36399374, "Ramon", "Falcon", 1123456897, "Falsa calle 321", 30, false, new SeguroBasico(2020, "Fiat", "147"));

            //Act
            unaAdmin += clienteUno;
            unaAdmin += clienteDos;
        }
    }
}
