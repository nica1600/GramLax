using GrammatikLaxen.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrammatikLaxen.Data
{
    public class GrammatikFragor
    {
        DbOperations db = new DbOperations();

        public substantiv VilketOrdSubstantiv()
        {
            var allaOrd = db.GetAllSubstantivList();
            int count = 0;
            substantiv sub = new substantiv();
            foreach(var substantiv in allaOrd)
            {
                count++;
                if (count == 1)
                {
                    sub = substantiv;
                }
            }

            return sub;
        }
    }
}