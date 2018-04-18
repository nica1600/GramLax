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
    }
}