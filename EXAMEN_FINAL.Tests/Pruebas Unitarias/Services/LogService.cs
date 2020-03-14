using EXAMEN_FINAL.Services.Log;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_FINAL.Tests.Pruebas_Unitarias.Services
{
    [TestClass]
    public class LogService
    {

        public string Contain="";
        private readonly  ILog _log = new ProdutionLog();

        [TestInitialize]
        public void LogServiceInit()
        {
            Contain = "Esto es una prueba de funcionamiento!";
            _log.WriteLog(Contain);
        }

        [TestMethod]
        public void LogWrite()
        {
            _log.WriteLog(Contain);
        }

    }
}
