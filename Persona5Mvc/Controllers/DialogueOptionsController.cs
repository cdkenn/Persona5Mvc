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
        private Persona5DbContext db = new Persona5DbContext();

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
