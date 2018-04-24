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
        substantiv GetRandomSubstantiv();
        List<pronomen> GetAllPronomenList();
        pronomen GetRandomPronomen();
        List<adjektiv> GetAllAdjektivList();
        adjektiv GetRandomAdjektiv();
        List<verb> GetAllVerbList();
        verb GetRandomVerb();
        List<adverb> GetAllAdverbList();
        adverb GetRandomAdverbRen();
        adverb GetRandomAdverbRenLatt();
        List<preposition> GetAllPrepositionList();
        List<konjunktion> GetAllKonjunktionList();
        List<räkneord> GetAllRäkneordList();
        List<interjektion> GetAllInterjektionList();
    }
}