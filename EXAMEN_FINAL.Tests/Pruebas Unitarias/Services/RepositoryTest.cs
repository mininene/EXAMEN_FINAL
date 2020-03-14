using EXAMEN_FINAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXAMEN_FINAL.Services.Factory;
using EXAMEN_FINAL.Services.Repository.JugadoresRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EXAMEN_FINAL.Tests.Pruebas_Unitarias.Services
{
    [TestClass]
    public class RepositoryTest
    {
        private IJugadorRepository repositorio = new JugadorRepository();
        private Jugador jugador = new Jugador {NombreJugador = "Clustn", Valoracion = 5, Pais = "Mexico", Dorsal = 04};


        [TestMethod]
        public async Task Repositorio()
        {

            repositorio.Insert(jugador);
            await repositorio.Save();
            var guardado =  await repositorio.GetById(jugador.Id);
            Assert.IsNotNull(guardado);
            Assert.AreEqual(jugador.Id,guardado.Id);
        }



    }
}
