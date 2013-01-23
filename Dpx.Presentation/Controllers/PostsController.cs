using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dpx.Domain;

namespace Dpx.Presentation.Controllers
{
    public class PostsController : RavenController
    {
        //[HttpGet]
        public JsonResult Index()
        {
            return Json(Session.Query<Post>());
        }

        //[HttpGet]
        public JsonResult Show(int id)
        {
            return Json(Session.Load<Post>(id));
        }

        //[HttpGet]
        public JsonResult New(Post post)
        {
            return Json("New");
        }

        //[HttpPost]
        public JsonResult Create(Post post)
        {
            Session.Store(post);
            return Json("Post created successfully");
        }

        //[HttpGet]
        public JsonResult Edit(Post post)
        {
            return Json("Edit");
        }

        //[HttpPut]
        public JsonResult Update(Post post)
        {
            Session.Store(post);
            return Json("Post updated successfully");
        }

        //[HttpDelete]
        public JsonResult Destroy(Post post)
        {
            Session.Delete(post);
            return Json("Post deleted successfully");
        }
    }
}
