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
    public class HerbImageController : Controller
    {
        private WebAppHerbDBContext db = new WebAppHerbDBContext();

        // GET: /HerbImage/
        public ActionResult Index()
        {
            return View(db.HerbImages.ToList());
        }

        // GET: /HerbImage/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HerbImage herbimage = db.HerbImages.Find(id);
            if (herbimage == null)
            {
                return HttpNotFound();
            }
            return View(herbimage);
        }

        // GET: /HerbImage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /HerbImage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="herbImageID,herbID,shootTip,groundTissue,leaf,flower,seeds,root")] HerbImage herbimage)
        {
            if (ModelState.IsValid)
            {
                db.HerbImages.Add(herbimage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(herbimage);
        }

        // GET: /HerbImage/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HerbImage herbimage = db.HerbImages.Find(id);
            if (herbimage == null)
            {
                return HttpNotFound();
            }
            return View(herbimage);
        }

        // POST: /HerbImage/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="herbImageID,herbID,shootTip,groundTissue,leaf,flower,seeds,root")] HerbImage herbimage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(herbimage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(herbimage);
        }

        // GET: /HerbImage/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HerbImage herbimage = db.HerbImages.Find(id);
            if (herbimage == null)
            {
                return HttpNotFound();
            }
            return View(herbimage);
        }

        // POST: /HerbImage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HerbImage herbimage = db.HerbImages.Find(id);
            db.HerbImages.Remove(herbimage);
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
