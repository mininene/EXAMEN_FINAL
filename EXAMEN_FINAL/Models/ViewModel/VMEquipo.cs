using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EXAMEN_FINAL.Models.ViewModel
{
    public class VMEquipo
    {
       [Key]
        public string NombreEquipo { get; set; }
        public int NumeroJugadores { get; set; }
        public decimal Media { get; set; }
       
    }
}