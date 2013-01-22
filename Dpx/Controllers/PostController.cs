using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dpx.Core;

namespace Dpx.Controllers
{
    public class PostController : RavenController
    {
        public JsonResult Create(Post post)
        {
            //var post = new Post { Title = "RavenDB", Content = "How things are done!" };
            RavenSession.Store(post);
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}
