using Raven.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dpx.Presentation.Controllers
{
    public abstract class RavenController : Controller
    {
        public static IDocumentStore Store { get; set; }
        public IDocumentSession Session { get; set; }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Session = (IDocumentSession)HttpContext.Items["CurrentRequestRavenSession"];
        }

        protected new JsonResult Json(object data) 
        {
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
