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
    public class ResearchController : Controller
    {
        private WebAppHerbDBContext db = new WebAppHerbDBContext();

        // GET: /Research/
        public ActionResult Index()
        {
            return View(db.Researchs.ToList());
        }

        // GET: /Research/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Research research = db.Researchs.Find(id);
            if (research == null)
            {
                return HttpNotFound();
            }
            return View(research);
        }

        // GET: /Research/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Research/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="researchID,researchName,researchLink,herbID")] Research research)
        {
            if (ModelState.IsValid)
            {
                db.Researchs.Add(research);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(research);
        }

        // GET: /Research/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Research research = db.Researchs.Find(id);
            if (research == null)
            {
                return HttpNotFound();
            }
            return View(research);
        }

        // POST: /Research/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="researchID,researchName,researchLink,herbID")] Research research)
        {
            if (ModelState.IsValid)
            {
                db.Entry(research).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(research);
        }

        // GET: /Research/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Research research = db.Researchs.Find(id);
            if (research == null)
            {
                return HttpNotFound();
            }
            return View(research);
        }

        // POST: /Research/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Research research = db.Researchs.Find(id);
            db.Researchs.Remove(research);
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
