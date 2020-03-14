using EXAMEN_FINAL.Models;
using EXAMEN_FINAL.Services.Repository.JugadoresRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXAMEN_FINAL.Models.ViewModel;

namespace EXAMEN_FINAL.Services.Repository.QueryPaisesRepository
{
    public interface IQueryPaisesRepository: IGenericRepository<Jugador>
    {
        IQueryable<Jugador> ListadoPaisesJugadores(string nombreEquipo);
         List<VMEquipo> ListajugadorValido();

    }
}
