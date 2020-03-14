using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXAMEN_FINAL.Models
{
    public partial class Jugador:IPersona
    {
        public int Id { get; set; }
        public string NombreJugador { get; set; }
        public decimal Valoracion { get; set; }
        public string Pais { get; set; }
        public int Dorsal { get; set; }
    }
}