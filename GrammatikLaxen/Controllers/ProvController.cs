using GrammatikLaxen.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrammatikLaxen.Controllers
{
    public class ProvController : Controller
    {
        DbOperations db = new DbOperations();
        GrammatikFragor gf = new GrammatikFragor();

        // GET: Prov
        public ActionResult Index()
        {
            var ordet = gf.VilketOrdSubstantiv();
            return View(ordet);
        }
    }
}