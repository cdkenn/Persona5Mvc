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
        private ConfidantDBContext db = new ConfidantDBContext();

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

        // GET: ConfidantRankDialogues/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConfidantRankDialogues/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TextBeforeOptions")] ConfidantRankDialogue confidantRankDialogue)
        {
            if (ModelState.IsValid)
            {
                db.ConfidantRankDialogues.Add(confidantRankDialogue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(confidantRankDialogue);
        }

        // GET: ConfidantRankDialogues/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: ConfidantRankDialogues/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TextBeforeOptions")] ConfidantRankDialogue confidantRankDialogue)
        {
            if (ModelState.IsValid)
            {
                db.Entry(confidantRankDialogue).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(confidantRankDialogue);
        }

        // GET: ConfidantRankDialogues/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: ConfidantRankDialogues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConfidantRankDialogue confidantRankDialogue = db.ConfidantRankDialogues.Find(id);
            db.ConfidantRankDialogues.Remove(confidantRankDialogue);
            db.SaveChanges();
            return RedirectToAction("Index");
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
