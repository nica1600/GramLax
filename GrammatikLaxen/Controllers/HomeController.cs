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
    }
}