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

        // ADJEKTIV - LÄTTA FRÅGOR

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

            fragaSvar.Fraga = "Vad blir adjektivet '" + randomAdjektiv.ord + "' i obestämd form tillsammans med ett utrum-substantiv (en ...)?";
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

            fragaSvar.Fraga = "Vad blir adjektivet '" + randomAdjektiv.ord + "' i obestämd form tillsammans med ett neutrum-substantiv (ett ...)?";
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

            fragaSvar.Fraga = "Vad blir adjektivet '" + randomAdjektiv.ord + "' i bestämd form (ej maskulinum)?";
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

            fragaSvar.Fraga = "Vad blir adjektivet '" + randomAdjektiv.plural + "' i singular?";
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

            fragaSvar.Fraga = "Vad blir adjektivet '" + randomAdjektiv.singular + "' i plural?";
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

        // VERB - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, verb
        public FragaSvar VerbVilkenOrdklass()
        {
            var randomVerb = db.GetRandomVerb();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + randomVerb.ord + "'?";
            fragaSvar.Svar1 = randomVerb.ordklass;
            fragaSvar.Svar2 = randomVerb.även;
            fragaSvar.Svar3 = randomVerb.även;
            fragaSvar.Svar4 = randomVerb.även;
            fragaSvar.Svar5 = randomVerb.även;
            fragaSvar.Svar6 = randomVerb.även;
            fragaSvar.Svar7 = randomVerb.även;
            fragaSvar.Svar8 = randomVerb.även;

            return fragaSvar;
        }

        // 2 vilken typ av verb, verb
        public FragaSvar VerbVilkenTyp()
        {
            var randomVerb = db.GetRandomVerb();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken typ av verb är ordet '" + randomVerb.ord + "'?";
            fragaSvar.Svar1 = randomVerb.typ;
            fragaSvar.Svar2 = randomVerb.typ;
            fragaSvar.Svar3 = randomVerb.typ;
            fragaSvar.Svar4 = randomVerb.typ;
            fragaSvar.Svar5 = randomVerb.typ;
            fragaSvar.Svar6 = randomVerb.typ;
            fragaSvar.Svar7 = randomVerb.typ;
            fragaSvar.Svar8 = randomVerb.typ;

            return fragaSvar;
        }

        // 3 ordets tema i infinitiv, verb
        public FragaSvar VerbInfinitiv()
        {
            var randomVerb = db.GetRandomVerb();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir verbet '" + randomVerb.preteritum + "' i infinitiv?";
            fragaSvar.Svar1 = randomVerb.infinitiv;
            fragaSvar.Svar2 = randomVerb.infinitiv;
            fragaSvar.Svar3 = randomVerb.infinitiv;
            fragaSvar.Svar4 = randomVerb.infinitiv;
            fragaSvar.Svar5 = randomVerb.infinitiv;
            fragaSvar.Svar6 = randomVerb.infinitiv;
            fragaSvar.Svar7 = randomVerb.infinitiv;
            fragaSvar.Svar8 = randomVerb.infinitiv;

            return fragaSvar;
        }

        // 4 ordets tema i preteritum, verb
        public FragaSvar VerbPreteritum()
        {
            var randomVerb = db.GetRandomVerb();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir verbet '" + randomVerb.ord + "' i preteritum?";
            fragaSvar.Svar1 = randomVerb.preteritum;
            fragaSvar.Svar2 = randomVerb.preteritum;
            fragaSvar.Svar3 = randomVerb.preteritum;
            fragaSvar.Svar4 = randomVerb.preteritum;
            fragaSvar.Svar5 = randomVerb.preteritum;
            fragaSvar.Svar6 = randomVerb.preteritum;
            fragaSvar.Svar7 = randomVerb.preteritum;
            fragaSvar.Svar8 = randomVerb.preteritum;

            return fragaSvar;
        }

        // 5 ordets tema i supinum, verb
        public FragaSvar VerbSupinum()
        {
            var randomVerb = db.GetRandomVerb();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir verbet '" + randomVerb.ord + "' i supinum?";
            fragaSvar.Svar1 = randomVerb.supinum;
            fragaSvar.Svar2 = randomVerb.supinum;
            fragaSvar.Svar3 = randomVerb.supinum;
            fragaSvar.Svar4 = randomVerb.supinum;
            fragaSvar.Svar5 = randomVerb.supinum;
            fragaSvar.Svar6 = randomVerb.supinum;
            fragaSvar.Svar7 = randomVerb.supinum;
            fragaSvar.Svar8 = randomVerb.supinum;

            return fragaSvar;
        }

        // ADVERB - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, adverb
        public FragaSvar AdverbVilkenOrdklass()
        {
            var randomAdverb = db.GetRandomAdverbRen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + randomAdverb.ord + "'?";
            fragaSvar.Svar1 = randomAdverb.ordklass;
            fragaSvar.Svar2 = randomAdverb.ordklass_2;
            fragaSvar.Svar3 = randomAdverb.ordklass_2;
            fragaSvar.Svar4 = randomAdverb.ordklass_2;
            fragaSvar.Svar5 = randomAdverb.ordklass_2;
            fragaSvar.Svar6 = randomAdverb.ordklass_2;
            fragaSvar.Svar7 = randomAdverb.ordklass_2;
            fragaSvar.Svar8 = randomAdverb.ordklass_2;

            return fragaSvar;
        }

        // 2 vilken typ av adverb tillhör ordet, adverb
        public FragaSvar AdverbVilkenTyp()
        {
            var randomAdverb = db.GetRandomAdverbRenLatt();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken typ av adverb är ordet '" + randomAdverb.ord + "'?";
            fragaSvar.Svar1 = randomAdverb.typ;
            fragaSvar.Svar2 = randomAdverb.typ_2;
            fragaSvar.Svar3 = randomAdverb.typ_3;
            fragaSvar.Svar4 = randomAdverb.typ_4;
            fragaSvar.Svar5 = randomAdverb.typ_5;
            fragaSvar.Svar6 = randomAdverb.typ_6;
            fragaSvar.Svar7 = randomAdverb.typ_7;
            fragaSvar.Svar8 = randomAdverb.typ_8;

            return fragaSvar;
        }

        // PREPOSITION - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, preposition
        public FragaSvar PrepositionVilkenOrdklass()
        {
            var randomPreposition = db.GetRandomPreposition();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + randomPreposition.ord + "'?";
            fragaSvar.Svar1 = randomPreposition.ordklass;
            fragaSvar.Svar2 = randomPreposition.även;
            fragaSvar.Svar3 = randomPreposition.även;
            fragaSvar.Svar4 = randomPreposition.även;
            fragaSvar.Svar5 = randomPreposition.även;
            fragaSvar.Svar6 = randomPreposition.även;
            fragaSvar.Svar7 = randomPreposition.även;
            fragaSvar.Svar8 = randomPreposition.även;

            return fragaSvar;
        }

        // KONJUNKTION - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, konjunktion
        public FragaSvar KonjunktionVilkenOrdklass()
        {
            var randomKonjunktion = db.GetRandomKonjunktion();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + randomKonjunktion.ord + "'?";
            fragaSvar.Svar1 = randomKonjunktion.ordklass;
            fragaSvar.Svar2 = randomKonjunktion.även;
            fragaSvar.Svar3 = randomKonjunktion.även;
            fragaSvar.Svar4 = randomKonjunktion.även;
            fragaSvar.Svar5 = randomKonjunktion.även;
            fragaSvar.Svar6 = randomKonjunktion.även;
            fragaSvar.Svar7 = randomKonjunktion.även;
            fragaSvar.Svar8 = randomKonjunktion.även;

            return fragaSvar;
        }

        // RÄKNEORD - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, räkneord
        public FragaSvar RakneordVilkenOrdklass()
        {
            var randomRakneord = db.GetRandomRakneord();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + randomRakneord.ord + "'?";
            fragaSvar.Svar1 = randomRakneord.ordklass;
            fragaSvar.Svar2 = randomRakneord.även;
            fragaSvar.Svar3 = randomRakneord.även;
            fragaSvar.Svar4 = randomRakneord.även;
            fragaSvar.Svar5 = randomRakneord.även;
            fragaSvar.Svar6 = randomRakneord.även;
            fragaSvar.Svar7 = randomRakneord.även;
            fragaSvar.Svar8 = randomRakneord.även;

            return fragaSvar;
        }

        // 2 vad blir ordet som grundtal, räkneord
        public FragaSvar RakneordGrundtal()
        {
            var randomRakneord = db.GetRandomRakneord();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir räkneordet '" + randomRakneord.ordningstal_ej_maskulinum + "' som grundtal?";
            fragaSvar.Svar1 = randomRakneord.grundtal;
            fragaSvar.Svar2 = randomRakneord.grundtal_2;
            fragaSvar.Svar3 = randomRakneord.grundtal_2;
            fragaSvar.Svar4 = randomRakneord.grundtal_2;
            fragaSvar.Svar5 = randomRakneord.grundtal_2;
            fragaSvar.Svar6 = randomRakneord.grundtal_2;
            fragaSvar.Svar7 = randomRakneord.grundtal_2;
            fragaSvar.Svar8 = randomRakneord.grundtal_2;

            return fragaSvar;
        }

        // 3 vad blir ordet som ordningstal ej maskulinum, räkneord
        public FragaSvar RakneordOrdningstal()
        {
            var randomRakneord = db.GetRandomRakneord();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir räkneordet '" + randomRakneord.grundtal + "' som ordningstal (ej maskulinum)?";
            fragaSvar.Svar1 = randomRakneord.ordningstal_ej_maskulinum;
            fragaSvar.Svar2 = randomRakneord.ordningstal_ej_maskulinum;
            fragaSvar.Svar3 = randomRakneord.ordningstal_ej_maskulinum;
            fragaSvar.Svar4 = randomRakneord.ordningstal_ej_maskulinum;
            fragaSvar.Svar5 = randomRakneord.ordningstal_ej_maskulinum;
            fragaSvar.Svar6 = randomRakneord.ordningstal_ej_maskulinum;
            fragaSvar.Svar7 = randomRakneord.ordningstal_ej_maskulinum;
            fragaSvar.Svar8 = randomRakneord.ordningstal_ej_maskulinum;

            return fragaSvar;
        }

        // INTERJEKTION - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, interjektion
        public FragaSvar InterjektionVilkenOrdklass()
        {
            var randomInterjektion = db.GetRandomInterjektion();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + randomInterjektion.ord + "'?";
            fragaSvar.Svar1 = randomInterjektion.ordklass;
            fragaSvar.Svar2 = randomInterjektion.även;
            fragaSvar.Svar3 = randomInterjektion.även;
            fragaSvar.Svar4 = randomInterjektion.även;
            fragaSvar.Svar5 = randomInterjektion.även;
            fragaSvar.Svar6 = randomInterjektion.även;
            fragaSvar.Svar7 = randomInterjektion.även;
            fragaSvar.Svar8 = randomInterjektion.även;

            return fragaSvar;
        }
    }
}