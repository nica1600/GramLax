using GrammatikLaxen.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrammatikLaxen.Controllers
{
    public class HomeController : Controller
    {
        DbOperations db = new DbOperations();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Substantiv()
        {
            var substantivList = db.GetAllSubstantivList();
            return View(substantivList.ToList());
        }

        public ActionResult Pronomen()
        {
            var pronomenList = db.GetAllPronomenList();
            return View(pronomenList.ToList());
        }

        public ActionResult Adjektiv()
        {
            var adjektivList = db.GetAllAdjektivList();
            return View(adjektivList.ToList());
        }

        public ActionResult Verb()
        {
            var verbList = db.GetAllVerbList();
            return View(verbList.ToList());
        }
    }
}