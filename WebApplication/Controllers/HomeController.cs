using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using BusinessObject;


namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Blog()
        {
            List<blogBO> model = new blogBL().GetBlog();
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            List<blogBO> model = new blogBL().GetBlog();
            var getId = model.Single(m => m.blog_id == id);

            return View(getId);
        }
        public ActionResult DeleteBlog(int id)
        {
            List<blogBO> model = new blogBL().GetBlog();
            var getId = model.Single(m => m.blog_id == id);

            return View(getId);
        }

      
    }


}