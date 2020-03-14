using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EXAMEN_FINAL.Models;

namespace EXAMEN_FINAL.Services.Specification
{
    public class ValidationRegisterSpecification : IValidationRegisterSpecification
    {
        public bool IsSatisfiedBy(Jugador registroJugador)
        {


            return !registroJugador.NombreJugador.Equals("")
                   && registroJugador.NombreJugador!=null
                   && !registroJugador.NombreJugador.StartsWith("Z")

                   && !registroJugador.Pais.Equals("")
                   && registroJugador.Pais !=null
                   //&& !registroJugador.Pais.Equals("USA")
                   && registroJugador.Pais !="USA"

                   && registroJugador.Dorsal >= 0 && registroJugador.Dorsal <= 99
                   && registroJugador.Valoracion >= 0 && registroJugador.Valoracion <= 10;



        }
    }
}