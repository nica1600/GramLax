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
        List<adjektiv> GetAllAdjektivList();
        List<verb> GetAllVerbList();
        List<adverb> GetAllAdverbList();
        List<preposition> GetAllPrepositionList();
        List<konjunktion> GetAllKonjunktionList();
        List<räkneord> GetAllRäkneordList();
        List<interjektion> GetAllInterjektionList();
    }
}