using GrammatikLaxen.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrammatikLaxen.Data
{
    public class DbOperations : IDbOperations
    {
        private gramLaDatEntities2 db = new gramLaDatEntities2();
        Random randX = new Random();

        // Hämta alla ordklasser från databasen
        public List<ordklasser> GetAllOrdklasserList()
        {
            var ordklasserList = db.ordklasser;
            return ordklasserList.ToList();
        }

        // SUBSTANTIV

        // Hämta alla substantiv från databasen
        public List<substantiv> GetAllSubstantivList()
        {
            var substantivList = db.substantiv;
            return substantivList.ToList();
        }

        // Hämta slumpmässigt substantiv
        public substantiv GetRandomSubstantiv()
        {
            //Random rand = new Random();
            //int randomId = rand.Next(1, 96);
            //var substantiv = db.substantiv.SingleOrDefault(a => a.Id == randomId);
            //return substantiv;
            Random rand = new Random();
            substantiv subForNow = new substantiv();
            var substantiv = subForNow;
            bool isNull = true;

            do
            {
                if (isNull == true)
                {
                    int randomId = randX.Next(1, 150);
                    substantiv = db.substantiv.SingleOrDefault(a => a.Id == randomId);
                    if (substantiv == null)
                    {
                        isNull = true;
                    }
                    else
                    {
                        isNull = false;
                    }
                }
            } while (isNull == true);
            return substantiv;
        }

        // PRONOMEN

        // Hämta alla pronomen från databasen
        public List<pronomen> GetAllPronomenList()
        {
            var pronomenList = db.pronomen;
            return pronomenList.ToList();
        }

        // Hämta alla medelsvåra pronomen (reflexiva possessiva, demonstrativa1, demonstrativa2) från databasen
        public List<pronomen> GetAllPronomenMedelsvaraList()
        {
            var pronomenList = db.pronomen.Where(p => p.reflexiva_possessiva == true && p.demonstrativa == true && p.demonstrativa_2 == true);
            return pronomenList.ToList();
        }

        // Hämta slumpmässigt pronomen
        public pronomen GetRandomPronomen()
        {
            Random rand = new Random();
            pronomen proForNow = new pronomen();
            var pronomen = proForNow;
            bool isNull = true;

            do
            {
                if (isNull == true)
                {
                    int randomId = randX.Next(1, 20);
                    pronomen = db.pronomen.SingleOrDefault(a => a.Id == randomId);
                    if (pronomen == null)
                    {
                        isNull = true;
                    }
                    else
                    {
                        isNull = false;
                    }
                }
            } while (isNull == true);
            return pronomen;
        }

        // ADJEKTIV

        // Hämta alla adjektiv från databasen
        public List<adjektiv> GetAllAdjektivList()
        {
            var adjektivList = db.adjektiv;
            return adjektivList.ToList();
        }

        // Hämta slumpmässigt adjektiv
        public adjektiv GetRandomAdjektiv()
        {
            Random rand = new Random();
            adjektiv adForNow = new adjektiv();
            var adjektiv = adForNow;
            bool isNull = true;

            do
            {
                if (isNull == true)
                {
                    int randomId = randX.Next(1, 50);
                    adjektiv = db.adjektiv.SingleOrDefault(a => a.Id == randomId);
                    if (adjektiv == null)
                    {
                        isNull = true;
                    }
                    else
                    {
                        isNull = false;
                    }
                }
            } while (isNull == true);
            return adjektiv;
        }

        // VERB

        // Hämta alla verb från databasen
        public List<verb> GetAllVerbList()
        {
            var verbList = db.verb;
            return verbList.ToList();
        }

        // Hämta alla svåra verb från databasen
        public List<verb> GetAllVerbSvarList()
        {
            var verbList = db.verb.Where(a => a.particip == true);
            return verbList.ToList();
        }

        // Hämta slumpmässigt verb
        public verb GetRandomVerb()
        {
            Random rand = new Random();
            verb veForNow = new verb();
            var verb = veForNow;
            bool isNull = true;

            do
            {
                if (isNull == true)
                {
                    int randomId = randX.Next(1, 40);
                    verb = db.verb.SingleOrDefault(a => a.Id == randomId);
                    if (verb == null)
                    {
                        isNull = true;
                    }
                    else
                    {
                        isNull = false;
                    }
                }
            } while (isNull == true);
            return verb;
        }

        // ADVERB

        // Hämta alla adverb från databasen
        public List<adverb> GetAllAdverbList()
        {
            var adverbList = db.adverb;
            return adverbList.ToList();
        }

        // Hämta alla rena och lätta adverb från databasen
        public List<adverb> GetAllAdverbRenLattList()
        {
            var adverbList = db.adverb.Where(b => b.ren == true && b.gradadverb == false && b.orsaksadverb == false && b.satsadverb == false);
            return adverbList.ToList();
        }

        // Hämta alla medelsvåra adverb från databasen
        public List<adverb> GetAllAdverbMedelsvaraList()
        {
            var adverbList = db.adverb.Where(a => a.gradadverb == true || a.orsaksadverb == true || a.relativa_adverb == true || a.satsadverb == true);
            return adverbList.ToList();
        }

        // Hämta slumpmässigt adverb (ren)
        public adverb GetRandomAdverbRen()
        {
            Random rand = new Random();
            adverb adForNow = new adverb();
            var adverb = adForNow;
            bool isNull = true;

            do
            {
                if (isNull == true)
                {
                    int randomId = randX.Next(1, 50);
                    adverb = db.adverb.Where(b => b.ren == true).SingleOrDefault(a => a.Id == randomId);
                    if (adverb == null)
                    {
                        isNull = true;
                    }
                    else
                    {
                        isNull = false;
                    }
                }
            } while (isNull == true);
            return adverb;
        }

        // Hämta slumpmässigt adverb (ren, lätt)
        public adverb GetRandomAdverbRenLatt()
        {
            Random rand = new Random();
            adverb adForNow = new adverb();
            var adverb = adForNow;
            bool isNull = true;

            do
            {
                if (isNull == true)
                {
                    int randomId = randX.Next(1, 50);
                    adverb = db.adverb.Where(b => b.ren == true && b.gradadverb == false && b.orsaksadverb == false && b.satsadverb == false).SingleOrDefault(a => a.Id == randomId);
                    if (adverb == null)
                    {
                        isNull = true;
                    }
                    else
                    {
                        isNull = false;
                    }
                }
            } while (isNull == true);
            return adverb;
        }

        // PREPOSITIONER

        // Hämta alla prepositioner från databasen
        public List<preposition> GetAllPrepositionList()
        {
            var prepositionList = db.preposition;
            return prepositionList.ToList();
        }

        // Hämta slumpmässig preposition
        public preposition GetRandomPreposition()
        {
            Random rand = new Random();
            preposition preForNow = new preposition();
            var preposition = preForNow;
            bool isNull = true;

            do
            {
                if (isNull == true)
                {
                    int randomId = randX.Next(1, 25);
                    preposition = db.preposition.SingleOrDefault(a => a.Id == randomId);
                    if (preposition == null)
                    {
                        isNull = true;
                    }
                    else
                    {
                        isNull = false;
                    }
                }
            } while (isNull == true);
            return preposition;
        }

        // KONJUNKTION

        // Hämta alla konjunktioner från databasen
        public List<konjunktion> GetAllKonjunktionList()
        {
            var konjunktionList = db.konjunktion;
            return konjunktionList.ToList();
        }
        
        // Hämta slumpmässig konjunktion
        public konjunktion GetRandomKonjunktion()
        {
            Random rand = new Random();
            konjunktion konForNow = new konjunktion();
            var konjunktion = konForNow;
            bool isNull = true;

            do
            {
                if (isNull == true)
                {
                    int randomId = randX.Next(1, 20);
                    konjunktion = db.konjunktion.SingleOrDefault(a => a.Id == randomId);
                    if (konjunktion == null)
                    {
                        isNull = true;
                    }
                    else
                    {
                        isNull = false;
                    }
                }
            } while (isNull == true);
            return konjunktion;
        }

        // RÄKNEORD

        // Hämta alla räkneord från databasen
        public List<räkneord> GetAllRäkneordList()
        {
            var räkneordList = db.räkneord;
            return räkneordList.ToList();
        }

        // Hämta slumpmässigt räkneord
        public räkneord GetRandomRakneord()
        {
            Random rand = new Random();
            räkneord rakForNow = new räkneord();
            var rakneord = rakForNow;
            bool isNull = true;

            do
            {
                if (isNull == true)
                {
                    int randomId = randX.Next(1, 40);
                    rakneord = db.räkneord.SingleOrDefault(a => a.Id == randomId);
                    if (rakneord == null)
                    {
                        isNull = true;
                    }
                    else
                    {
                        isNull = false;
                    }
                }
            } while (isNull == true);
            return rakneord;
        }

        // INTERJEKTION

        // Hämta alla interjektioner från databasen
        public List<interjektion> GetAllInterjektionList()
        {
            var interjektionList = db.interjektion;
            return interjektionList.ToList();
        }

        // Hämta slumpmässig interjektion
        public interjektion GetRandomInterjektion()
        {
            Random rand = new Random();
            interjektion intForNow = new interjektion();
            var interjektion = intForNow;
            bool isNull = true;

            do
            {
                if (isNull == true)
                {
                    int randomId = randX.Next(1, 30);
                    interjektion = db.interjektion.SingleOrDefault(a => a.Id == randomId);
                    if (interjektion == null)
                    {
                        isNull = true;
                    }
                    else
                    {
                        isNull = false;
                    }
                }
            } while (isNull == true);
            return interjektion;
        }
    }
}