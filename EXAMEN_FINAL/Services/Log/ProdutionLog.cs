using EXAMEN_FINAL.InfraestructuraTransversal.ServicesException;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace EXAMEN_FINAL.Services.Log
{
    public class ProdutionLog : ILog
    {
        
        public void WriteLog(string mensaje)
        {

            var date = DateTime.Now;

            try
            {
                Console.WriteLine($"[{date}] {mensaje}");
            }
            catch (Exception ex)
            {
                throw new LogException("No se ha podido escribir en la consola", ex);
            }
        }

    }
}
