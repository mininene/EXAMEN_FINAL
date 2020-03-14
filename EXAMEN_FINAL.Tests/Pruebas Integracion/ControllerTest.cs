using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using EXAMEN_FINAL.Controllers;
using EXAMEN_FINAL.Services.Repository.JugadoresRepository;
using EXAMEN_FINAL.Models;

namespace EXAMEN_FINAL.Tests.Pruebas_Integracion
{
    [TestClass]
    public class ControllerTest
    {
        JugadorController controller = new JugadorController();
        private IJugadorRepository repositorio = new JugadorRepository();
        private Jugador jugador = new Jugador { NombreJugador = "Clustn", Valoracion = 5, Pais = "Mexico", Dorsal = 04 };

        [TestMethod]
        public async Task Index()

        {
            var resultado = await controller.Index();
            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado is ActionResult);

        }

        [TestMethod]
        public async Task create()

        {
           repositorio.Insert(jugador);
           await repositorio.Save();
            var guardado = await repositorio.GetById(jugador.Id);
            Assert.IsNotNull(guardado);

        }
    }
}
