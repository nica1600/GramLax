using GrammatikLaxen.Models;
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
        FragaSvar fragaSvar;

        // SUBSTANTIV - LÄTTA FRÅGOR

        // vilken ordklass tillhör ordet
        public FragaSvar SubstantivVilkenOrdklass()
        {
            var randomSubstantiv = db.GetRandomSubstantiv();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + randomSubstantiv.ord + "'?";
            fragaSvar.Svar1 = randomSubstantiv.ordklass;
            fragaSvar.Svar2 = randomSubstantiv.även;
            fragaSvar.Svar3 = randomSubstantiv.även;
            fragaSvar.Svar4 = randomSubstantiv.även;
            fragaSvar.Svar5 = randomSubstantiv.även;
            fragaSvar.Svar6 = randomSubstantiv.även;
            fragaSvar.Svar7 = randomSubstantiv.även;
            fragaSvar.Svar8 = randomSubstantiv.även;

            return fragaSvar;
        }

        // konkret eller bastrakt
        public FragaSvar SubstantivKonkretAbstrakt()
        {
            var randomSubstantiv = db.GetRandomSubstantiv();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Är ordet '" + randomSubstantiv.ord + "' ett konkret eller abstrakt substantiv?";
            fragaSvar.Svar1 = randomSubstantiv.betydelse;
            fragaSvar.Svar2 = randomSubstantiv.betydelse;
            fragaSvar.Svar3 = randomSubstantiv.betydelse;
            fragaSvar.Svar4 = randomSubstantiv.betydelse;
            fragaSvar.Svar5 = randomSubstantiv.betydelse;
            fragaSvar.Svar6 = randomSubstantiv.betydelse;
            fragaSvar.Svar7 = randomSubstantiv.betydelse;
            fragaSvar.Svar8 = randomSubstantiv.betydelse;

            return fragaSvar;
        }
    }
}