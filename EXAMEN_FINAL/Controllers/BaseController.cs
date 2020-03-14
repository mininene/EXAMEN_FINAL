using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using EXAMEN_FINAL.Services.Log;

namespace EXAMEN_FINAL.Controllers
{
    public abstract class BaseController:Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            ILog log = new ProdutionLog();
            
            if (filterContext.ExceptionHandled)
            {
                return;
            }

            log.WriteLog(filterContext.Exception.Message);
            filterContext.Result = new ViewResult
            {
                ViewName = "~/Views/Shared/Error.csthml"
            };
            filterContext.ExceptionHandled = true;
        }

    }
}