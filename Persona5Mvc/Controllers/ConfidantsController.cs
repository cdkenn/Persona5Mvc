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
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Confidant confidant = db.Confidants.Find(id);
            if (confidant == null)
            {
                return HttpNotFound();
            }
            return View(confidant);
        }

        // GET: Confidants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Confidants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Arcana,Details,DateAvailable,DaysAvailable,TimeOfDayAvailable,Location")] Confidant confidant)
        {
            if (ModelState.IsValid)
            {
                db.Confidants.Add(confidant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(confidant);
        }

        // GET: Confidants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Confidant confidant = db.Confidants.Find(id);
            if (confidant == null)
            {
                return HttpNotFound();
            }
            return View(confidant);
        }

        // POST: Confidants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Arcana,Details,DateAvailable,DaysAvailable,TimeOfDayAvailable,Location")] Confidant confidant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(confidant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(confidant);
        }

        // GET: Confidants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Confidant confidant = db.Confidants.Find(id);
            if (confidant == null)
            {
                return HttpNotFound();
            }
            return View(confidant);
        }

        // POST: Confidants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Confidant confidant = db.Confidants.Find(id);
            db.Confidants.Remove(confidant);
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
