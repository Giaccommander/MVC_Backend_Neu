﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alpenstern_BackEnd_Neu.Models;

namespace Alpenstern_BackEnd_Neu.Controllers
{
    public class DruckansichtController : Controller
    {   
        // GET: Druckansicht
        public ActionResult Index(PersoenDatenVM pd, BuchungsIndexVM bi, GastAnfrageDetailsVM gad)
        {
          
            var vmd = new DruckansichtVM();
            using (var db = new alpensternEntities2())
            {


                var gastAnfrage = db.uf_GastAnfrageDetails(1, 1).ToList();
                //vmd.vorname =gastAnfrage[0].vorname;
                vmd.vorname = pd.vorname;
                vmd.nachname =pd.nachname;
                vmd.straße = pd.strasse;
                vmd.plz = pd.plz;
                vmd.Stadt =pd.stadt;
                vmd.GastId = pd.id;
                vmd.zimmerNummer = pd.zimmerNummer;
                vmd.KategorieBez = pd.katBezeichnung;
                vmd.datumVon = gad.datumVon;
                vmd.datumBis = gad.datumBis;
                vmd.naechte = gad.naechte;
                vmd.zimmerPreisGesamt = gad.zimmerPreisGesamt;




                
            }
                return View(vmd);
        }
    }
}