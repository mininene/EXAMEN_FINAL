using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EXAMEN_FINAL.Models
{
    public class JugadorMetadata
    {
        public int Id { get; set; }
        [Required]

        [RegularExpression("^(?!(Z|z).*$).*", ErrorMessage = "No puede Comenzar con Z")]
        public string NombreJugador { get; set; }
        [Required]
        [Range(1, 10, ErrorMessage = "Valoracion entre 1 y 10")]
        public decimal Valoracion { get; set; }
        [Required]
        [RegularExpression("^(?!(USA|usa)$).*$", ErrorMessage = "No puede ser USA")]
        public string Pais { get; set; }
        [Required]
        [Range(0, 99, ErrorMessage = "Rango entre 0 y 99")]
        public int Dorsal { get; set; }

    }

    [MetadataType(typeof(JugadorMetadata))]
    public partial class Jugador
    { }
}