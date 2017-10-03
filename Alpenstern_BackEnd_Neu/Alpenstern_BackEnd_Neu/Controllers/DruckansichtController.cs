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
        public ActionResult Index(PersonDatenVM vm, buchungIndexVM be)
        {
            using (var db = new alpensternEntities())
            {
                var rVM = new DruckAnsichtVM();
                var dbAnfrage = db.Anfrage.Find(be.radioAuswahl);
                var rFunktion = db.uf_GastAnfrageDetails(be.radioAuswahl, rVM.anfrageID);

                rVM.id = vm.id;
                rVM.vorname = vm.vorname;
                rVM.nachname = vm.nachname;
                rVM.strasse = vm.strasse;
                rVM.plz = vm.plz;
                rVM.stadt = vm.stadt;
                rVM.katBezeichnung = vm.katBezeichnung;
                rVM.kategorieID = vm.kategorieID;
                rVM.personenAnzahl = vm.personenAnzahl;

            return View(rVM);

            }
        }
    }
}