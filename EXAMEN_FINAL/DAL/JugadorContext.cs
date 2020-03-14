using EXAMEN_FINAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EXAMEN_FINAL.DAL
{
    public class JugadorContext: DbContext
    {

        public JugadorContext() : base("JugadorContext")
        { }

        public DbSet<Jugador> Jugador { get; set; }

        public System.Data.Entity.DbSet<EXAMEN_FINAL.Models.ViewModel.VMEquipo> VMEquipoes { get; set; }
    }
}