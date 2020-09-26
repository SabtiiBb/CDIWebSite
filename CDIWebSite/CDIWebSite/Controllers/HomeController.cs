using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDIWebSite.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult JoinUs()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Growth()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Preachings()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Care()
        {
            return View();
        }
    }
}