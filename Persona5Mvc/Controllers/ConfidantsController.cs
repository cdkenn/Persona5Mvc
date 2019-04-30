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
    public class ConfidantsController : Controller
    {
        private Persona5DbContext db = new Persona5DbContext();

        // GET: Confidants
        public ActionResult Index()
        {
            return View(db.Confidants.ToList());
        }

        // GET: Confidants/Details/5
        public ActionResult Details(string arcana)
        {
            if (string.IsNullOrEmpty(arcana))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // search by the arcana (fool, chariot, etc)
            Confidant confidant = db.Confidants.First(i => i.Arcana.ToLower() == arcana.ToLower());
            if (confidant == null)
            {
                return HttpNotFound();
            }
            return View(confidant);
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
