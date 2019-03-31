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
    public class DialogueOptionsController : Controller
    {
        private ConfidantDBContext db = new ConfidantDBContext();

        // GET: DialogueOptions
        public ActionResult Index()
        {
            return View(db.DialogueOptions.ToList());
        }

        // GET: DialogueOptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DialogueOption dialogueOption = db.DialogueOptions.Find(id);
            if (dialogueOption == null)
            {
                return HttpNotFound();
            }
            return View(dialogueOption);
        }

        // GET: DialogueOptions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DialogueOptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,OptionText,PointsGiven")] DialogueOption dialogueOption)
        {
            if (ModelState.IsValid)
            {
                db.DialogueOptions.Add(dialogueOption);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dialogueOption);
        }

        // GET: DialogueOptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DialogueOption dialogueOption = db.DialogueOptions.Find(id);
            if (dialogueOption == null)
            {
                return HttpNotFound();
            }
            return View(dialogueOption);
        }

        // POST: DialogueOptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,OptionText,PointsGiven")] DialogueOption dialogueOption)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dialogueOption).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dialogueOption);
        }

        // GET: DialogueOptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DialogueOption dialogueOption = db.DialogueOptions.Find(id);
            if (dialogueOption == null)
            {
                return HttpNotFound();
            }
            return View(dialogueOption);
        }

        // POST: DialogueOptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DialogueOption dialogueOption = db.DialogueOptions.Find(id);
            db.DialogueOptions.Remove(dialogueOption);
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
