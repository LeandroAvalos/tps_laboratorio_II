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
    public class SucursalesTest
    {
        [TestMethod]
        public void SobrecargaIgual_ComparaSiDosSucursalesConMismaDireccionSonIguales_DeberiaRetornarTrue()
        {
            //Arrange
            Sucursales sucursalUno = new Sucursales("Palermo", 1123456789, "CalleFalsa123", "845DF", "Lunes", "Viernes", "08:00", "16:00");
            Sucursales sucursalDos = new Sucursales("Caballito", 1123456789, "CalleFalsa123", "845DF", "Lunes", "Viernes", "08:00", "16:00");
            bool expected = true;
            bool actual;

            //Act
            actual = sucursalUno == sucursalDos;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SobrecargaDistinto_ComparaSiDosSucursalesConMismaDireccionSonDistintos_DeberiaRetornarFalse()
        {
            //Arrange
            Sucursales sucursalUno = new Sucursales("Palermo", 1123456789, "CalleFalsa123", "845DF", "Lunes", "Viernes", "08:00", "16:00");
            Sucursales sucursalDos = new Sucursales("Caballito", 1123456789, "CalleFalsa123", "845DF", "Lunes", "Viernes", "08:00", "16:00");
            bool expected = false;
            bool actual;

            //Act
            actual = sucursalUno != sucursalDos;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
