using GrammatikLaxen.Data;
using GrammatikLaxen.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrammatikLaxen.Controllers
{
    public class SpelController : Controller
    {
        DbOperations db = new DbOperations();

        // GET: Spel
        public ActionResult Index()
        {
            List<toppresultat> allTopList = db.GetTop10List();

            return View(allTopList);
        }
    }
}