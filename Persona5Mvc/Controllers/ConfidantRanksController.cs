using System;
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
        public ActionResult Details(string arcana, int? level)
        {
            if (level == null || string.IsNullOrEmpty(arcana))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // first fetch the Confidant, then the rank from that
            Confidant confidant = db.Confidants.First(c => c.Arcana.ToLower() == arcana.ToLower());
            if (confidant == null)
            {
                return HttpNotFound();
            }

            ConfidantRank confidantRank = confidant.Ranks.First(cR => cR.Level == level);
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
