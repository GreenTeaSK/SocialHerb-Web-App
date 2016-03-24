using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppHerb.Models;

namespace WebAppHerb.Controllers
{
    public class InfographicController : Controller
    {
        private WebAppHerbDBContext db = new WebAppHerbDBContext();

        // GET: /Infographic/
        public ActionResult Index()
        {
            return View(db.Infographics.ToList());
        }

        // GET: /Infographic/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Infographic infographic = db.Infographics.Find(id);
            if (infographic == null)
            {
                return HttpNotFound();
            }
            return View(infographic);
        }

        // GET: /Infographic/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Infographic/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="infographicID,infographicName,InfographicReference,infographicImage")] Infographic infographic)
        {
            if (ModelState.IsValid)
            {
                db.Infographics.Add(infographic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(infographic);
        }

        // GET: /Infographic/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Infographic infographic = db.Infographics.Find(id);
            if (infographic == null)
            {
                return HttpNotFound();
            }
            return View(infographic);
        }

        // POST: /Infographic/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="infographicID,infographicName,InfographicReference,infographicImage")] Infographic infographic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(infographic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(infographic);
        }

        // GET: /Infographic/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Infographic infographic = db.Infographics.Find(id);
            if (infographic == null)
            {
                return HttpNotFound();
            }
            return View(infographic);
        }

        // POST: /Infographic/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Infographic infographic = db.Infographics.Find(id);
            db.Infographics.Remove(infographic);
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
