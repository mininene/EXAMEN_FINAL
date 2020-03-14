using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using EXAMEN_FINAL.Services.Repository.JugadoresRepository;
using EXAMEN_FINAL.Services.Repository.QueryPaisesRepository;

namespace EXAMEN_FINAL.Controllers
{
    public class QueryController : BaseController
    {
        // GET: Query
        public async Task<ActionResult> JugadoresEquipo(string id)
        {
            
            IJugadorRepository repositorio = new JugadorRepository();
            var lista = repositorio.ListadoPaisesJugadores(id);
            await repositorio.DatosApi();
            return View(lista.ToList());
        }




        public async Task< ActionResult> Equipos()
        {

            IJugadorRepository repositorio = new JugadorRepository();
            var Segundalista = repositorio.ListajugadorValido();
            await repositorio.DatosApi();
            return View(Segundalista);
        }
    }
}