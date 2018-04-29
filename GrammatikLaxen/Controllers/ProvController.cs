using GrammatikLaxen.Data;
using GrammatikLaxen.Models;
using GrammatikLaxen.Models.db;
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
            return View();
        }

        public ActionResult Niva1()
        {
            List<FragaSvar> fragaSvarList = new List<FragaSvar>();
            fragaSvarList.Clear();

            List<substantiv> allSubList = db.GetAllSubstantivList();
            List<pronomen> allProList = db.GetAllPronomenList();
            List<adjektiv> allAdjList = db.GetAllAdjektivList();
            List<verb> allVerList = db.GetAllVerbList();
            List<adverb> allAdvRenLattList = db.GetAllAdverbList();
            List<preposition> allPreList = db.GetAllPrepositionList();
            List<konjunktion> allKonList = db.GetAllKonjunktionList();
            List<räkneord> allRakList = db.GetAllRäkneordList();
            List<interjektion> allIntList = db.GetAllInterjektionList();

            FragaSvar grammatikFraga;
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
                    int randSubFraga = rand.Next(1, 3);
                    
                    //vilken ordklass tillhör ordet
                    if (randSubFraga == 1)
                    {
                        Random rand3 = new Random();
                        substantiv subForNow = new substantiv();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 200);
                                subForNow = allSubList.SingleOrDefault(a => a.Id == randomId);
                                if (subForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allSubList.Remove(subForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.SubstantivVilkenOrdklass(subForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //konkret eller abstrakt
                    else if (randSubFraga == 2)
                    {
                        Random rand3 = new Random();
                        substantiv subForNow = new substantiv();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 200);
                                subForNow = allSubList.SingleOrDefault(a => a.Id == randomId);
                                if (subForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allSubList.Remove(subForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.SubstantivKonkretAbstrakt(subForNow);
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
                    int randProFraga = rand.Next(1, 8);

                    //vilken ordklass tillhör ordet
                    if (randProFraga == 1)
                    {
                        Random rand3 = new Random();
                        pronomen proForNow = new pronomen();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 30);
                                proForNow = allProList.SingleOrDefault(a => a.Id == randomId);
                                if (proForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allProList.Remove(proForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.PronomenVilkenOrdklass(proForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    // till personliga subjektform
                    else if (randProFraga == 2)
                    {
                        Random rand3 = new Random();
                        pronomen proForNow = new pronomen();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 30);
                                proForNow = allProList.SingleOrDefault(a => a.Id == randomId);
                                if (proForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allProList.Remove(proForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.PronomenPersonligaSubjekt(proForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    // till personliga objektform
                    else if (randProFraga == 3)
                    {
                        Random rand3 = new Random();
                        pronomen proForNow = new pronomen();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 30);
                                proForNow = allProList.SingleOrDefault(a => a.Id == randomId);
                                if (proForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allProList.Remove(proForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.PronomenPersonligaObjekt(proForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    // till possessiva utrum
                    else if (randProFraga == 4)
                    {
                        Random rand3 = new Random();
                        pronomen proForNow = new pronomen();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 30);
                                proForNow = allProList.SingleOrDefault(a => a.Id == randomId);
                                if (proForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allProList.Remove(proForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.PronomenPossessivaUtrum(proForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    // till possessiva neutrum
                    else if (randProFraga == 5)
                    {
                        Random rand3 = new Random();
                        pronomen proForNow = new pronomen();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 30);
                                proForNow = allProList.SingleOrDefault(a => a.Id == randomId);
                                if (proForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allProList.Remove(proForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.PronomenPossessivaNeutrum(proForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    // till possessiva plural
                    else if (randProFraga == 6)
                    {
                        Random rand3 = new Random();
                        pronomen proForNow = new pronomen();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 30);
                                proForNow = allProList.SingleOrDefault(a => a.Id == randomId);
                                if (proForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allProList.Remove(proForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.PronomenPossessivaPlural(proForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    // till reflexiva
                    else if (randProFraga == 7)
                    {
                        Random rand3 = new Random();
                        pronomen proForNow = new pronomen();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 30);
                                proForNow = allProList.SingleOrDefault(a => a.Id == randomId);
                                if (proForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allProList.Remove(proForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.PronomenReflexiva(proForNow);
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
                    int randAdjFraga = rand.Next(1, 7);
                    
                    //vilken ordklass tillhör ordet
                    if (randAdjFraga == 1)
                    {
                        Random rand3 = new Random();
                        adjektiv adjForNow = new adjektiv();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 60);
                                adjForNow = allAdjList.SingleOrDefault(a => a.Id == randomId);
                                if (adjForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allAdjList.Remove(adjForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.AdjektivVilkenOrdklass(adjForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i obestämd form utrum
                    else if (randAdjFraga == 2)
                    {
                        Random rand3 = new Random();
                        adjektiv adjForNow = new adjektiv();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 60);
                                adjForNow = allAdjList.SingleOrDefault(a => a.Id == randomId);
                                if (adjForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allAdjList.Remove(adjForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.AdjektivObestämdUtrum(adjForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i obestämd form neutrum
                    else if (randAdjFraga == 3)
                    {
                        Random rand3 = new Random();
                        adjektiv adjForNow = new adjektiv();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 60);
                                adjForNow = allAdjList.SingleOrDefault(a => a.Id == randomId);
                                if (adjForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allAdjList.Remove(adjForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.AdjektivObestämdNeutrum(adjForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i bestämd form ej maskulinum
                    else if (randAdjFraga == 4)
                    {
                        Random rand3 = new Random();
                        adjektiv adjForNow = new adjektiv();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 60);
                                adjForNow = allAdjList.SingleOrDefault(a => a.Id == randomId);
                                if (adjForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allAdjList.Remove(adjForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.AdjektivBestämdFormEjMaskulinum(adjForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i singular
                    else if (randAdjFraga == 5)
                    {
                        Random rand3 = new Random();
                        adjektiv adjForNow = new adjektiv();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 60);
                                adjForNow = allAdjList.SingleOrDefault(a => a.Id == randomId);
                                if (adjForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allAdjList.Remove(adjForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.AdjektivSingular(adjForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i plural
                    else if (randAdjFraga == 6)
                    {
                        Random rand3 = new Random();
                        adjektiv adjForNow = new adjektiv();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 60);
                                adjForNow = allAdjList.SingleOrDefault(a => a.Id == randomId);
                                if (adjForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allAdjList.Remove(adjForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.AdjektivPlural(adjForNow);
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
                    int randVerbFraga = rand.Next(1, 6);

                    //vilken ordklass tillhör ordet
                    if (randVerbFraga == 1)
                    {
                        Random rand3 = new Random();
                        verb verForNow = new verb();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 60);
                                verForNow = allVerList.SingleOrDefault(a => a.Id == randomId);
                                if (verForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allVerList.Remove(verForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.VerbVilkenOrdklass(verForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vilken typ av verb
                    else if (randVerbFraga == 2)
                    {
                        Random rand3 = new Random();
                        verb verForNow = new verb();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 60);
                                verForNow = allVerList.SingleOrDefault(a => a.Id == randomId);
                                if (verForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allVerList.Remove(verForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.VerbVilkenTyp(verForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i infinitv
                    else if (randVerbFraga == 3)
                    {
                        Random rand3 = new Random();
                        verb verForNow = new verb();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 60);
                                verForNow = allVerList.SingleOrDefault(a => a.Id == randomId);
                                if (verForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allVerList.Remove(verForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.VerbInfinitiv(verForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i preteritum
                    else if (randVerbFraga == 4)
                    {
                        Random rand3 = new Random();
                        verb verForNow = new verb();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 60);
                                verForNow = allVerList.SingleOrDefault(a => a.Id == randomId);
                                if (verForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allVerList.Remove(verForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.VerbPreteritum(verForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet i supinum
                    else if (randVerbFraga == 5)
                    {
                        Random rand3 = new Random();
                        verb verForNow = new verb();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 60);
                                verForNow = allVerList.SingleOrDefault(a => a.Id == randomId);
                                if (verForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allVerList.Remove(verForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.VerbSupinum(verForNow);
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
                    int randAdvFraga = rand.Next(1, 3);

                    //vilken ordklass tillhör ordet
                    if (randAdvFraga == 1)
                    {
                        Random rand3 = new Random();
                        adverb advForNow = new adverb();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 50);
                                advForNow = allAdvRenLattList.SingleOrDefault(a => a.Id == randomId);
                                if (advForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allAdvRenLattList.Remove(advForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.AdverbVilkenOrdklass(advForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vilken typ av adverb
                    else if (randAdvFraga == 2)
                    {
                        Random rand3 = new Random();
                        adverb advForNow = new adverb();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 50);
                                advForNow = allAdvRenLattList.SingleOrDefault(a => a.Id == randomId);
                                if (advForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allAdvRenLattList.Remove(advForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.AdverbVilkenTyp(advForNow);
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
                    int randPreFraga = rand.Next(1, 2);

                    //vilken ordklass tillhör ordet
                    if (randPreFraga == 1)
                    {
                        Random rand3 = new Random();
                        preposition preForNow = new preposition();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 20);
                                preForNow = allPreList.SingleOrDefault(a => a.Id == randomId);
                                if (preForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allPreList.Remove(preForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.PrepositionVilkenOrdklass(preForNow);
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
                    int randKonFraga = rand.Next(1, 2);

                    //vilken ordklass tillhör ordet
                    if (randKonFraga == 1)
                    {
                        Random rand3 = new Random();
                        konjunktion konForNow = new konjunktion();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 50);
                                konForNow = allKonList.SingleOrDefault(a => a.Id == randomId);
                                if (konForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allKonList.Remove(konForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.KonjunktionVilkenOrdklass(konForNow);
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
                    int randRakFraga = rand.Next(1, 4);

                    //vilken ordklass tillhör ordet
                    if (randRakFraga == 1)
                    {
                        Random rand3 = new Random();
                        räkneord rakForNow = new räkneord();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 50);
                                rakForNow = allRakList.SingleOrDefault(a => a.Id == randomId);
                                if (rakForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allRakList.Remove(rakForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.RakneordVilkenOrdklass(rakForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet som grundtal
                    else if (randRakFraga == 2)
                    {
                        Random rand3 = new Random();
                        räkneord rakForNow = new räkneord();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 50);
                                rakForNow = allRakList.SingleOrDefault(a => a.Id == randomId);
                                if (rakForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allRakList.Remove(rakForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.RakneordGrundtal(rakForNow);
                        grammatikFraga.Nummer = fragaNummer;
                        fragaSvarList.Add(grammatikFraga);
                    }
                    //vad blir ordet som ordningstal
                    else if (randRakFraga == 3)
                    {
                        Random rand3 = new Random();
                        räkneord rakForNow = new räkneord();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 50);
                                rakForNow = allRakList.SingleOrDefault(a => a.Id == randomId);
                                if (rakForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allRakList.Remove(rakForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.RakneordOrdningstal(rakForNow);
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
                    int randIntFraga = rand.Next(1, 2);

                    //vilken ordklass tillhör ordet
                    if (randIntFraga == 1)
                    {
                        Random rand3 = new Random();
                        interjektion intjForNow = new interjektion();
                        bool isNull = true;

                        do
                        {
                            if (isNull == true)
                            {
                                int randomId = rand.Next(1, 50);
                                intjForNow = allIntList.SingleOrDefault(a => a.Id == randomId);
                                if (intjForNow == null)
                                {
                                    isNull = true;
                                }
                                else
                                {
                                    allIntList.Remove(intjForNow);
                                    isNull = false;
                                }
                            }
                        } while (isNull == true);

                        grammatikFraga = new FragaSvar();
                        grammatikFraga = gf.InterjektionVilkenOrdklass(intjForNow);
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