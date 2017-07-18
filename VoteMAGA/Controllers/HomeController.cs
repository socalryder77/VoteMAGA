using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VoteMAGA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "VoteMAGA - Coming Soon";

            return View();
        }

        public ActionResult PleaseClap()
        {
            ViewBag.Title = "Candidate";

            return View();
        }


        public ActionResult ViewPage1()
        {
            ViewBag.Title = "ViewPageTest";

            return View();
        }
    }
}
