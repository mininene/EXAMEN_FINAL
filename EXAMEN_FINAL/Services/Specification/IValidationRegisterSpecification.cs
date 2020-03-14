using EXAMEN_FINAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_FINAL.Services.Specification
{
    public interface IValidationRegisterSpecification
    {
        bool IsSatisfiedBy(Jugador registroJugador);
    }
}
