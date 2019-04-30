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
    public class ConfidantRankDialoguesController : Controller
    {
        private Persona5DbContext db = new Persona5DbContext();

        // GET: ConfidantRankDialogues
        public ActionResult Index()
        {
            return View(db.ConfidantRankDialogues.ToList());
        }

        // GET: ConfidantRankDialogues/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConfidantRankDialogue confidantRankDialogue = db.ConfidantRankDialogues.Find(id);
            if (confidantRankDialogue == null)
            {
                return HttpNotFound();
            }
            return View(confidantRankDialogue);
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
