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
    public class HerbDetailsController : Controller
    {
        private HerbDBContext db = new HerbDBContext();

        // GET: HerbDetails
        public ActionResult Index()
        {
            return View(db.HerbDetails.ToList());
        }

        // GET: HerbDetails/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HerbDetail herbDetail = db.HerbDetails.Find(id);
            if (herbDetail == null)
            {
                return HttpNotFound();
            }
            return View(herbDetail);
        }

        // GET: HerbDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HerbDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "detailID,herbName,properties,help,warning,researchName,research,author")] HerbDetail herbDetail)
        {
            if (ModelState.IsValid)
            {
                db.HerbDetails.Add(herbDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(herbDetail);
        }

        // GET: HerbDetails/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HerbDetail herbDetail = db.HerbDetails.Find(id);
            if (herbDetail == null)
            {
                return HttpNotFound();
            }
            return View(herbDetail);
        }

        // POST: HerbDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "detailID,herbName,properties,help,warning,researchName,research,author")] HerbDetail herbDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(herbDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(herbDetail);
        }

        // GET: HerbDetails/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HerbDetail herbDetail = db.HerbDetails.Find(id);
            if (herbDetail == null)
            {
                return HttpNotFound();
            }
            return View(herbDetail);
        }

        // POST: HerbDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HerbDetail herbDetail = db.HerbDetails.Find(id);
            db.HerbDetails.Remove(herbDetail);
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
