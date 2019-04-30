﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Persona5Mvc.Models;

namespace Persona5Mvc.Controllers
{
    public class ConfidantRanksController : Controller
    {
        private Persona5DbContext db = new Persona5DbContext();

        // GET: ConfidantRanks
        public ActionResult Index()
        {
            return View(db.ConfidantRanks.ToList());
        }

        // GET: ConfidantRanks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConfidantRank confidantRank = db.ConfidantRanks.Find(id);
            if (confidantRank == null)
            {
                return HttpNotFound();
            }
            return View(confidantRank);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
