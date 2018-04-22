using GrammatikLaxen.Data;
using GrammatikLaxen.Models;
using GrammatikLaxen.ViewModels;
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
            List<FragaSvar> fragaSvarList = new List<FragaSvar>();
            fragaSvarList.Clear();

            FragaSvar grammatikfraga = new FragaSvar();
            FragaSvar grammatikfraga2 = new FragaSvar();

            grammatikfraga = gf.SubstantivVilkenOrdklass();
            fragaSvarList.Add(grammatikfraga);

            grammatikfraga2 = gf.SubstantivVilkenOrdklass();
            fragaSvarList.Add(grammatikfraga2);
            
            return View(fragaSvarList);
        }

        public ActionResult Latt()
        {
            List<FragaSvar> fragaSvarList = new List<FragaSvar>();
            fragaSvarList.Clear();

            //tar fram 15 slumpvisa lätta frågor
            for (int i = 0; i < 15; i++)
            {
                FragaSvar grammatikFraga = new FragaSvar();
                Random rand = new Random();
                int randOrdklass = rand.Next(1, 2);

                // substantiv
                if (randOrdklass == 1)
                {
                    Random rand2 = new Random();
                    int randSubFraga = rand2.Next(1, 3);
                    
                    //vilken ordklass tillhör ordet
                    if (randSubFraga == 1)
                    {
                        grammatikFraga = gf.SubstantivVilkenOrdklass();
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //konkret eller abstrakt
                    else if (randSubFraga == 2)
                    {
                        grammatikFraga = gf.SubstantivKonkretAbstrakt();
                        fragaSvarList.Add(grammatikFraga);
                    }
                    else
                    {
                        //något felmeddelande
                    }

                }
                //pronomen
                else if (randOrdklass == 2)
                {

                }
                //adjektiv
                else if (randOrdklass == 3)
                {

                }
                //verb
                else if (randOrdklass == 4)
                {

                }
                //adverb
                else if (randOrdklass == 5)
                {

                }
                //preposition
                else if (randOrdklass == 6)
                {

                }
                //konjunktion
                else if (randOrdklass == 7)
                {

                }
                //räkneord
                else if (randOrdklass == 8)
                {

                }
                //interjektion
                else if (randOrdklass == 9)
                {

                }
                else
                {
                    //något felmeddelande
                }
            }

            return View(fragaSvarList);
        }
    }
}