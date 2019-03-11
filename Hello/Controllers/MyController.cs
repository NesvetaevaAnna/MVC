using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hello.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Any()
        {
            return Content("Hello,world!");
        }
        public ActionResult Some()
        {
            return View();
        }
    }
}