using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXAMEN_FINAL.InfraestructuraTransversal.ServicesException
{
    public class LogException:Exception
    {
        public LogException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}