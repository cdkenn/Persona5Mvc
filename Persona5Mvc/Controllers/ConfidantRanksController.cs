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
        private ConfidantDBContext db = new ConfidantDBContext();

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

        // GET: ConfidantRanks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConfidantRanks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Level,PerkName,PerkDescription,PointsToLevel,Details")] ConfidantRank confidantRank)
        {
            if (ModelState.IsValid)
            {
                db.ConfidantRanks.Add(confidantRank);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(confidantRank);
        }

        // GET: ConfidantRanks/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: ConfidantRanks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Level,PerkName,PerkDescription,PointsToLevel,Details")] ConfidantRank confidantRank)
        {
            if (ModelState.IsValid)
            {
                db.Entry(confidantRank).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(confidantRank);
        }

        // GET: ConfidantRanks/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: ConfidantRanks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConfidantRank confidantRank = db.ConfidantRanks.Find(id);
            db.ConfidantRanks.Remove(confidantRank);
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
