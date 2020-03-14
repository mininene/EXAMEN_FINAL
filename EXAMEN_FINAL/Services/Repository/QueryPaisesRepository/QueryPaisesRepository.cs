using EXAMEN_FINAL.Models;
using EXAMEN_FINAL.Services.Repository.JugadoresRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc.Html;
using EXAMEN_FINAL.Models.ViewModel;

namespace EXAMEN_FINAL.Services.Repository.QueryPaisesRepository
{
    public  class QueryPaisesRepository : GenericRepository<Jugador>, IQueryPaisesRepository
    {
        public IQueryable<Jugador> ListadoPaisesJugadores(string nombreEquipo)
        {
            //var query = from jugador in _context.Jugador
            //    orderby jugador.NombreJugador
            //    select jugador;
            //var query = _context.Jugador.OrderByDescending(o => o.Valoracion);

            var query = _context.Jugador.Where(j => j.Pais == nombreEquipo);

            return query;
        }

        public override Task DatosApi()
        {
            throw new NotImplementedException();
        }

    

        public List<VMEquipo> ListajugadorValido()
        {
            var nuevaListaEquipos = new List<VMEquipo>();
            var SegundoQuery = (from j in _context.Jugador
                               group j by j.Pais
                into equipo
                               select new
                               {
                                   Nombre = equipo.Key,
                                   NumeroJugadores = equipo.Count(),
                                   MediaEquipo = equipo.Sum(m => m.Valoracion) / equipo.Count()
                               }).Where(y => y.NumeroJugadores >= 3 && y.MediaEquipo > 5);

           
            foreach (var item in SegundoQuery)
            {
                var nuevoEquipos = new VMEquipo();
                nuevoEquipos.NombreEquipo = item.Nombre;
                nuevoEquipos.NumeroJugadores = item.NumeroJugadores;
                nuevoEquipos.Media = item.MediaEquipo;
                nuevaListaEquipos.Add(nuevoEquipos);
            }

            return nuevaListaEquipos;

            

            //var nuevaListaEquipos = new List<Jugador>();
            //var SegundoQuery = _context.Jugador.GroupBy(
            //    p => p,
            //    p => p.Pais,
            //    (key, equipo) => new
            //        { Nombre = key,
            //            NumeroJugadores =equipo.Count(),
            //            Media =equipo.Sum(m=>key.Valoracion)/equipo.Count()
            //        });
            //var TercerQuery = SegundoQuery.Where(y => y.NumeroJugadores > 3 && y.Media> 5);
            //return nuevaListaEquipos;
        } 
    }
}