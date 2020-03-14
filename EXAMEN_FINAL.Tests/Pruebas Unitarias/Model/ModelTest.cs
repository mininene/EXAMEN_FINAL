using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXAMEN_FINAL.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EXAMEN_FINAL.Tests.Pruebas_Unitarias.Model
{
    [TestClass]
    public class ModelTest
    {

        [TestMethod]
        public void JugadorCorrecto()
        {
            Jugador jugador = new Jugador {NombreJugador = "Carson", Valoracion = 5, Pais = "Francia", Dorsal = 23};
            Assert.IsNotNull(jugador);
            Assert.IsTrue(!string.IsNullOrEmpty(jugador.NombreJugador));
        }








    }
}
