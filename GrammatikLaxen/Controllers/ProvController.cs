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
            
            FragaSvar grammatikFraga = new FragaSvar();
            int fragaNummer = 0;

            Random rand = new Random();

            //tar fram 15 slumpvisa lätta frågor
            for (int i = 0; i < 15; i++)
            {
                int randOrdklass = rand.Next(1, 10); //sätt alltid till 10 efter tester!
                fragaNummer++;

                // substantiv
                if (randOrdklass == 1)
                {
                    Random rand2 = new Random();
                    int randSubFraga = rand2.Next(1, 3);
                    
                    //vilken ordklass tillhör ordet
                    if (randSubFraga == 1)
                    {
                        grammatikFraga = gf.SubstantivVilkenOrdklass();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //konkret eller abstrakt
                    else if (randSubFraga == 2)
                    {
                        grammatikFraga = gf.SubstantivKonkretAbstrakt();
                        grammatikFraga.Nummer = fragaNummer;
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
                    Random rand2 = new Random();
                    int randProFraga = rand2.Next(1, 8);

                    //vilken ordklass tillhör ordet
                    if (randProFraga == 1)
                    {
                        grammatikFraga = gf.PronomenVilkenOrdklass();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    // till personliga subjektform
                    else if (randProFraga == 2)
                    {
                        grammatikFraga = gf.PronomenPersonligaSubjekt();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    // till personliga objektform
                    else if (randProFraga == 3)
                    {
                        grammatikFraga = gf.PronomenPersonligaObjekt();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    // till possessiva utrum
                    else if (randProFraga == 4)
                    {
                        grammatikFraga = gf.PronomenPossessivaUtrum();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    // till possessiva neutrum
                    else if (randProFraga == 5)
                    {
                        grammatikFraga = gf.PronomenPossessivaNeutrum();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    // till possessiva plural
                    else if (randProFraga == 6)
                    {
                        grammatikFraga = gf.PronomenPossessivaPlural();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    // till reflexiva
                    else if (randProFraga == 7)
                    {
                        grammatikFraga = gf.PronomenReflexiva();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    else
                    {
                        //något felmeddelande
                    }
                }
                //adjektiv
                else if (randOrdklass == 3)
                {
                    Random rand2 = new Random();
                    int randAdjFraga = rand2.Next(1, 7);
                    
                    //vilken ordklass tillhör ordet
                    if (randAdjFraga == 1)
                    {
                        grammatikFraga = gf.AdjektivVilkenOrdklass();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i obestämd form utrum
                    else if (randAdjFraga == 2)
                    {
                        grammatikFraga = gf.AdjektivObestämdUtrum();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i obestämd form neutrum
                    else if (randAdjFraga == 3)
                    {
                        grammatikFraga = gf.AdjektivObestämdNeutrum();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i bestämd form ej maskulinum
                    else if (randAdjFraga == 4)
                    {
                        grammatikFraga = gf.AdjektivBestämdFormEjMaskulinum();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i singular
                    else if (randAdjFraga == 5)
                    {
                        grammatikFraga = gf.AdjektivSingular();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i plural
                    else if (randAdjFraga == 6)
                    {
                        grammatikFraga = gf.AdjektivPlural();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    else
                    {
                        //något felmeddelande
                    }
                }
                //verb
                else if (randOrdklass == 4)
                {
                    Random rand2 = new Random();
                    int randVerbFraga = rand2.Next(1, 6);

                    //vilken ordklass tillhör ordet
                    if (randVerbFraga == 1)
                    {
                        grammatikFraga = gf.VerbVilkenOrdklass();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vilken typ av verb
                    else if (randVerbFraga == 2)
                    {
                        grammatikFraga = gf.VerbVilkenTyp();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i infinitv
                    else if (randVerbFraga == 3)
                    {
                        grammatikFraga = gf.VerbInfinitiv();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i preteritum
                    else if (randVerbFraga == 4)
                    {
                        grammatikFraga = gf.VerbPreteritum();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i supinum
                    else if (randVerbFraga == 5)
                    {
                        grammatikFraga = gf.VerbSupinum();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    else
                    {
                        //något felmeddelande
                    }
                }
                //adverb
                else if (randOrdklass == 5)
                {
                    Random rand2 = new Random();
                    int randAdvFraga = rand2.Next(1, 3);

                    //vilken ordklass tillhör ordet
                    if (randAdvFraga == 1)
                    {
                        grammatikFraga = gf.AdverbVilkenOrdklass();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vilken typ av adverb
                    else if (randAdvFraga == 2)
                    {
                        grammatikFraga = gf.AdverbVilkenTyp();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    else
                    {
                        //något felmeddelande
                    }
                }
                //preposition
                else if (randOrdklass == 6)
                {
                    Random rand2 = new Random();
                    int randPreFraga = rand2.Next(1, 2);

                    //vilken ordklass tillhör ordet
                    if (randPreFraga == 1)
                    {
                        grammatikFraga = gf.PrepositionVilkenOrdklass();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    else
                    {
                        //något felmeddelande
                    }
                }
                //konjunktion
                else if (randOrdklass == 7)
                {
                    Random rand2 = new Random();
                    int randKonFraga = rand2.Next(1, 2);

                    //vilken ordklass tillhör ordet
                    if (randKonFraga == 1)
                    {
                        grammatikFraga = gf.KonjunktionVilkenOrdklass();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    else
                    {
                        //något felmeddelande
                    }
                }
                //räkneord
                else if (randOrdklass == 8)
                {
                    Random rand2 = new Random();
                    int randRakFraga = rand2.Next(1, 4);

                    //vilken ordklass tillhör ordet
                    if (randRakFraga == 1)
                    {
                        grammatikFraga = gf.RakneordVilkenOrdklass();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet som grundtal
                    else if (randRakFraga == 2)
                    {
                        grammatikFraga = gf.RakneordGrundtal();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet som ordningstal
                    else if (randRakFraga == 3)
                    {
                        grammatikFraga = gf.RakneordOrdningstal();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    else
                    {
                        //något felmeddelande
                    }
                }
                //interjektion
                else if (randOrdklass == 9)
                {
                    Random rand2 = new Random();
                    int randIntFraga = rand2.Next(1, 2);

                    //vilken ordklass tillhör ordet
                    if (randIntFraga == 1)
                    {
                        grammatikFraga = gf.InterjektionVilkenOrdklass();
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    else
                    {
                        //något felmeddelande
                    }
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