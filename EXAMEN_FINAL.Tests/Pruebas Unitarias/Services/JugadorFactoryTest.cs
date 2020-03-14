using EXAMEN_FINAL.Services.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXAMEN_FINAL.Services.Specification;
using EXAMEN_FINAL.Models;

namespace EXAMEN_FINAL.Tests.Pruebas_Unitarias.Services
{
    [TestClass]
    public class JugadorFactoryTest
    {
         IJugadorFactory _factory = new JugadorFactory();
        IValidationRegisterSpecification _validationRegisterSpecification = new ValidationRegisterSpecification();
      
        [TestMethod]
        public void Factory()
        {
            List<Jugador> jugador = new List<Jugador> { new Jugador { NombreJugador = "Clustn", Valoracion = 5, Pais = "Mexico", Dorsal = 04 } };

            var factoriajugador = _factory.CreateJugador(jugador);

            Assert.IsNotNull(factoriajugador);
            //Assert.AreEqual(jugador, factoriajugador);
        }

        //[TestMethod]
        //public void CreateObjectStringCollectionNull()
        //{
        //    Assert.Throws<FactoryException>(() => _factory.CreateRebeld(_stringCollectionEmpty));
        //}






    }
}
