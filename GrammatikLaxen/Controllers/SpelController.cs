using GrammatikLaxen.Data;
using GrammatikLaxen.Models;
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
        GrammatikFragor gf = new GrammatikFragor();

        //Index-sida, info och väljer spel-nivå
        public ActionResult Index()
        {
            return View();
        }

        //ÖVNING BAS

        //ÖVNING LÄTT

        //ÖVNING MEDEL

        //ÖVNING SVÅRT
        public ActionResult Niva3Spel()
        {
            return View();
        }
        public ActionResult Niva3LaddaSpelet()
        {
            List<FragaSvar> fragaSvarList = new List<FragaSvar>();
            fragaSvarList.Clear();

            List<substantiv> allSubList = db.GetAllSubstantivList();
            List<pronomen> allProList = db.GetAllPronomenList();
            List<pronomen> allProMedelsvaraList = db.GetAllPronomenMedelsvaraList();
            List<adjektiv> allAdjList = db.GetAllAdjektivList();
            List<verb> allVerList = db.GetAllVerbList();
            List<verb> allVerSvaraList = db.GetAllVerbSvarList();
            List<adverb> allAdvRenLattList = db.GetAllAdverbRenLattList();
            List<adverb> allAdvMedelsvaraList = db.GetAllAdverbMedelsvaraList();
            List<preposition> allPreList = db.GetAllPrepositionList();
            List<konjunktion> allKonList = db.GetAllKonjunktionList();
            List<räkneord> allRakList = db.GetAllRäkneordList();
            List<interjektion> allIntList = db.GetAllInterjektionList();

            FragaSvar grammatikFraga = new FragaSvar();
            int fragaNummer = 0;
            Random rand = new Random();
            int randSvarighetsgrad = rand.Next(1, 4);

            // SLUMPA FRAM FRÅGA TILL SPELET (kopierat från prov-delen men ändrat till att listan består av 1 fråga, om frågor uppdateras så räcker det med ändringar i provdelen och kopiera sedan in for-loparna här med 1 varv istället)
            if (randSvarighetsgrad == 1)
            {
                // TAR FRAM 1 SLUMPVISA LÄTTA FRÅGOR
                for (int i = 0; i < 1; i++)
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
            }
            else if (randSvarighetsgrad == 2)
            {
                // TAR FRAM 1 MEDELSVÅRA FRÅGOR
                for (int i = 0; i < 1; i++)
                {
                    int randOrdklass = rand.Next(1, 7); //sätt alltid till 7 efter tester!
                    fragaNummer++;

                    // substantiv
                    if (randOrdklass == 1)
                    {
                        int randSubFraga = rand.Next(1, 4);

                        //vilket genus
                        if (randSubFraga == 1)
                        {
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
                            grammatikFraga = gf.SubstantivGenus(subForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //nominativ
                        else if (randSubFraga == 2)
                        {
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
                            grammatikFraga = gf.SubstantivNominativ(subForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //genitiv
                        else if (randSubFraga == 3)
                        {
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
                            grammatikFraga = gf.SubstantivGenitiv(subForNow);
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
                        int randProFraga = rand.Next(1, 9);

                        //reflexiva possessiva utrum
                        if (randProFraga == 1)
                        {
                            pronomen proForNow = new pronomen();
                            bool isNull = true;

                            do
                            {
                                if (isNull == true)
                                {
                                    int randomId = rand.Next(1, 30);
                                    proForNow = allProMedelsvaraList.SingleOrDefault(a => a.Id == randomId);
                                    if (proForNow == null)
                                    {
                                        isNull = true;
                                    }
                                    else
                                    {
                                        allProMedelsvaraList.Remove(proForNow);
                                        isNull = false;
                                    }
                                }
                            } while (isNull == true);

                            grammatikFraga = new FragaSvar();
                            grammatikFraga = gf.PronomenReflexivaPossessivaUtrum(proForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //reflexiva possessiva neutrum
                        else if (randProFraga == 2)
                        {
                            pronomen proForNow = new pronomen();
                            bool isNull = true;

                            do
                            {
                                if (isNull == true)
                                {
                                    int randomId = rand.Next(1, 30);
                                    proForNow = allProMedelsvaraList.SingleOrDefault(a => a.Id == randomId);
                                    if (proForNow == null)
                                    {
                                        isNull = true;
                                    }
                                    else
                                    {
                                        allProMedelsvaraList.Remove(proForNow);
                                        isNull = false;
                                    }
                                }
                            } while (isNull == true);

                            grammatikFraga = new FragaSvar();
                            grammatikFraga = gf.PronomenReflexivaPossessivaNeutrum(proForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //reflexiva possessiva plural
                        else if (randProFraga == 3)
                        {
                            pronomen proForNow = new pronomen();
                            bool isNull = true;

                            do
                            {
                                if (isNull == true)
                                {
                                    int randomId = rand.Next(1, 30);
                                    proForNow = allProMedelsvaraList.SingleOrDefault(a => a.Id == randomId);
                                    if (proForNow == null)
                                    {
                                        isNull = true;
                                    }
                                    else
                                    {
                                        allProMedelsvaraList.Remove(proForNow);
                                        isNull = false;
                                    }
                                }
                            } while (isNull == true);

                            grammatikFraga = new FragaSvar();
                            grammatikFraga = gf.PronomenReflexivaPossessivaPlural(proForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //relativa grundform
                        else if (randProFraga == 4)
                        {
                            pronomen proForNow = new pronomen();
                            bool isNull = true;

                            do
                            {
                                if (isNull == true)
                                {
                                    int randomId = rand.Next(1, 30);
                                    proForNow = allProMedelsvaraList.SingleOrDefault(a => a.Id == randomId);
                                    if (proForNow == null)
                                    {
                                        isNull = true;
                                    }
                                    else
                                    {
                                        allProMedelsvaraList.Remove(proForNow);
                                        isNull = false;
                                    }
                                }
                            } while (isNull == true);

                            grammatikFraga = new FragaSvar();
                            grammatikFraga = gf.PronomenRelativaGrundform(proForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //relativa genitiv
                        else if (randProFraga == 5)
                        {
                            pronomen proForNow = new pronomen();
                            bool isNull = true;

                            do
                            {
                                if (isNull == true)
                                {
                                    int randomId = rand.Next(1, 30);
                                    proForNow = allProMedelsvaraList.SingleOrDefault(a => a.Id == randomId);
                                    if (proForNow == null)
                                    {
                                        isNull = true;
                                    }
                                    else
                                    {
                                        allProMedelsvaraList.Remove(proForNow);
                                        isNull = false;
                                    }
                                }
                            } while (isNull == true);

                            grammatikFraga = new FragaSvar();
                            grammatikFraga = gf.PronomenRelativaGenitiv(proForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //interrogativa
                        else if (randProFraga == 6)
                        {
                            pronomen proForNow = new pronomen();
                            bool isNull = true;

                            do
                            {
                                if (isNull == true)
                                {
                                    int randomId = rand.Next(1, 30);
                                    proForNow = allProMedelsvaraList.SingleOrDefault(a => a.Id == randomId);
                                    if (proForNow == null)
                                    {
                                        isNull = true;
                                    }
                                    else
                                    {
                                        allProMedelsvaraList.Remove(proForNow);
                                        isNull = false;
                                    }
                                }
                            } while (isNull == true);

                            grammatikFraga = new FragaSvar();
                            grammatikFraga = gf.PronomenInterrogativa(proForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //demonstrativa nära
                        else if (randProFraga == 7)
                        {
                            pronomen proForNow = new pronomen();
                            bool isNull = true;

                            do
                            {
                                if (isNull == true)
                                {
                                    int randomId = rand.Next(1, 30);
                                    proForNow = allProMedelsvaraList.SingleOrDefault(a => a.Id == randomId);
                                    if (proForNow == null)
                                    {
                                        isNull = true;
                                    }
                                    else
                                    {
                                        allProMedelsvaraList.Remove(proForNow);
                                        isNull = false;
                                    }
                                }
                            } while (isNull == true);

                            grammatikFraga = new FragaSvar();
                            grammatikFraga = gf.PronomenDemonstrativaNara(proForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //demonstrativa långt bort
                        else if (randProFraga == 8)
                        {
                            pronomen proForNow = new pronomen();
                            bool isNull = true;

                            do
                            {
                                if (isNull == true)
                                {
                                    int randomId = rand.Next(1, 30);
                                    proForNow = allProMedelsvaraList.SingleOrDefault(a => a.Id == randomId);
                                    if (proForNow == null)
                                    {
                                        isNull = true;
                                    }
                                    else
                                    {
                                        allProMedelsvaraList.Remove(proForNow);
                                        isNull = false;
                                    }
                                }
                            } while (isNull == true);

                            grammatikFraga = new FragaSvar();
                            grammatikFraga = gf.PronomenDemonstrativaLangtBort(proForNow);
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
                        int randAdjFraga = rand.Next(1, 4);

                        //komparation positiv
                        if (randAdjFraga == 1)
                        {
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
                            grammatikFraga = gf.AdjektivPositiv(adjForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //komparation komparativ
                        else if (randAdjFraga == 2)
                        {
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
                            grammatikFraga = gf.AdjektivKomparativ(adjForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //komparation superlativ predikativt
                        else if (randAdjFraga == 3)
                        {
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
                            grammatikFraga = gf.AdjektivSuperlativPredikativ(adjForNow);
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
                        int randVerbFraga = rand.Next(1, 6);

                        //presens
                        if (randVerbFraga == 1)
                        {
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
                            grammatikFraga = gf.VerbPresens(verForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //perfekt
                        else if (randVerbFraga == 2)
                        {
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
                            grammatikFraga = gf.VerbPerfekt(verForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //pluskvamperfekt
                        else if (randVerbFraga == 3)
                        {
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
                            grammatikFraga = gf.VerbPluskvamperfekt(verForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //futurum
                        else if (randVerbFraga == 4)
                        {
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
                            grammatikFraga = gf.VerbFuturum(verForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //imperativ
                        else if (randVerbFraga == 5)
                        {
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
                            grammatikFraga = gf.VerbImperativ(verForNow);
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
                        int randAdvFraga = rand.Next(1, 2);

                        //vilken typ av adverb
                        if (randAdvFraga == 1)
                        {
                            adverb advForNow = new adverb();
                            bool isNull = true;

                            do
                            {
                                if (isNull == true)
                                {
                                    int randomId = rand.Next(1, 50);
                                    advForNow = allAdvMedelsvaraList.SingleOrDefault(a => a.Id == randomId);
                                    if (advForNow == null)
                                    {
                                        isNull = true;
                                    }
                                    else
                                    {
                                        allAdvMedelsvaraList.Remove(advForNow);
                                        isNull = false;
                                    }
                                }
                            } while (isNull == true);

                            grammatikFraga = new FragaSvar();
                            grammatikFraga = gf.AdverbVilkenTypMedelsvar(advForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        else
                        {
                            //något felmeddelande
                        }
                    }
                    //konjunktion
                    else if (randOrdklass == 6)
                    {
                        int randKonFraga = rand.Next(1, 2);

                        //subjunktion
                        if (randKonFraga == 1)
                        {
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
                            grammatikFraga = gf.KonjunktionSubjunktion(konForNow);
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
            }
            else if (randSvarighetsgrad == 3)
            {
                // TAR FRAM 1 SVÅRA FRÅGOR
                for (int i = 0; i < 1; i++)
                {
                    int randOrdklass = rand.Next(1, 4); //sätt alltid till 4 efter tester!
                    fragaNummer++;

                    // substantiv
                    if (randOrdklass == 1)
                    {
                        int randSubFraga = rand.Next(1, 7);

                        //obestämd form singular
                        if (randSubFraga == 1)
                        {
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
                            grammatikFraga = gf.SubstantivObestamdSingular(subForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //bestämd form singular
                        else if (randSubFraga == 2)
                        {
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
                            grammatikFraga = gf.SubstantivBestamdSingular(subForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //obestämd form plural
                        else if (randSubFraga == 3)
                        {
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
                            grammatikFraga = gf.SubstantivObestamdPlural(subForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //bestämd form plural
                        else if (randSubFraga == 4)
                        {
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
                            grammatikFraga = gf.SubstantivBestamdPlural(subForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //bestämd fristående artikel singular
                        else if (randSubFraga == 5)
                        {
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
                            grammatikFraga = gf.SubstantivBestamdFristaendeArtikelSingular(subForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //bestämd fristående artikel plural
                        else if (randSubFraga == 6)
                        {
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
                            grammatikFraga = gf.SubstantivBestamdFristaendeArtikelPlural(subForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        else
                        {
                            //något felmeddelande
                        }

                    }
                    //adjektiv
                    else if (randOrdklass == 2)
                    {
                        int randAdjFraga = rand.Next(1, 2);

                        //komparation superlativ attributiv ej maskulinum
                        if (randAdjFraga == 1)
                        {
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
                            grammatikFraga = gf.AdjektivSuperlativAttributivEjMaskulinum(adjForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        else
                        {
                            //något felmeddelande
                        }
                    }
                    //verb
                    else if (randOrdklass == 3)
                    {
                        int randVerbFraga = rand.Next(1, 3);

                        //presens particip
                        if (randVerbFraga == 1)
                        {
                            verb verForNow = new verb();
                            bool isNull = true;

                            do
                            {
                                if (isNull == true)
                                {
                                    int randomId = rand.Next(1, 60);
                                    verForNow = allVerSvaraList.SingleOrDefault(a => a.Id == randomId);
                                    if (verForNow == null)
                                    {
                                        isNull = true;
                                    }
                                    else
                                    {
                                        allVerSvaraList.Remove(verForNow);
                                        isNull = false;
                                    }
                                }
                            } while (isNull == true);

                            grammatikFraga = new FragaSvar();
                            grammatikFraga = gf.VerbPresensParticip(verForNow);
                            grammatikFraga.Nummer = fragaNummer;
                            fragaSvarList.Add(grammatikFraga);
                        }
                        //perfekt particip
                        else if (randVerbFraga == 2)
                        {
                            verb verForNow = new verb();
                            bool isNull = true;

                            do
                            {
                                if (isNull == true)
                                {
                                    int randomId = rand.Next(1, 60);
                                    verForNow = allVerSvaraList.SingleOrDefault(a => a.Id == randomId);
                                    if (verForNow == null)
                                    {
                                        isNull = true;
                                    }
                                    else
                                    {
                                        allVerSvaraList.Remove(verForNow);
                                        isNull = false;
                                    }
                                }
                            } while (isNull == true);

                            grammatikFraga = new FragaSvar();
                            grammatikFraga = gf.VerbPerfektParticip(verForNow);
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
            }

            return PartialView("_Niva3Spel", grammatikFraga);
        }

        
    }
}