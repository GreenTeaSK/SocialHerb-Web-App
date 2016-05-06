using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SocialHerb.Models;

namespace SocialHerb.Controllers
{
    public class InfographicsController : Controller
    {
        private HerbDBContext db = new HerbDBContext();

        // GET: Infographics
        public ActionResult Index()
        {
            return View(db.Infographics.ToList());
        }

        // GET: Infographics/Details/5
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

        // GET: Infographics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Infographics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "infoID,infoName,InfoReference,infoImage")] Infographic infographic)
        {
            if (ModelState.IsValid)
            {
                db.Infographics.Add(infographic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(infographic);
        }

        // GET: Infographics/Edit/5
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

        // POST: Infographics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "infoID,infoName,InfoReference,infoImage")] Infographic infographic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(infographic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(infographic);
        }

        // GET: Infographics/Delete/5
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

        // POST: Infographics/Delete/5
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
