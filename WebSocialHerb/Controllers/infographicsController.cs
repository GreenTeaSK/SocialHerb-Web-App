using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebSocialHerb.Models;

namespace WebSocialHerb.Controllers
{
    public class infographicsController : Controller
    {
        private socialherbdbEntities1 db = new socialherbdbEntities1();

        // GET: infographics
        public ActionResult Index()
        {
            return View(db.infographic.ToList());
        }

        // GET: infographics/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            infographic infographic = db.infographic.Find(id);
            if (infographic == null)
            {
                return HttpNotFound();
            }
            return View(infographic);
        }

        // GET: infographics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: infographics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InfoID,InfoName,InfoReferene,InfoImage")] infographic infographic)
        {
            if (ModelState.IsValid)
            {
                db.infographic.Add(infographic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(infographic);
        }

        // GET: infographics/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            infographic infographic = db.infographic.Find(id);
            if (infographic == null)
            {
                return HttpNotFound();
            }
            return View(infographic);
        }

        // POST: infographics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InfoID,InfoName,InfoReferene,InfoImage")] infographic infographic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(infographic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(infographic);
        }

        // GET: infographics/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            infographic infographic = db.infographic.Find(id);
            if (infographic == null)
            {
                return HttpNotFound();
            }
            return View(infographic);
        }

        // POST: infographics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            infographic infographic = db.infographic.Find(id);
            db.infographic.Remove(infographic);
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
