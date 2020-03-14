using EXAMEN_FINAL.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr.Runtime.Misc;

namespace EXAMEN_FINAL.Services.Factory
{
    public interface IJugadorFactory
    {
        List<Jugador> CreateJugador(List<Jugador> jugador);
    }
}
