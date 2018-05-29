using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrammatikLaxen.Controllers
{
    public class SidanController : Controller
    {
        // GET: Sidan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Om()
        {
            return View();
        }

        public ActionResult Kontakt()
        {
            return View();
        }
    }
}