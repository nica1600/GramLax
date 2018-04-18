using GrammatikLaxen.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrammatikLaxen.Data
{
    interface IDbOperations
    {
        List<ordklasser> GetAllOrdklasserList();
        List<substantiv> GetAllSubstantivList();
        List<pronomen> GetAllPronomenList();
    }
}