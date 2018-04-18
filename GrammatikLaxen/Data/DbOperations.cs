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
    }
}