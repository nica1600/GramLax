﻿using GrammatikLaxen.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrammatikLaxen.Data
{
    public class DbOperations : IDbOperations
    {
        private gramLaDatEntities2 db = new gramLaDatEntities2();
        
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
                    int randomId = rand.Next(1, 150);
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
                    int randomId = rand.Next(1, 20);
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
                    int randomId = rand.Next(1, 50);
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
                    int randomId = rand.Next(1, 40);
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
                    int randomId = rand.Next(1, 50);
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
                    int randomId = rand.Next(1, 50);
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

        // Hämta alla prepositioner från databasen
        public List<preposition> GetAllPrepositionList()
        {
            var prepositionList = db.preposition;
            return prepositionList.ToList();
        }

        // Hämta alla konjunktioner från databasen
        public List<konjunktion> GetAllKonjunktionList()
        {
            var konjunktionList = db.konjunktion;
            return konjunktionList.ToList();
        }

        // Hämta alla räkneord från databasen
        public List<räkneord> GetAllRäkneordList()
        {
            var räkneordList = db.räkneord;
            return räkneordList.ToList();
        }

        // Hämta alla interjektioner från databasen
        public List<interjektion> GetAllInterjektionList()
        {
            var interjektionList = db.interjektion;
            return interjektionList.ToList();
        }
    }
}