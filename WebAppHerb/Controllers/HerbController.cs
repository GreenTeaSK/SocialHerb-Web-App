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
    public class HerbController : Controller
    {
        private WebAppHerbDBContext db = new WebAppHerbDBContext();

        // GET: /Herb/
        public ActionResult Index()
        {
            return View(db.Herbs.ToList());
        }

        // GET: /Herb/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Herb herb = db.Herbs.Find(id);
            if (herb == null)
            {
                return HttpNotFound();
            }
            return View(herb);
        }

        // GET: /Herb/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Herb/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="herbID,herbName,herbDetail,herbProperties,herbHowto,herbDirect,herbImage")] Herb herb)
        {
            if (ModelState.IsValid)
            {
                    db.Herbs.Add(herb);
                    db.SaveChanges();
                    return RedirectToAction("Index");    
            }

            return View(herb);
        }

        // GET: /Herb/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Herb herb = db.Herbs.Find(id);
            if (herb == null)
            {
                return HttpNotFound();
            }
            return View(herb);
        }

        // POST: /Herb/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="herbID,herbName,herbDetail,herbProperties,herbHowto,herbDirect,herbImage")] Herb herb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(herb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(herb);
        }

        // GET: /Herb/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Herb herb = db.Herbs.Find(id);
            if (herb == null)
            {
                return HttpNotFound();
            }
            return View(herb);
        }

        // POST: /Herb/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Herb herb = db.Herbs.Find(id);
            db.Herbs.Remove(herb);
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
