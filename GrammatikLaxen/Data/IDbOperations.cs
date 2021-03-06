﻿using GrammatikLaxen.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrammatikLaxen.Data
{
    interface IDbOperations
    {
        List<toppresultat> GetTop10List();
        List<ordklasser> GetAllOrdklasserList();
        List<substantiv> GetAllSubstantivList();
        substantiv GetRandomSubstantiv();
        List<pronomen> GetAllPronomenList();
        List<pronomen> GetAllPronomenMedelsvaraList();
        pronomen GetRandomPronomen();
        List<adjektiv> GetAllAdjektivList();
        adjektiv GetRandomAdjektiv();
        List<verb> GetAllVerbList();
        verb GetRandomVerb();
        List<adverb> GetAllAdverbList();
        List<adverb> GetAllAdverbRenLattList();
        List<adverb> GetAllAdverbMedelsvaraList();
        adverb GetRandomAdverbRen();
        adverb GetRandomAdverbRenLatt();
        List<preposition> GetAllPrepositionList();
        preposition GetRandomPreposition();
        List<konjunktion> GetAllKonjunktionList();
        konjunktion GetRandomKonjunktion();
        List<räkneord> GetAllRäkneordList();
        räkneord GetRandomRakneord();
        List<interjektion> GetAllInterjektionList();
        interjektion GetRandomInterjektion();
    }
}