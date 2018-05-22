using GrammatikLaxen.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrammatikLaxen.Controllers
{
    public class OrdklassController : Controller
    {
        DbOperations db = new DbOperations();

        // GET: Ordklass
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SubstantivTabell()
        {
            var substantivList = db.GetAllSubstantivList();
            return View(substantivList.ToList());
        }

        public ActionResult PronomenTabell()
        {
            var PronomenList = db.GetAllPronomenList();
            return View(PronomenList.ToList());
        }

        public ActionResult AdjektivTabell()
        {
            var AdjektivList = db.GetAllAdjektivList();
            return View(AdjektivList.ToList());
        }

        public ActionResult VerbTabell()
        {
            var VerbList = db.GetAllVerbList();
            return View(VerbList.ToList());
        }

        public ActionResult AdverbTabell()
        {
            var AdverbList = db.GetAllAdverbList();
            return View(AdverbList.ToList());
        }

        public ActionResult PrepositionTabell()
        {
            var PrepositionList = db.GetAllPrepositionList();
            return View(PrepositionList.ToList());
        }

        public ActionResult KonjunktionTabell()
        {
            var KonjunktionList = db.GetAllKonjunktionList();
            return View(KonjunktionList.ToList());
        }

        public ActionResult RakneordTabell()
        {
            var RakneordList = db.GetAllRäkneordList();
            return View(RakneordList.ToList());
        }

        public ActionResult InterjektionTabell()
        {
            var InterjektionList = db.GetAllInterjektionList();
            return View(InterjektionList.ToList());
        }
    }
}