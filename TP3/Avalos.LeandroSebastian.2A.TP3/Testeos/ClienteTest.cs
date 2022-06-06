using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Testeos
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void SobrecargaIgual_ComparaSiDosClientesConMismoNumeroDeDocumentoSonIguales_DeberiaRetornarTrue()
        {
            //Arrange
            Cliente clienteUno = new Cliente(1, 36399374, "Sergio", "Perez", 1164987456, "Calle falsa 123", 25, true, new SeguroBasico(2022, "Honda", "Civic"));
            Cliente clienteDos = new Cliente(2, 36399374, "Ramon", "Falcon", 1123456897, "Falsa calle 321", 30, false, new SeguroBasico(2020, "Fiat", "147"));
            bool expected = true;
            bool actual;

            //Act
            actual = clienteUno == clienteDos;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SobrecargaDistinto_ComparaSiDosClientesConDistintoNumeroDeDocumentoSonDistintos_DeberiaRetornarFalse()
        {
            //Arrange
            Cliente clienteUno = new Cliente(1, 36399374, "Sergio", "Perez", 1164987456, "Calle falsa 123", 25, true, new SeguroBasico(2022, "Honda", "Civic"));
            Cliente clienteDos = new Cliente(2, 36399374, "Ramon", "Falcon", 1123456897, "Falsa calle 321", 30, false, new SeguroBasico(2020, "Fiat", "147"));
            bool expected = false;
            bool actual;

            //Act
            actual = clienteUno != clienteDos;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
