using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dpx.Presentation.Controllers
{
    public class HomeController : RavenController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
