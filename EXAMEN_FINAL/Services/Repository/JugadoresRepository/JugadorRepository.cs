using EXAMEN_FINAL.Models;
using EXAMEN_FINAL.Services.Specification;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using EXAMEN_FINAL.Services.Factory;
using EXAMEN_FINAL.Models.ViewModel;

namespace EXAMEN_FINAL.Services.Repository.JugadoresRepository
{
    public class JugadorRepository:GenericRepository<Jugador>, IJugadorRepository
    {
       

        public override async Task DatosApi()

        {
         IValidationRegisterSpecification _validationRegisterSpecification = new ValidationRegisterSpecification();
         IJugadorFactory jugadorFactory = new JugadorFactory();


            using (var client = new HttpClient())
            {

                try
                {
                    HttpResponseMessage response = client.GetAsync("https://webbasketapi.azurewebsites.net/api/jugadores").Result;
                    List<Jugador> lista;
                    string contenido = response.Content.ReadAsStringAsync().Result;
                    {

                        lista = JsonConvert.DeserializeObject<List<Jugador>>(contenido);
                    }

                    //table.RemoveRange(table);
                    foreach (var item in table)
                    {
                        table.Remove(item);

                    }

                    
                    var listaValida= jugadorFactory.CreateJugador(lista);

                    //table.AddRange(listaValida);

                    foreach (var item in listaValida)
                    {
                        table.Add(item);

                    }
                    await _context.SaveChangesAsync();


                    //foreach (var item in lista)
                    //{
                    //    if (_validationRegisterSpecification.IsSatisfiedBy(item))
                    //    {
                    //        table.Add(item);
                    //        await _context.SaveChangesAsync();
                    //    }
                    //}

                }
                catch { }

                

            }
        }

        public IQueryable<Jugador> ListadoPaisesJugadores(string nombreEquipo)
        {
            var query = _context.Jugador.Where(j => j.Pais == nombreEquipo);

            return query;
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
        }
    }
}