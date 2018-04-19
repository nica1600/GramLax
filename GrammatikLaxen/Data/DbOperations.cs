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
        
        // Hämta alla ordklasser från databasen
        public List<ordklasser> GetAllOrdklasserList()
        {
            var ordklasserList = db.ordklasser;
            return ordklasserList.ToList();
        }

        // Hämta alla substantiv från databasen
        public List<substantiv> GetAllSubstantivList()
        {
            var substantivList = db.substantiv;
            return substantivList.ToList();
        }

        // Hämta alla pronomen från databasen
        public List<pronomen> GetAllPronomenList()
        {
            var pronomenList = db.pronomen;
            return pronomenList.ToList();
        }

        // Hämta alla adjektiv från databasen
        public List<adjektiv> GetAllAdjektivList()
        {
            var adjektivList = db.adjektiv;
            return adjektivList.ToList();
        }

        // Hämta alla verb från databasen
        public List<verb> GetAllVerbList()
        {
            var verbList = db.verb;
            return verbList.ToList();
        }

        // Hämta alla adverb från databasen
        public List<adverb> GetAllAdverbList()
        {
            var adverbList = db.adverb;
            return adverbList.ToList();
        }

        // Hämta alla prepositioner från databasen
        public List<preposition> GetAllPrepositionList()
        {
            var prepositionList = db.preposition;
            return prepositionList.ToList();
        }
    }
}