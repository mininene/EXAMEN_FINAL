using EXAMEN_FINAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;

namespace EXAMEN_FINAL.DAL
{
    public class JugadorInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<JugadorContext>
    {
        //protected override void Seed(JugadorContext context)
        //{
        //    var ListaJugador = new List<Jugador>
        //    {
        //        new Jugador {NombreJugador = "Carson", Valoracion = 5, Pais = "Francia", Dorsal = 23},
        //        new Jugador {NombreJugador = "Luca", Valoracion = 7, Pais = "Greccia", Dorsal = 33},
        //        new Jugador {NombreJugador = "Fredd", Valoracion = 5, Pais = "Argentina", Dorsal = 12},
        //        new Jugador {NombreJugador = "Scotch", Valoracion = 5, Pais = "España", Dorsal = 08},
        //        new Jugador {NombreJugador = "Clustn", Valoracion = 5, Pais = "Mexico", Dorsal = 04},


        //    };




        //    ListaJugador.ForEach(s => context.Jugador.Add(s));
        //    context.SaveChanges();


        //}
    }

}