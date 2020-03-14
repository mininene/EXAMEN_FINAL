using EXAMEN_FINAL.Models;
using EXAMEN_FINAL.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_FINAL.Services.Repository.JugadoresRepository
{
    public interface IJugadorRepository:IGenericRepository<Jugador>
    {
        IQueryable<Jugador> ListadoPaisesJugadores(string nombreEquipo);
        List<VMEquipo> ListajugadorValido();
    }
}
