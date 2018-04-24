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

        // 1 vilken ordklass tillhör ordet, substantiv
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

        // 2 konkret eller bastrakt, substantiv
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

        // PRONOMEN - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, pronomen
        public FragaSvar PronomenVilkenOrdklass()
        {
            var randomPronomen = db.GetRandomPronomen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + randomPronomen.ord + "'?";
            fragaSvar.Svar1 = randomPronomen.ordklass;
            fragaSvar.Svar2 = randomPronomen.även;
            fragaSvar.Svar3 = randomPronomen.även;
            fragaSvar.Svar4 = randomPronomen.även;
            fragaSvar.Svar5 = randomPronomen.även;
            fragaSvar.Svar6 = randomPronomen.även;
            fragaSvar.Svar7 = randomPronomen.även;
            fragaSvar.Svar8 = randomPronomen.även;

            return fragaSvar;
        }

        // 2 gör om till personliga pronomen subjektform, pronomen
        public FragaSvar PronomenPersonligaSubjekt()
        {
            var randomPronomen = db.GetRandomPronomen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Hur gör du om ordet '" + randomPronomen.personliga_objekt + "' (som är personliga pronomen i objektform) till personliga pronomen i subjektform?";
            fragaSvar.Svar1 = randomPronomen.personliga_subjekt;
            fragaSvar.Svar2 = randomPronomen.personliga_subjekt;
            fragaSvar.Svar3 = randomPronomen.personliga_subjekt;
            fragaSvar.Svar4 = randomPronomen.personliga_subjekt;
            fragaSvar.Svar5 = randomPronomen.personliga_subjekt;
            fragaSvar.Svar6 = randomPronomen.personliga_subjekt;
            fragaSvar.Svar7 = randomPronomen.personliga_subjekt;
            fragaSvar.Svar8 = randomPronomen.personliga_subjekt;

            return fragaSvar;
        }

        // 3 gör om till personliga pronomen objektform, pronomen
        public FragaSvar PronomenPersonligaObjekt()
        {
            var randomPronomen = db.GetRandomPronomen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Hur gör du om ordet '" + randomPronomen.personliga_subjekt + "' (som är personliga pronomen i subjektform) till personliga pronomen i objektform?";
            fragaSvar.Svar1 = randomPronomen.personliga_objekt;
            fragaSvar.Svar2 = randomPronomen.personliga_objekt;
            fragaSvar.Svar3 = randomPronomen.personliga_objekt;
            fragaSvar.Svar4 = randomPronomen.personliga_objekt;
            fragaSvar.Svar5 = randomPronomen.personliga_objekt;
            fragaSvar.Svar6 = randomPronomen.personliga_objekt;
            fragaSvar.Svar7 = randomPronomen.personliga_objekt;
            fragaSvar.Svar8 = randomPronomen.personliga_objekt;

            return fragaSvar;
        }

        // 4 gör om till possessivt utrum, pronomen
        public FragaSvar PronomenPossessivaUtrum()
        {
            var randomPronomen = db.GetRandomPronomen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + randomPronomen.ord + "' som possessivt pronomen om det står tillsammans med ett utrum-substantiv (en ...)?";
            fragaSvar.Svar1 = randomPronomen.possessiva_utrum;
            fragaSvar.Svar2 = randomPronomen.possessiva_utrum;
            fragaSvar.Svar3 = randomPronomen.possessiva_utrum;
            fragaSvar.Svar4 = randomPronomen.possessiva_utrum;
            fragaSvar.Svar5 = randomPronomen.possessiva_utrum;
            fragaSvar.Svar6 = randomPronomen.possessiva_utrum;
            fragaSvar.Svar7 = randomPronomen.possessiva_utrum;
            fragaSvar.Svar8 = randomPronomen.possessiva_utrum;

            return fragaSvar;
        }

        // 5 gör om till possessivt neutrum, pronomen
        public FragaSvar PronomenPossessivaNeutrum()
        {
            var randomPronomen = db.GetRandomPronomen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + randomPronomen.ord + "' som possessivt pronomen om det står tillsammans med ett neutrum-substantiv (ett ...)?";
            fragaSvar.Svar1 = randomPronomen.possessiva_neutrum;
            fragaSvar.Svar2 = randomPronomen.possessiva_neutrum;
            fragaSvar.Svar3 = randomPronomen.possessiva_neutrum;
            fragaSvar.Svar4 = randomPronomen.possessiva_neutrum;
            fragaSvar.Svar5 = randomPronomen.possessiva_neutrum;
            fragaSvar.Svar6 = randomPronomen.possessiva_neutrum;
            fragaSvar.Svar7 = randomPronomen.possessiva_neutrum;
            fragaSvar.Svar8 = randomPronomen.possessiva_neutrum;

            return fragaSvar;
        }

        // 6 gör om till possessivt plural, pronomen
        public FragaSvar PronomenPossessivaPlural()
        {
            var randomPronomen = db.GetRandomPronomen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + randomPronomen.ord + "' som possessivt pronomen om det står tillsammans med ett substantiv i plural (flera)?";
            fragaSvar.Svar1 = randomPronomen.possessiva_plural;
            fragaSvar.Svar2 = randomPronomen.possessiva_plural;
            fragaSvar.Svar3 = randomPronomen.possessiva_plural;
            fragaSvar.Svar4 = randomPronomen.possessiva_plural;
            fragaSvar.Svar5 = randomPronomen.possessiva_plural;
            fragaSvar.Svar6 = randomPronomen.possessiva_plural;
            fragaSvar.Svar7 = randomPronomen.possessiva_plural;
            fragaSvar.Svar8 = randomPronomen.possessiva_plural;

            return fragaSvar;
        }

        // 7 gör om till reflexivt, pronomen
        public FragaSvar PronomenReflexiva()
        {
            var randomPronomen = db.GetRandomPronomen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + randomPronomen.ord + "' som reflexivt pronomen?";
            fragaSvar.Svar1 = randomPronomen.reflexiva;
            fragaSvar.Svar2 = randomPronomen.reflexiva;
            fragaSvar.Svar3 = randomPronomen.reflexiva;
            fragaSvar.Svar4 = randomPronomen.reflexiva;
            fragaSvar.Svar5 = randomPronomen.reflexiva;
            fragaSvar.Svar6 = randomPronomen.reflexiva;
            fragaSvar.Svar7 = randomPronomen.reflexiva;
            fragaSvar.Svar8 = randomPronomen.reflexiva;

            return fragaSvar;
        }

        // Adjektiv - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, adjektiv
        public FragaSvar AdjektivVilkenOrdklass()
        {
            var randomAdjektiv = db.GetRandomAdjektiv();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + randomAdjektiv.ord + "'?";
            fragaSvar.Svar1 = randomAdjektiv.ordklass;
            fragaSvar.Svar2 = randomAdjektiv.även;
            fragaSvar.Svar3 = randomAdjektiv.även;
            fragaSvar.Svar4 = randomAdjektiv.även;
            fragaSvar.Svar5 = randomAdjektiv.även;
            fragaSvar.Svar6 = randomAdjektiv.även;
            fragaSvar.Svar7 = randomAdjektiv.även;
            fragaSvar.Svar8 = randomAdjektiv.även;

            return fragaSvar;
        }

        // 2 vad blir ordet i obestämd form utrum, adjektiv
        public FragaSvar AdjektivObestämdUtrum()
        {
            var randomAdjektiv = db.GetRandomAdjektiv();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir adjektivitet '" + randomAdjektiv.ord + "' i obestämd form tillsammans med ett utrum-substantiv (en ...)?";
            fragaSvar.Svar1 = randomAdjektiv.obestämd_form_utrum;
            fragaSvar.Svar2 = randomAdjektiv.obestämd_form_utrum;
            fragaSvar.Svar3 = randomAdjektiv.obestämd_form_utrum;
            fragaSvar.Svar4 = randomAdjektiv.obestämd_form_utrum;
            fragaSvar.Svar5 = randomAdjektiv.obestämd_form_utrum;
            fragaSvar.Svar6 = randomAdjektiv.obestämd_form_utrum;
            fragaSvar.Svar7 = randomAdjektiv.obestämd_form_utrum;
            fragaSvar.Svar8 = randomAdjektiv.obestämd_form_utrum;

            return fragaSvar;
        }

        // 3 vad blir ordet i obestämd form neutrum, adjektiv
        public FragaSvar AdjektivObestämdNeutrum()
        {
            var randomAdjektiv = db.GetRandomAdjektiv();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir adjektivitet '" + randomAdjektiv.ord + "' i obestämd form tillsammans med ett neutrum-substantiv (ett ...)?";
            fragaSvar.Svar1 = randomAdjektiv.obestämd_form_neutrum;
            fragaSvar.Svar2 = randomAdjektiv.obestämd_form_neutrum;
            fragaSvar.Svar3 = randomAdjektiv.obestämd_form_neutrum;
            fragaSvar.Svar4 = randomAdjektiv.obestämd_form_neutrum;
            fragaSvar.Svar5 = randomAdjektiv.obestämd_form_neutrum;
            fragaSvar.Svar6 = randomAdjektiv.obestämd_form_neutrum;
            fragaSvar.Svar7 = randomAdjektiv.obestämd_form_neutrum;
            fragaSvar.Svar8 = randomAdjektiv.obestämd_form_neutrum;

            return fragaSvar;
        }

        // 4 vad blir ordet i bestämd form ej maskulinum, adjektiv
        public FragaSvar AdjektivBestämdFormEjMaskulinum()
        {
            var randomAdjektiv = db.GetRandomAdjektiv();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir adjektivitet '" + randomAdjektiv.ord + "' i bestämd form (ej maskulinum)?";
            fragaSvar.Svar1 = randomAdjektiv.bestämd_form_ej_maskulinum;
            fragaSvar.Svar2 = randomAdjektiv.bestämd_form_ej_maskulinum;
            fragaSvar.Svar3 = randomAdjektiv.bestämd_form_ej_maskulinum;
            fragaSvar.Svar4 = randomAdjektiv.bestämd_form_ej_maskulinum;
            fragaSvar.Svar5 = randomAdjektiv.bestämd_form_ej_maskulinum;
            fragaSvar.Svar6 = randomAdjektiv.bestämd_form_ej_maskulinum;
            fragaSvar.Svar7 = randomAdjektiv.bestämd_form_ej_maskulinum;
            fragaSvar.Svar8 = randomAdjektiv.bestämd_form_ej_maskulinum;

            return fragaSvar;
        }

        // 5 vad blir ordet i singular, adjektiv
        public FragaSvar AdjektivSingular()
        {
            var randomAdjektiv = db.GetRandomAdjektiv();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir adjektivitet '" + randomAdjektiv.plural + "' i singular?";
            fragaSvar.Svar1 = randomAdjektiv.singular;
            fragaSvar.Svar2 = randomAdjektiv.singular;
            fragaSvar.Svar3 = randomAdjektiv.singular;
            fragaSvar.Svar4 = randomAdjektiv.singular;
            fragaSvar.Svar5 = randomAdjektiv.singular;
            fragaSvar.Svar6 = randomAdjektiv.singular;
            fragaSvar.Svar7 = randomAdjektiv.singular;
            fragaSvar.Svar8 = randomAdjektiv.singular;

            return fragaSvar;
        }

        // 6 vad blir ordet i plural, adjektiv
        public FragaSvar AdjektivPlural()
        {
            var randomAdjektiv = db.GetRandomAdjektiv();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir adjektivitet '" + randomAdjektiv.singular + "' i plural?";
            fragaSvar.Svar1 = randomAdjektiv.plural;
            fragaSvar.Svar2 = randomAdjektiv.plural;
            fragaSvar.Svar3 = randomAdjektiv.plural;
            fragaSvar.Svar4 = randomAdjektiv.plural;
            fragaSvar.Svar5 = randomAdjektiv.plural;
            fragaSvar.Svar6 = randomAdjektiv.plural;
            fragaSvar.Svar7 = randomAdjektiv.plural;
            fragaSvar.Svar8 = randomAdjektiv.plural;

            return fragaSvar;
        }
    }
}