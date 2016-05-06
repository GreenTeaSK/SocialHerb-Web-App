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
    public class HerbsController : Controller
    {
        private HerbDBContext db = new HerbDBContext();

        // GET: Herbs
        public ActionResult Index()
        {
            return View(db.Herbs.ToList());
        }

        // GET: Herbs/Details/5
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

        // GET: Herbs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Herbs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "herbName,nameOther,herbImg,leafImg,leaf,trunkImg,trunk,rootImg,root,cropImg,crop,cormImg,corm,flowerImg,flower")] Herb herb)
        {
            if (ModelState.IsValid)
            {
                db.Herbs.Add(herb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(herb);
        }

        // GET: Herbs/Edit/5
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

        // POST: Herbs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "herbName,nameOther,herbImg,leafImg,leaf,trunkImg,trunk,rootImg,root,cropImg,crop,cormImg,corm,flowerImg,flower")] Herb herb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(herb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(herb);
        }

        // GET: Herbs/Delete/5
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

        // POST: Herbs/Delete/5
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
