using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Stomatologia.Models;
using Microsoft.AspNet.Identity;

namespace Stomatologia.Controllers
{
    public class WizytyController : Controller
    {
        private DatabaseModel db = new DatabaseModel();

        // GET: Wizyty
        public ActionResult Index()
        {
            return View(db.Wizyty.ToList());
        }

        // GET: Wizyty/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wizyta wizyta = db.Wizyty.Find(id);
            if (wizyta == null)
            {
                return HttpNotFound();
            }
            return View(wizyta);
        }

        // GET: Wizyty/Create
        public ActionResult Create()
        {
            var wizyta = new Wizyta
            {
                PacjentId = User.Identity.GetUserId()
            };

            var lekarze = db.Lekarze.ToList();
            ViewBag.Lekarze = new SelectList(lekarze, "Id", "FullName");
            return View(wizyta);
        }

        // POST: Wizyty/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Wizyta wizyta)
        {
            if (ModelState.IsValid)
            {
                db.Wizyty.Add(wizyta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            var lekarze = db.Lekarze.ToList();
            ViewBag.Lekarze = new SelectList(lekarze, "Id", "FullName");
            return View(wizyta);
        }

        // GET: Wizyty/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wizyta wizyta = db.Wizyty.Find(id);
            if (wizyta == null)
            {
                return HttpNotFound();
            }
            return View(wizyta);
        }

        // POST: Wizyty/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,LekarzId,PacjentId,Data,Hour")] Wizyta wizyta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wizyta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wizyta);
        }

        // GET: Wizyty/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wizyta wizyta = db.Wizyty.Find(id);
            if (wizyta == null)
            {
                return HttpNotFound();
            }
            return View(wizyta);
        }

        // POST: Wizyty/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Wizyta wizyta = db.Wizyty.Find(id);
            db.Wizyty.Remove(wizyta);
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
