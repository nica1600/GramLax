﻿using GrammatikLaxen.Models;
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

        // SUBSTANTIV - BAS FRÅGOR

        // 1 en eller ett, substantiv
        public FragaSvar SubstantivBasEnEllerEtt(substantiv sub)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Framför ett substantiv kan du sätta 'en', 'ett' eller 'flera'. Ska det vara 'en', 'ett' eller 'flera' framför substantivet '" + 
                sub.obestämd_form_singular + "'?";
            fragaSvar.Svar1 = sub.artikel + " " + sub.obestämd_form_singular;
            fragaSvar.Svar2 = sub.artikel;
            fragaSvar.Svar3 = sub.artikel;
            fragaSvar.Svar4 = sub.artikel;
            fragaSvar.Svar5 = sub.artikel;
            fragaSvar.Svar6 = sub.artikel;
            fragaSvar.Svar7 = sub.artikel;
            fragaSvar.Svar8 = sub.artikel;

            return fragaSvar;
        }

        // 2 en, ett eller flera, substantiv
        public FragaSvar SubstantivBasFlera(substantiv sub)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Framför ett substantiv kan du sätta 'en', 'ett' eller 'flera'. Ska det vara 'en', 'ett' eller 'flera' framför substantivet '" +
                sub.obestämd_form_plural + "'?";
            fragaSvar.Svar1 = "flera " + sub.obestämd_form_plural;
            fragaSvar.Svar2 = "flera";
            fragaSvar.Svar3 = "flera";
            fragaSvar.Svar4 = "flera";
            fragaSvar.Svar5 = "flera";
            fragaSvar.Svar6 = "flera";
            fragaSvar.Svar7 = "flera";
            fragaSvar.Svar8 = "flera";

            return fragaSvar;
        }

        // SUBSTANTIV - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, substantiv
        public FragaSvar SubstantivVilkenOrdklass(substantiv sub)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + sub.ord + "'?";
            fragaSvar.Svar1 = sub.ordklass;
            fragaSvar.Svar2 = sub.även;
            fragaSvar.Svar3 = sub.även;
            fragaSvar.Svar4 = sub.även;
            fragaSvar.Svar5 = sub.även;
            fragaSvar.Svar6 = sub.även;
            fragaSvar.Svar7 = sub.även;
            fragaSvar.Svar8 = sub.även;

            return fragaSvar;
        }

        // 2 konkret eller bastrakt, substantiv
        public FragaSvar SubstantivKonkretAbstrakt(substantiv sub)
        {
            //var randomSubstantiv = db.GetRandomSubstantiv();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Är ordet '" + sub.ord + "' ett konkret eller abstrakt substantiv?";
            fragaSvar.Svar1 = sub.betydelse;
            fragaSvar.Svar2 = sub.betydelse;
            fragaSvar.Svar3 = sub.betydelse;
            fragaSvar.Svar4 = sub.betydelse;
            fragaSvar.Svar5 = sub.betydelse;
            fragaSvar.Svar6 = sub.betydelse;
            fragaSvar.Svar7 = sub.betydelse;
            fragaSvar.Svar8 = sub.betydelse;

            return fragaSvar;
        }

        // SUBSTANTIV - MEDELSVÅRA FRÅGOR

        // 1 vilket genus, substantiv
        public FragaSvar SubstantivGenus(substantiv sub)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilket genus har substantivet '" + sub.ord + "'?";
            fragaSvar.Svar1 = sub.genus;
            fragaSvar.Svar2 = sub.artikel;
            fragaSvar.Svar3 = sub.artikel;
            fragaSvar.Svar4 = sub.artikel;
            fragaSvar.Svar5 = sub.artikel;
            fragaSvar.Svar6 = sub.artikel;
            fragaSvar.Svar7 = sub.artikel;
            fragaSvar.Svar8 = sub.artikel;

            return fragaSvar;
        }

        // 2 nominativ, substantiv
        public FragaSvar SubstantivNominativ(substantiv sub)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir substantivet '" + sub.obestämd_form_singular_genitiv + "' i nominativ?";
            fragaSvar.Svar1 = sub.nominativ;
            fragaSvar.Svar2 = sub.nominativ;
            fragaSvar.Svar3 = sub.nominativ;
            fragaSvar.Svar4 = sub.nominativ;
            fragaSvar.Svar5 = sub.nominativ;
            fragaSvar.Svar6 = sub.nominativ;
            fragaSvar.Svar7 = sub.nominativ;
            fragaSvar.Svar8 = sub.nominativ;

            return fragaSvar;
        }

        // 3 genitiv, substantiv
        public FragaSvar SubstantivGenitiv(substantiv sub)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir substantivet '" + sub.nominativ + "' i genitiv?";
            fragaSvar.Svar1 = sub.obestämd_form_singular_genitiv;
            fragaSvar.Svar2 = sub.obestämd_form_singular_genitiv;
            fragaSvar.Svar3 = sub.obestämd_form_singular_genitiv;
            fragaSvar.Svar4 = sub.obestämd_form_singular_genitiv;
            fragaSvar.Svar5 = sub.obestämd_form_singular_genitiv;
            fragaSvar.Svar6 = sub.obestämd_form_singular_genitiv;
            fragaSvar.Svar7 = sub.obestämd_form_singular_genitiv;
            fragaSvar.Svar8 = sub.obestämd_form_singular_genitiv;

            return fragaSvar;
        }

        // SUBSTANTIV - SVÅRA FRÅGOR

        // 1 obestämd form singular, substantiv
        public FragaSvar SubstantivObestamdSingular(substantiv sub)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir substantivet '" + sub.bestämd_form_singular + "' i obestämd form singular?";
            fragaSvar.Svar1 = sub.obestämd_form_singular;
            fragaSvar.Svar2 = sub.obestämd_form_singular;
            fragaSvar.Svar3 = sub.obestämd_form_singular;
            fragaSvar.Svar4 = sub.obestämd_form_singular;
            fragaSvar.Svar5 = sub.obestämd_form_singular;
            fragaSvar.Svar6 = sub.obestämd_form_singular;
            fragaSvar.Svar7 = sub.obestämd_form_singular;
            fragaSvar.Svar8 = sub.obestämd_form_singular;

            return fragaSvar;
        }

        // 2 bestämd form singular, substantiv
        public FragaSvar SubstantivBestamdSingular(substantiv sub)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir substantivet '" + sub.ord + "' i bestämd form singular?";
            fragaSvar.Svar1 = sub.bestämd_form_singular;
            fragaSvar.Svar2 = sub.bestämd_form_singular;
            fragaSvar.Svar3 = sub.bestämd_form_singular;
            fragaSvar.Svar4 = sub.bestämd_form_singular;
            fragaSvar.Svar5 = sub.bestämd_form_singular;
            fragaSvar.Svar6 = sub.bestämd_form_singular;
            fragaSvar.Svar7 = sub.bestämd_form_singular;
            fragaSvar.Svar8 = sub.bestämd_form_singular;

            return fragaSvar;
        }

        // 3 obestämd form plural, substantiv
        public FragaSvar SubstantivObestamdPlural(substantiv sub)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir substantivet '" + sub.ord + "' i obestämd form plural?";
            fragaSvar.Svar1 = sub.obestämd_form_plural;
            fragaSvar.Svar2 = sub.obestämd_form_plural;
            fragaSvar.Svar3 = sub.obestämd_form_plural;
            fragaSvar.Svar4 = sub.obestämd_form_plural;
            fragaSvar.Svar5 = sub.obestämd_form_plural;
            fragaSvar.Svar6 = sub.obestämd_form_plural;
            fragaSvar.Svar7 = sub.obestämd_form_plural;
            fragaSvar.Svar8 = sub.obestämd_form_plural;

            return fragaSvar;
        }

        // 4 bestämd form plural, substantiv
        public FragaSvar SubstantivBestamdPlural(substantiv sub)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir substantivet '" + sub.ord + "' i bestämd form plural?";
            fragaSvar.Svar1 = sub.bestämd_form_plural;
            fragaSvar.Svar2 = sub.bestämd_form_plural;
            fragaSvar.Svar3 = sub.bestämd_form_plural;
            fragaSvar.Svar4 = sub.bestämd_form_plural;
            fragaSvar.Svar5 = sub.bestämd_form_plural;
            fragaSvar.Svar6 = sub.bestämd_form_plural;
            fragaSvar.Svar7 = sub.bestämd_form_plural;
            fragaSvar.Svar8 = sub.bestämd_form_plural;

            return fragaSvar;
        }

        // 5 bestämd fristående artikel singular, substantiv
        public FragaSvar SubstantivBestamdFristaendeArtikelSingular(substantiv sub)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir substantivet '" + sub.ord + "' som bestämd friståede artikel singular?";
            fragaSvar.Svar1 = sub.bestämd_fristående_artikel_singular;
            fragaSvar.Svar2 = sub.bestämd_fristående_artikel_singular;
            fragaSvar.Svar3 = sub.bestämd_fristående_artikel_singular;
            fragaSvar.Svar4 = sub.bestämd_fristående_artikel_singular;
            fragaSvar.Svar5 = sub.bestämd_fristående_artikel_singular;
            fragaSvar.Svar6 = sub.bestämd_fristående_artikel_singular;
            fragaSvar.Svar7 = sub.bestämd_fristående_artikel_singular;
            fragaSvar.Svar8 = sub.bestämd_fristående_artikel_singular;

            return fragaSvar;
        }

        // 6 bestämd fristående artikel plural, substantiv
        public FragaSvar SubstantivBestamdFristaendeArtikelPlural(substantiv sub)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir substantivet '" + sub.ord + "' som bestämd friståede artikel plural?";
            fragaSvar.Svar1 = sub.bestämd_fristående_artikel_plural;
            fragaSvar.Svar2 = sub.bestämd_fristående_artikel_plural;
            fragaSvar.Svar3 = sub.bestämd_fristående_artikel_plural;
            fragaSvar.Svar4 = sub.bestämd_fristående_artikel_plural;
            fragaSvar.Svar5 = sub.bestämd_fristående_artikel_plural;
            fragaSvar.Svar6 = sub.bestämd_fristående_artikel_plural;
            fragaSvar.Svar7 = sub.bestämd_fristående_artikel_plural;
            fragaSvar.Svar8 = sub.bestämd_fristående_artikel_plural;

            return fragaSvar;
        }

        // PRONOMEN - BAS FRÅGOR

        // 1 personliga, pronomen
        public FragaSvar PronomenBasPersonliga(pronomen pro)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Personliga pronomen står ofta framför ett verb. Vilket av följande pronomen ska stå framför verbet 'åkte': '" 
                + pro.personliga_subjekt + "' eller '" + pro.reflexiva + "'?";

            fragaSvar.Svar1 = pro.personliga_subjekt + " åkte";
            fragaSvar.Svar2 = pro.personliga_subjekt;
            fragaSvar.Svar3 = pro.personliga_subjekt;
            fragaSvar.Svar4 = pro.personliga_subjekt;
            fragaSvar.Svar5 = pro.personliga_subjekt;
            fragaSvar.Svar6 = pro.personliga_subjekt;
            fragaSvar.Svar7 = pro.personliga_subjekt;
            fragaSvar.Svar8 = pro.personliga_subjekt;

            return fragaSvar;
        }

        // 2 possessiva, pronomen
        public FragaSvar PronomenBasPossessiva(pronomen pro)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Possessiva pronomen står ofta framför ett substantiv som det äger. Vilket av följande pronomen ska stå framför substantivet 'cykel': '"
              + pro.possessiva_neutrum + "' eller '" + pro.reflexiva + "'?";

            fragaSvar.Svar1 = pro.possessiva_neutrum + " cykel";
            fragaSvar.Svar2 = pro.possessiva_neutrum;
            fragaSvar.Svar3 = pro.possessiva_neutrum;
            fragaSvar.Svar4 = pro.possessiva_neutrum;
            fragaSvar.Svar5 = pro.possessiva_neutrum;
            fragaSvar.Svar6 = pro.possessiva_neutrum;
            fragaSvar.Svar7 = pro.possessiva_neutrum;
            fragaSvar.Svar8 = pro.possessiva_neutrum;

            return fragaSvar;
        }

        // PRONOMEN - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, pronomen
        public FragaSvar PronomenVilkenOrdklass(pronomen pro)
        {
            //var randomPronomen = db.GetRandomPronomen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + pro.ord + "'?";
            fragaSvar.Svar1 = pro.ordklass;
            fragaSvar.Svar2 = pro.även;
            fragaSvar.Svar3 = pro.även;
            fragaSvar.Svar4 = pro.även;
            fragaSvar.Svar5 = pro.även;
            fragaSvar.Svar6 = pro.även;
            fragaSvar.Svar7 = pro.även;
            fragaSvar.Svar8 = pro.även;

            return fragaSvar;
        }

        // 2 gör om till personliga pronomen subjektform, pronomen
        public FragaSvar PronomenPersonligaSubjekt(pronomen pro)
        {
            //var randomPronomen = db.GetRandomPronomen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Hur gör du om ordet '" + pro.personliga_objekt + "' (som är personliga pronomen i objektform) till personliga pronomen i subjektform?";
            fragaSvar.Svar1 = pro.personliga_subjekt;
            fragaSvar.Svar2 = pro.personliga_subjekt;
            fragaSvar.Svar3 = pro.personliga_subjekt;
            fragaSvar.Svar4 = pro.personliga_subjekt;
            fragaSvar.Svar5 = pro.personliga_subjekt;
            fragaSvar.Svar6 = pro.personliga_subjekt;
            fragaSvar.Svar7 = pro.personliga_subjekt;
            fragaSvar.Svar8 = pro.personliga_subjekt;

            return fragaSvar;
        }

        // 3 gör om till personliga pronomen objektform, pronomen
        public FragaSvar PronomenPersonligaObjekt(pronomen pro)
        {
            //var randomPronomen = db.GetRandomPronomen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Hur gör du om ordet '" + pro.personliga_subjekt + "' (som är personliga pronomen i subjektform) till personliga pronomen i objektform?";
            fragaSvar.Svar1 = pro.personliga_objekt;
            fragaSvar.Svar2 = pro.personliga_objekt;
            fragaSvar.Svar3 = pro.personliga_objekt;
            fragaSvar.Svar4 = pro.personliga_objekt;
            fragaSvar.Svar5 = pro.personliga_objekt;
            fragaSvar.Svar6 = pro.personliga_objekt;
            fragaSvar.Svar7 = pro.personliga_objekt;
            fragaSvar.Svar8 = pro.personliga_objekt;

            return fragaSvar;
        }

        // 4 gör om till possessivt utrum, pronomen
        public FragaSvar PronomenPossessivaUtrum(pronomen pro)
        {
            //var randomPronomen = db.GetRandomPronomen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + pro.ord + "' som possessivt pronomen om det står tillsammans med ett utrum-substantiv (en ...)?";
            fragaSvar.Svar1 = pro.possessiva_utrum;
            fragaSvar.Svar2 = pro.possessiva_utrum;
            fragaSvar.Svar3 = pro.possessiva_utrum;
            fragaSvar.Svar4 = pro.possessiva_utrum;
            fragaSvar.Svar5 = pro.possessiva_utrum;
            fragaSvar.Svar6 = pro.possessiva_utrum;
            fragaSvar.Svar7 = pro.possessiva_utrum;
            fragaSvar.Svar8 = pro.possessiva_utrum;

            return fragaSvar;
        }

        // 5 gör om till possessivt neutrum, pronomen
        public FragaSvar PronomenPossessivaNeutrum(pronomen pro)
        {
            //var randomPronomen = db.GetRandomPronomen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + pro.ord + "' som possessivt pronomen om det står tillsammans med ett neutrum-substantiv (ett ...)?";
            fragaSvar.Svar1 = pro.possessiva_neutrum;
            fragaSvar.Svar2 = pro.possessiva_neutrum;
            fragaSvar.Svar3 = pro.possessiva_neutrum;
            fragaSvar.Svar4 = pro.possessiva_neutrum;
            fragaSvar.Svar5 = pro.possessiva_neutrum;
            fragaSvar.Svar6 = pro.possessiva_neutrum;
            fragaSvar.Svar7 = pro.possessiva_neutrum;
            fragaSvar.Svar8 = pro.possessiva_neutrum;

            return fragaSvar;
        }

        // 6 gör om till possessivt plural, pronomen
        public FragaSvar PronomenPossessivaPlural(pronomen pro)
        {
            //var randomPronomen = db.GetRandomPronomen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + pro.ord + "' som possessivt pronomen om det står tillsammans med ett substantiv i plural (flera)?";
            fragaSvar.Svar1 = pro.possessiva_plural;
            fragaSvar.Svar2 = pro.possessiva_plural;
            fragaSvar.Svar3 = pro.possessiva_plural;
            fragaSvar.Svar4 = pro.possessiva_plural;
            fragaSvar.Svar5 = pro.possessiva_plural;
            fragaSvar.Svar6 = pro.possessiva_plural;
            fragaSvar.Svar7 = pro.possessiva_plural;
            fragaSvar.Svar8 = pro.possessiva_plural;

            return fragaSvar;
        }

        // 7 gör om till reflexivt, pronomen
        public FragaSvar PronomenReflexiva(pronomen pro)
        {
            //var randomPronomen = db.GetRandomPronomen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + pro.ord + "' som reflexivt pronomen?";
            fragaSvar.Svar1 = pro.reflexiva;
            fragaSvar.Svar2 = pro.reflexiva;
            fragaSvar.Svar3 = pro.reflexiva;
            fragaSvar.Svar4 = pro.reflexiva;
            fragaSvar.Svar5 = pro.reflexiva;
            fragaSvar.Svar6 = pro.reflexiva;
            fragaSvar.Svar7 = pro.reflexiva;
            fragaSvar.Svar8 = pro.reflexiva;

            return fragaSvar;
        }

        // PRONOMEN - MEDELSVÅRA FRÅGOR

        // 1 gör om till reflexiva possessiva pronomen utrum, pronomen
        public FragaSvar PronomenReflexivaPossessivaUtrum(pronomen pro)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + pro.ord + "' som reflexivt possessivt pronomen tillsammans med ett utrum-substantiv?";
            fragaSvar.Svar1 = pro.reflexiva_possessiva_utrum;
            fragaSvar.Svar2 = pro.reflexiva_possessiva_utrum;
            fragaSvar.Svar3 = pro.reflexiva_possessiva_utrum;
            fragaSvar.Svar4 = pro.reflexiva_possessiva_utrum;
            fragaSvar.Svar5 = pro.reflexiva_possessiva_utrum;
            fragaSvar.Svar6 = pro.reflexiva_possessiva_utrum;
            fragaSvar.Svar7 = pro.reflexiva_possessiva_utrum;
            fragaSvar.Svar8 = pro.reflexiva_possessiva_utrum;

            return fragaSvar;
        }

        // 2 gör om till reflexiva possessiva pronomen neutrum, pronomen
        public FragaSvar PronomenReflexivaPossessivaNeutrum(pronomen pro)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + pro.ord + "' som reflexivt possessivt pronomen tillsammans med ett neutrum-substantiv?";
            fragaSvar.Svar1 = pro.reflexiva_possessiva_neutrum;
            fragaSvar.Svar2 = pro.reflexiva_possessiva_neutrum;
            fragaSvar.Svar3 = pro.reflexiva_possessiva_neutrum;
            fragaSvar.Svar4 = pro.reflexiva_possessiva_neutrum;
            fragaSvar.Svar5 = pro.reflexiva_possessiva_neutrum;
            fragaSvar.Svar6 = pro.reflexiva_possessiva_neutrum;
            fragaSvar.Svar7 = pro.reflexiva_possessiva_neutrum;
            fragaSvar.Svar8 = pro.reflexiva_possessiva_neutrum;

            return fragaSvar;
        }

        // 3 gör om till reflexiva possessiva pronomen plural, pronomen
        public FragaSvar PronomenReflexivaPossessivaPlural(pronomen pro)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + pro.ord + "' som reflexivt possessivt pronomen tillsammans med flera substantiv (plural)?";
            fragaSvar.Svar1 = pro.reflexiva_possessiva_plural;
            fragaSvar.Svar2 = pro.reflexiva_possessiva_plural;
            fragaSvar.Svar3 = pro.reflexiva_possessiva_plural;
            fragaSvar.Svar4 = pro.reflexiva_possessiva_plural;
            fragaSvar.Svar5 = pro.reflexiva_possessiva_plural;
            fragaSvar.Svar6 = pro.reflexiva_possessiva_plural;
            fragaSvar.Svar7 = pro.reflexiva_possessiva_plural;
            fragaSvar.Svar8 = pro.reflexiva_possessiva_plural;

            return fragaSvar;
        }

        // 4 gör om till relativa pronomen grundform, pronomen
        public FragaSvar PronomenRelativaGrundform(pronomen pro)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + pro.ord + "' som relativt pronomen i grundform?";
            fragaSvar.Svar1 = pro.relativa_grundform;
            fragaSvar.Svar2 = pro.relativa_grundform;
            fragaSvar.Svar3 = pro.relativa_grundform;
            fragaSvar.Svar4 = pro.relativa_grundform;
            fragaSvar.Svar5 = pro.relativa_grundform;
            fragaSvar.Svar6 = pro.relativa_grundform;
            fragaSvar.Svar7 = pro.relativa_grundform;
            fragaSvar.Svar8 = pro.relativa_grundform;

            return fragaSvar;
        }

        // 5 gör om till relativa pronomen genitiv, pronomen
        public FragaSvar PronomenRelativaGenitiv(pronomen pro)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + pro.ord + "' som relativt pronomen i genitiv?";
            fragaSvar.Svar1 = pro.relativa_genitiv;
            fragaSvar.Svar2 = pro.relativa_genitiv;
            fragaSvar.Svar3 = pro.relativa_genitiv;
            fragaSvar.Svar4 = pro.relativa_genitiv;
            fragaSvar.Svar5 = pro.relativa_genitiv;
            fragaSvar.Svar6 = pro.relativa_genitiv;
            fragaSvar.Svar7 = pro.relativa_genitiv;
            fragaSvar.Svar8 = pro.relativa_genitiv;

            return fragaSvar;
        }

        // 6 gör om till interrogativa, pronomen
        public FragaSvar PronomenInterrogativa(pronomen pro)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + pro.ord + "' som interrogativt pronomen?";
            fragaSvar.Svar1 = pro.interrogativa;
            fragaSvar.Svar2 = pro.interrogativa_2;
            fragaSvar.Svar3 = pro.interrogativa_2;
            fragaSvar.Svar4 = pro.interrogativa_2;
            fragaSvar.Svar5 = pro.interrogativa_2;
            fragaSvar.Svar6 = pro.interrogativa_2;
            fragaSvar.Svar7 = pro.interrogativa_2;
            fragaSvar.Svar8 = pro.interrogativa_2;

            return fragaSvar;
        }

        // 7 gör om till demonstrativa nära, pronomen
        public FragaSvar PronomenDemonstrativaNara(pronomen pro)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + pro.ord + "' som demonstrativt pronomen där något befinner sig nära?";
            fragaSvar.Svar1 = pro.demonstrativa_nära;
            fragaSvar.Svar2 = pro.demonstrativa_nära;
            fragaSvar.Svar3 = pro.demonstrativa_nära;
            fragaSvar.Svar4 = pro.demonstrativa_nära;
            fragaSvar.Svar5 = pro.demonstrativa_nära;
            fragaSvar.Svar6 = pro.demonstrativa_nära;
            fragaSvar.Svar7 = pro.demonstrativa_nära;
            fragaSvar.Svar8 = pro.demonstrativa_nära;

            return fragaSvar;
        }

        // 8 gör om till demonstrativa långt bort, pronomen
        public FragaSvar PronomenDemonstrativaLangtBort(pronomen pro)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir ordet '" + pro.ord + "' som demonstrativt pronomen där något befinner sig långt bort?";
            fragaSvar.Svar1 = pro.demonstrativa_långt_bort;
            fragaSvar.Svar2 = pro.demonstrativa_långt_bort;
            fragaSvar.Svar3 = pro.demonstrativa_långt_bort;
            fragaSvar.Svar4 = pro.demonstrativa_långt_bort;
            fragaSvar.Svar5 = pro.demonstrativa_långt_bort;
            fragaSvar.Svar6 = pro.demonstrativa_långt_bort;
            fragaSvar.Svar7 = pro.demonstrativa_långt_bort;
            fragaSvar.Svar8 = pro.demonstrativa_långt_bort;

            return fragaSvar;
        }

        // ADJEKTIV - BAS FRÅGOR

        // 1 komparera positiv, adjektiv
        public FragaSvar AdjektivBasPositiv(adjektiv adj)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Fyll i det adjektiv som saknas i komparationen: ? - " + adj.komparativ + " - " + adj.superlativ_predikativt;

            fragaSvar.Svar1 = adj.positiv;
            fragaSvar.Svar2 = adj.positiv;
            fragaSvar.Svar3 = adj.positiv;
            fragaSvar.Svar4 = adj.positiv;
            fragaSvar.Svar5 = adj.positiv;
            fragaSvar.Svar6 = adj.positiv;
            fragaSvar.Svar7 = adj.positiv;
            fragaSvar.Svar8 = adj.positiv;

            return fragaSvar;
        }

        // 2 komparera komparativ, adjektiv
        public FragaSvar AdjektivBasKomparativ(adjektiv adj)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Fyll i det adjektiv som saknas i komparationen: " + adj.positiv + " - ? - " + adj.superlativ_predikativt;

            fragaSvar.Svar1 = adj.komparativ;
            fragaSvar.Svar2 = adj.komparativ;
            fragaSvar.Svar3 = adj.komparativ;
            fragaSvar.Svar4 = adj.komparativ;
            fragaSvar.Svar5 = adj.komparativ;
            fragaSvar.Svar6 = adj.komparativ;
            fragaSvar.Svar7 = adj.komparativ;
            fragaSvar.Svar8 = adj.komparativ;

            return fragaSvar;
        }

        // 3 komparera superlativ, adjektiv
        public FragaSvar AdjektivBasSuperlativ(adjektiv adj)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Fyll i det adjektiv som saknas i komparationen: " + adj.positiv + " - " + adj.komparativ + " - ?";

            fragaSvar.Svar1 = adj.superlativ_attributivt_ej_maskulinum;
            fragaSvar.Svar2 = adj.superlativ_predikativt;
            fragaSvar.Svar3 = adj.superlativ_predikativt;
            fragaSvar.Svar4 = adj.superlativ_predikativt;
            fragaSvar.Svar5 = adj.superlativ_predikativt;
            fragaSvar.Svar6 = adj.superlativ_predikativt;
            fragaSvar.Svar7 = adj.superlativ_predikativt;
            fragaSvar.Svar8 = adj.superlativ_predikativt;

            return fragaSvar;
        }

        // ADJEKTIV - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, adjektiv
        public FragaSvar AdjektivVilkenOrdklass(adjektiv adj)
        {
            //var randomAdjektiv = db.GetRandomAdjektiv();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + adj.ord + "'?";
            fragaSvar.Svar1 = adj.ordklass;
            fragaSvar.Svar2 = adj.även;
            fragaSvar.Svar3 = adj.även;
            fragaSvar.Svar4 = adj.även;
            fragaSvar.Svar5 = adj.även;
            fragaSvar.Svar6 = adj.även;
            fragaSvar.Svar7 = adj.även;
            fragaSvar.Svar8 = adj.även;

            return fragaSvar;
        }

        // 2 vad blir ordet i obestämd form utrum, adjektiv
        public FragaSvar AdjektivObestämdUtrum(adjektiv adj)
        {
            //var randomAdjektiv = db.GetRandomAdjektiv();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir adjektivet '" + adj.ord + "' i obestämd form tillsammans med ett utrum-substantiv (en ...)?";
            fragaSvar.Svar1 = adj.obestämd_form_utrum;
            fragaSvar.Svar2 = adj.obestämd_form_utrum;
            fragaSvar.Svar3 = adj.obestämd_form_utrum;
            fragaSvar.Svar4 = adj.obestämd_form_utrum;
            fragaSvar.Svar5 = adj.obestämd_form_utrum;
            fragaSvar.Svar6 = adj.obestämd_form_utrum;
            fragaSvar.Svar7 = adj.obestämd_form_utrum;
            fragaSvar.Svar8 = adj.obestämd_form_utrum;

            return fragaSvar;
        }

        // 3 vad blir ordet i obestämd form neutrum, adjektiv
        public FragaSvar AdjektivObestämdNeutrum(adjektiv adj)
        {
            //var randomAdjektiv = db.GetRandomAdjektiv();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir adjektivet '" + adj.ord + "' i obestämd form tillsammans med ett neutrum-substantiv (ett ...)?";
            fragaSvar.Svar1 = adj.obestämd_form_neutrum;
            fragaSvar.Svar2 = adj.obestämd_form_neutrum;
            fragaSvar.Svar3 = adj.obestämd_form_neutrum;
            fragaSvar.Svar4 = adj.obestämd_form_neutrum;
            fragaSvar.Svar5 = adj.obestämd_form_neutrum;
            fragaSvar.Svar6 = adj.obestämd_form_neutrum;
            fragaSvar.Svar7 = adj.obestämd_form_neutrum;
            fragaSvar.Svar8 = adj.obestämd_form_neutrum;

            return fragaSvar;
        }

        // 4 vad blir ordet i bestämd form ej maskulinum, adjektiv
        public FragaSvar AdjektivBestämdFormEjMaskulinum(adjektiv adj)
        {
            //var randomAdjektiv = db.GetRandomAdjektiv();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir adjektivet '" + adj.ord + "' i bestämd form (ej maskulinum)?";
            fragaSvar.Svar1 = adj.bestämd_form_ej_maskulinum;
            fragaSvar.Svar2 = adj.bestämd_form_ej_maskulinum;
            fragaSvar.Svar3 = adj.bestämd_form_ej_maskulinum;
            fragaSvar.Svar4 = adj.bestämd_form_ej_maskulinum;
            fragaSvar.Svar5 = adj.bestämd_form_ej_maskulinum;
            fragaSvar.Svar6 = adj.bestämd_form_ej_maskulinum;
            fragaSvar.Svar7 = adj.bestämd_form_ej_maskulinum;
            fragaSvar.Svar8 = adj.bestämd_form_ej_maskulinum;

            return fragaSvar;
        }

        // 5 vad blir ordet i singular, adjektiv
        public FragaSvar AdjektivSingular(adjektiv adj)
        {
            //var randomAdjektiv = db.GetRandomAdjektiv();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir adjektivet '" + adj.plural + "' i singular?";
            fragaSvar.Svar1 = adj.singular;
            fragaSvar.Svar2 = adj.singular;
            fragaSvar.Svar3 = adj.singular;
            fragaSvar.Svar4 = adj.singular;
            fragaSvar.Svar5 = adj.singular;
            fragaSvar.Svar6 = adj.singular;
            fragaSvar.Svar7 = adj.singular;
            fragaSvar.Svar8 = adj.singular;

            return fragaSvar;
        }

        // 6 vad blir ordet i plural, adjektiv
        public FragaSvar AdjektivPlural(adjektiv adj)
        {
            //var randomAdjektiv = db.GetRandomAdjektiv();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir adjektivet '" + adj.singular + "' i plural?";
            fragaSvar.Svar1 = adj.plural;
            fragaSvar.Svar2 = adj.plural;
            fragaSvar.Svar3 = adj.plural;
            fragaSvar.Svar4 = adj.plural;
            fragaSvar.Svar5 = adj.plural;
            fragaSvar.Svar6 = adj.plural;
            fragaSvar.Svar7 = adj.plural;
            fragaSvar.Svar8 = adj.plural;

            return fragaSvar;
        }

        // ADJEKTIV - MEDELSVÅRA FRÅGOR

        // 1 komparera till positiv, adjektiv
        public FragaSvar AdjektivPositiv(adjektiv adj)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir adjektivet '" + adj.komparativ + "' om du komparerar det till positiv?";
            fragaSvar.Svar1 = adj.positiv;
            fragaSvar.Svar2 = adj.positiv;
            fragaSvar.Svar3 = adj.positiv;
            fragaSvar.Svar4 = adj.positiv;
            fragaSvar.Svar5 = adj.positiv;
            fragaSvar.Svar6 = adj.positiv;
            fragaSvar.Svar7 = adj.positiv;
            fragaSvar.Svar8 = adj.positiv;

            return fragaSvar;
        }

        // 2 komparera till komparativ, adjektiv
        public FragaSvar AdjektivKomparativ(adjektiv adj)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir adjektivet '" + adj.positiv + "' om du komparerar det till komparativ?";
            fragaSvar.Svar1 = adj.komparativ;
            fragaSvar.Svar2 = adj.komparativ;
            fragaSvar.Svar3 = adj.komparativ;
            fragaSvar.Svar4 = adj.komparativ;
            fragaSvar.Svar5 = adj.komparativ;
            fragaSvar.Svar6 = adj.komparativ;
            fragaSvar.Svar7 = adj.komparativ;
            fragaSvar.Svar8 = adj.komparativ;

            return fragaSvar;
        }

        // 3 komparera till superlativ predikativt, adjektiv
        public FragaSvar AdjektivSuperlativPredikativ(adjektiv adj)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir adjektivet '" + adj.positiv + "' om du komparerar det till superlativ (predikativ ställning)?";
            fragaSvar.Svar1 = adj.superlativ_predikativt;
            fragaSvar.Svar2 = adj.superlativ_predikativt;
            fragaSvar.Svar3 = adj.superlativ_predikativt;
            fragaSvar.Svar4 = adj.superlativ_predikativt;
            fragaSvar.Svar5 = adj.superlativ_predikativt;
            fragaSvar.Svar6 = adj.superlativ_predikativt;
            fragaSvar.Svar7 = adj.superlativ_predikativt;
            fragaSvar.Svar8 = adj.superlativ_predikativt;

            return fragaSvar;
        }

        // ADJEKTIV - SVÅRA FRÅGOR

        // 1 komparera till superlativ attributivt ej maskulinum, adjektiv
        public FragaSvar AdjektivSuperlativAttributivEjMaskulinum(adjektiv adj)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir adjektivet '" + adj.positiv + "' om du komparerar det till superlativ (attributiv ställning, ej maskulinum)?";
            fragaSvar.Svar1 = adj.superlativ_attributivt_ej_maskulinum;
            fragaSvar.Svar2 = adj.superlativ_attributivt_ej_maskulinum;
            fragaSvar.Svar3 = adj.superlativ_attributivt_ej_maskulinum;
            fragaSvar.Svar4 = adj.superlativ_attributivt_ej_maskulinum;
            fragaSvar.Svar5 = adj.superlativ_attributivt_ej_maskulinum;
            fragaSvar.Svar6 = adj.superlativ_attributivt_ej_maskulinum;
            fragaSvar.Svar7 = adj.superlativ_attributivt_ej_maskulinum;
            fragaSvar.Svar8 = adj.superlativ_attributivt_ej_maskulinum;

            return fragaSvar;
        }

        // VERB - BAS FRÅGOR

        // 1 tema infinitiv, verb
        public FragaSvar VerbBasInfinitiv(verb ver)
        {
            fragaSvar = new FragaSvar();
            
            fragaSvar.Fraga = "Fyll i det verb som saknas: att ? - " + " igår " + ver.preteritum + " - har " + ver.supinum;
            fragaSvar.Svar1 = ver.attribut_infinitiv + " " + ver.infinitiv;
            fragaSvar.Svar2 = ver.infinitiv;
            fragaSvar.Svar3 = ver.infinitiv;
            fragaSvar.Svar4 = ver.infinitiv;
            fragaSvar.Svar5 = ver.infinitiv;
            fragaSvar.Svar6 = ver.infinitiv;
            fragaSvar.Svar7 = ver.infinitiv;
            fragaSvar.Svar8 = ver.infinitiv;

            return fragaSvar;
        }

        // 2 tema preteritum, verb
        public FragaSvar VerbBasPreteritum(verb ver)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Fyll i det verb som saknas: att " + ver.infinitiv + " - igår ? - har " + ver.supinum;
            fragaSvar.Svar1 = ver.attribut_preteritum + " " + ver.preteritum;
            fragaSvar.Svar2 = ver.preteritum;
            fragaSvar.Svar3 = ver.preteritum;
            fragaSvar.Svar4 = ver.preteritum;
            fragaSvar.Svar5 = ver.preteritum;
            fragaSvar.Svar6 = ver.preteritum;
            fragaSvar.Svar7 = ver.preteritum;
            fragaSvar.Svar8 = ver.preteritum;

            return fragaSvar;
        }

        // 3 tema supinum, verb
        public FragaSvar VerbBasSupinum(verb ver)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Fyll i det verb som saknas: att " + ver.infinitiv + " - igår " + ver.preteritum + " - har ?";
            fragaSvar.Svar1 = ver.attribut_supinum + " " + ver.supinum;
            fragaSvar.Svar2 = ver.supinum;
            fragaSvar.Svar3 = ver.supinum;
            fragaSvar.Svar4 = ver.supinum;
            fragaSvar.Svar5 = ver.supinum;
            fragaSvar.Svar6 = ver.supinum;
            fragaSvar.Svar7 = ver.supinum;
            fragaSvar.Svar8 = ver.supinum;

            return fragaSvar;
        }

        // VERB - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, verb
        public FragaSvar VerbVilkenOrdklass(verb ver)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + ver.ord + "'?";
            fragaSvar.Svar1 = ver.ordklass;
            fragaSvar.Svar2 = ver.även;
            fragaSvar.Svar3 = ver.även;
            fragaSvar.Svar4 = ver.även;
            fragaSvar.Svar5 = ver.även;
            fragaSvar.Svar6 = ver.även;
            fragaSvar.Svar7 = ver.även;
            fragaSvar.Svar8 = ver.även;

            return fragaSvar;
        }

        // 2 vilken typ av verb, verb
        public FragaSvar VerbVilkenTyp(verb ver)
        {
            //var randomVerb = db.GetRandomVerb();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken typ av verb är ordet '" + ver.ord + "'?";
            fragaSvar.Svar1 = ver.typ;
            fragaSvar.Svar2 = ver.typ;
            fragaSvar.Svar3 = ver.typ;
            fragaSvar.Svar4 = ver.typ;
            fragaSvar.Svar5 = ver.typ;
            fragaSvar.Svar6 = ver.typ;
            fragaSvar.Svar7 = ver.typ;
            fragaSvar.Svar8 = ver.typ;

            return fragaSvar;
        }

        // 3 ordets tema i infinitiv, verb
        public FragaSvar VerbInfinitiv(verb ver)
        {
            //var randomVerb = db.GetRandomVerb();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir verbet '" + ver.preteritum + "' i infinitiv?";
            fragaSvar.Svar1 = ver.infinitiv;
            fragaSvar.Svar2 = ver.infinitiv;
            fragaSvar.Svar3 = ver.infinitiv;
            fragaSvar.Svar4 = ver.infinitiv;
            fragaSvar.Svar5 = ver.infinitiv;
            fragaSvar.Svar6 = ver.infinitiv;
            fragaSvar.Svar7 = ver.infinitiv;
            fragaSvar.Svar8 = ver.infinitiv;

            return fragaSvar;
        }

        // 4 ordets tema i preteritum, verb
        public FragaSvar VerbPreteritum(verb ver)
        {
            //var randomVerb = db.GetRandomVerb();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir verbet '" + ver.ord + "' i preteritum?";
            fragaSvar.Svar1 = ver.preteritum;
            fragaSvar.Svar2 = ver.preteritum;
            fragaSvar.Svar3 = ver.preteritum;
            fragaSvar.Svar4 = ver.preteritum;
            fragaSvar.Svar5 = ver.preteritum;
            fragaSvar.Svar6 = ver.preteritum;
            fragaSvar.Svar7 = ver.preteritum;
            fragaSvar.Svar8 = ver.preteritum;

            return fragaSvar;
        }

        // 5 ordets tema i supinum, verb
        public FragaSvar VerbSupinum(verb ver)
        {
            //var randomVerb = db.GetRandomVerb();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir verbet '" + ver.ord + "' i supinum?";
            fragaSvar.Svar1 = ver.supinum;
            fragaSvar.Svar2 = ver.supinum;
            fragaSvar.Svar3 = ver.supinum;
            fragaSvar.Svar4 = ver.supinum;
            fragaSvar.Svar5 = ver.supinum;
            fragaSvar.Svar6 = ver.supinum;
            fragaSvar.Svar7 = ver.supinum;
            fragaSvar.Svar8 = ver.supinum;

            return fragaSvar;
        }

        // VERB - MEDELSVÅRA FRÅGOR

        // 1 gör om till presens, verb
        public FragaSvar VerbPresens(verb ver)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir verbet '" + ver.ord + "' i presens?";
            fragaSvar.Svar1 = ver.presens;
            fragaSvar.Svar2 = ver.presens;
            fragaSvar.Svar3 = ver.presens;
            fragaSvar.Svar4 = ver.presens;
            fragaSvar.Svar5 = ver.presens;
            fragaSvar.Svar6 = ver.presens;
            fragaSvar.Svar7 = ver.presens;
            fragaSvar.Svar8 = ver.presens;

            return fragaSvar;
        }

        // 2 gör om till perfekt, verb
        public FragaSvar VerbPerfekt(verb ver)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir verbet '" + ver.ord + "' i perfekt?";
            fragaSvar.Svar1 = ver.perfekt;
            fragaSvar.Svar2 = ver.perfekt;
            fragaSvar.Svar3 = ver.perfekt;
            fragaSvar.Svar4 = ver.perfekt;
            fragaSvar.Svar5 = ver.perfekt;
            fragaSvar.Svar6 = ver.perfekt;
            fragaSvar.Svar7 = ver.perfekt;
            fragaSvar.Svar8 = ver.perfekt;

            return fragaSvar;
        }

        // 3 gör om till pluskvamperfekt, verb
        public FragaSvar VerbPluskvamperfekt(verb ver)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir verbet '" + ver.ord + "' i pluskvamperfekt?";
            fragaSvar.Svar1 = ver.pluskvamperfekt;
            fragaSvar.Svar2 = ver.pluskvamperfekt;
            fragaSvar.Svar3 = ver.pluskvamperfekt;
            fragaSvar.Svar4 = ver.pluskvamperfekt;
            fragaSvar.Svar5 = ver.pluskvamperfekt;
            fragaSvar.Svar6 = ver.pluskvamperfekt;
            fragaSvar.Svar7 = ver.pluskvamperfekt;
            fragaSvar.Svar8 = ver.pluskvamperfekt;

            return fragaSvar;
        }

        // 4 gör om till futurum, verb
        public FragaSvar VerbFuturum(verb ver)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir verbet '" + ver.ord + "' i futurum?";
            fragaSvar.Svar1 = ver.futurum;
            fragaSvar.Svar2 = ver.futurum;
            fragaSvar.Svar3 = ver.futurum;
            fragaSvar.Svar4 = ver.futurum;
            fragaSvar.Svar5 = ver.futurum;
            fragaSvar.Svar6 = ver.futurum;
            fragaSvar.Svar7 = ver.futurum;
            fragaSvar.Svar8 = ver.futurum;

            return fragaSvar;
        }

        // 5 gör om till imperativ, verb
        public FragaSvar VerbImperativ(verb ver)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir verbet '" + ver.ord + "' i imperativ?";
            fragaSvar.Svar1 = ver.imperativ;
            fragaSvar.Svar2 = ver.imperativ;
            fragaSvar.Svar3 = ver.imperativ;
            fragaSvar.Svar4 = ver.imperativ;
            fragaSvar.Svar5 = ver.imperativ;
            fragaSvar.Svar6 = ver.imperativ;
            fragaSvar.Svar7 = ver.imperativ;
            fragaSvar.Svar8 = ver.imperativ;

            return fragaSvar;
        }

        // VERB - MEDELSVÅRA FRÅGOR

        // 1 gör om till presens particip
        public FragaSvar VerbPresensParticip(verb ver)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir verbet '" + ver.ord + "' i presens particip?";
            fragaSvar.Svar1 = ver.presens_particip;
            fragaSvar.Svar2 = ver.presens_particip_2;
            fragaSvar.Svar3 = ver.presens_particip_2;
            fragaSvar.Svar4 = ver.presens_particip_2;
            fragaSvar.Svar5 = ver.presens_particip_2;
            fragaSvar.Svar6 = ver.presens_particip_2;
            fragaSvar.Svar7 = ver.presens_particip_2;
            fragaSvar.Svar8 = ver.presens_particip_2;

            return fragaSvar;
        }

        // 2 gör om till perfekt particip
        public FragaSvar VerbPerfektParticip(verb ver)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir verbet '" + ver.ord + "' i perfekt particip?";
            fragaSvar.Svar1 = ver.perfekt_particip;
            fragaSvar.Svar2 = ver.perfekt_particip;
            fragaSvar.Svar3 = ver.perfekt_particip;
            fragaSvar.Svar4 = ver.perfekt_particip;
            fragaSvar.Svar5 = ver.perfekt_particip;
            fragaSvar.Svar6 = ver.perfekt_particip;
            fragaSvar.Svar7 = ver.perfekt_particip;
            fragaSvar.Svar8 = ver.perfekt_particip;

            return fragaSvar;
        }

        // ADVERB - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, adverb
        public FragaSvar AdverbVilkenOrdklass(adverb adv)
        {
            //var randomAdverb = db.GetRandomAdverbRen();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + adv.ord + "'?";
            fragaSvar.Svar1 = adv.ordklass;
            fragaSvar.Svar2 = adv.ordklass_2;
            fragaSvar.Svar3 = adv.ordklass_2;
            fragaSvar.Svar4 = adv.ordklass_2;
            fragaSvar.Svar5 = adv.ordklass_2;
            fragaSvar.Svar6 = adv.ordklass_2;
            fragaSvar.Svar7 = adv.ordklass_2;
            fragaSvar.Svar8 = adv.ordklass_2;

            return fragaSvar;
        }

        // 2 vilken typ av adverb tillhör ordet, adverb
        public FragaSvar AdverbVilkenTyp(adverb adv)
        {
            //var randomAdverb = db.GetRandomAdverbRenLatt();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken typ av adverb är ordet '" + adv.ord + "'?";
            fragaSvar.Svar1 = adv.typ;
            fragaSvar.Svar2 = adv.typ_2;
            fragaSvar.Svar3 = adv.typ_3;
            fragaSvar.Svar4 = adv.typ_4;
            fragaSvar.Svar5 = adv.typ_5;
            fragaSvar.Svar6 = adv.typ_6;
            fragaSvar.Svar7 = adv.typ_7;
            fragaSvar.Svar8 = adv.typ_7;

            return fragaSvar;
        }

        // ADVERB - MEDELSVÅRA FRÅGOR

        // 1 vilken typ av adverb tillhör ordet, adverb
        public FragaSvar AdverbVilkenTypMedelsvar(adverb adv)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken typ av adverb är ordet '" + adv.ord + "'?";
            fragaSvar.Svar1 = adv.typ;
            fragaSvar.Svar2 = adv.typ_2;
            fragaSvar.Svar3 = adv.typ_3;
            fragaSvar.Svar4 = adv.typ_4;
            fragaSvar.Svar5 = adv.typ_5;
            fragaSvar.Svar6 = adv.typ_6;
            fragaSvar.Svar7 = adv.typ_7;
            fragaSvar.Svar8 = adv.typ_7;

            return fragaSvar;
        }

        // PREPOSITION - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, preposition
        public FragaSvar PrepositionVilkenOrdklass(preposition pre)
        {
            //var randomPreposition = db.GetRandomPreposition();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + pre.ord + "'?";
            fragaSvar.Svar1 = pre.ordklass;
            fragaSvar.Svar2 = pre.även;
            fragaSvar.Svar3 = pre.även;
            fragaSvar.Svar4 = pre.även;
            fragaSvar.Svar5 = pre.även;
            fragaSvar.Svar6 = pre.även;
            fragaSvar.Svar7 = pre.även;
            fragaSvar.Svar8 = pre.även;

            return fragaSvar;
        }

        // KONJUNKTION - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, konjunktion
        public FragaSvar KonjunktionVilkenOrdklass(konjunktion kon)
        {
            //var randomKonjunktion = db.GetRandomKonjunktion();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + kon.ord + "'?";
            fragaSvar.Svar1 = kon.ordklass;
            fragaSvar.Svar2 = kon.även;
            fragaSvar.Svar3 = kon.även;
            fragaSvar.Svar4 = kon.även;
            fragaSvar.Svar5 = kon.även;
            fragaSvar.Svar6 = kon.även;
            fragaSvar.Svar7 = kon.även;
            fragaSvar.Svar8 = kon.även;

            return fragaSvar;
        }

        // KONJUNKTION - MEDELSVÅRA FRÅGOR
        
        // 1 subjunktion eller inte, konjunktion
        public FragaSvar KonjunktionSubjunktion(konjunktion kon)
        {
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Ordet '" + kon.ord + "' är en konjunktion men är det även en subjunktion (ja/nej)?";

            if (kon.underordnad == true)
            {
                fragaSvar.Svar1 = "ja";
                fragaSvar.Svar2 = "ja";
                fragaSvar.Svar3 = "ja";
                fragaSvar.Svar4 = "ja";
                fragaSvar.Svar5 = "ja";
                fragaSvar.Svar6 = "ja";
                fragaSvar.Svar7 = "ja";
                fragaSvar.Svar8 = "ja";
            }
            else
            {
                fragaSvar.Svar1 = "nej";
                fragaSvar.Svar2 = "nej";
                fragaSvar.Svar3 = "nej";
                fragaSvar.Svar4 = "nej";
                fragaSvar.Svar5 = "nej";
                fragaSvar.Svar6 = "nej";
                fragaSvar.Svar7 = "nej";
                fragaSvar.Svar8 = "nej";
            }

            return fragaSvar;
        }

        // RÄKNEORD - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, räkneord
        public FragaSvar RakneordVilkenOrdklass(räkneord rak)
        {
            //var randomRakneord = db.GetRandomRakneord();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + rak.ord + "'?";
            fragaSvar.Svar1 = rak.ordklass;
            fragaSvar.Svar2 = rak.även;
            fragaSvar.Svar3 = rak.även;
            fragaSvar.Svar4 = rak.även;
            fragaSvar.Svar5 = rak.även;
            fragaSvar.Svar6 = rak.även;
            fragaSvar.Svar7 = rak.även;
            fragaSvar.Svar8 = rak.även;

            return fragaSvar;
        }

        // 2 vad blir ordet som grundtal, räkneord
        public FragaSvar RakneordGrundtal(räkneord rak)
        {
            //var randomRakneord = db.GetRandomRakneord();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir räkneordet '" + rak.ordningstal_ej_maskulinum + "' som grundtal?";
            fragaSvar.Svar1 = rak.grundtal;
            fragaSvar.Svar2 = rak.grundtal_2;
            fragaSvar.Svar3 = rak.grundtal_2;
            fragaSvar.Svar4 = rak.grundtal_2;
            fragaSvar.Svar5 = rak.grundtal_2;
            fragaSvar.Svar6 = rak.grundtal_2;
            fragaSvar.Svar7 = rak.grundtal_2;
            fragaSvar.Svar8 = rak.grundtal_2;

            return fragaSvar;
        }

        // 3 vad blir ordet som ordningstal ej maskulinum, räkneord
        public FragaSvar RakneordOrdningstal(räkneord rak)
        {
            //var randomRakneord = db.GetRandomRakneord();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vad blir räkneordet '" + rak.grundtal + "' som ordningstal (ej maskulinum)?";
            fragaSvar.Svar1 = rak.ordningstal_ej_maskulinum;
            fragaSvar.Svar2 = rak.ordningstal_ej_maskulinum;
            fragaSvar.Svar3 = rak.ordningstal_ej_maskulinum;
            fragaSvar.Svar4 = rak.ordningstal_ej_maskulinum;
            fragaSvar.Svar5 = rak.ordningstal_ej_maskulinum;
            fragaSvar.Svar6 = rak.ordningstal_ej_maskulinum;
            fragaSvar.Svar7 = rak.ordningstal_ej_maskulinum;
            fragaSvar.Svar8 = rak.ordningstal_ej_maskulinum;

            return fragaSvar;
        }

        // INTERJEKTION - LÄTTA FRÅGOR

        // 1 vilken ordklass tillhör ordet, interjektion
        public FragaSvar InterjektionVilkenOrdklass(interjektion intj)
        {
            //var randomInterjektion = db.GetRandomInterjektion();
            fragaSvar = new FragaSvar();

            fragaSvar.Fraga = "Vilken ordklass tillhör ordet '" + intj.ord + "'?";
            fragaSvar.Svar1 = intj.ordklass;
            fragaSvar.Svar2 = intj.även;
            fragaSvar.Svar3 = intj.även;
            fragaSvar.Svar4 = intj.även;
            fragaSvar.Svar5 = intj.även;
            fragaSvar.Svar6 = intj.även;
            fragaSvar.Svar7 = intj.även;
            fragaSvar.Svar8 = intj.även;

            return fragaSvar;
        }
    }
}