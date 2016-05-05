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
    public class herbdetailsController : Controller
    {
        private socialherbdbEntities1 db = new socialherbdbEntities1();

        // GET: herbdetails
        public ActionResult Index()
        {
            var herbdetail = db.herbdetail.Include(h => h.herb);
            return View(herbdetail.ToList());
        }

        // GET: herbdetails/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            herbdetail herbdetail = db.herbdetail.Find(id);
            if (herbdetail == null)
            {
                return HttpNotFound();
            }
            return View(herbdetail);
        }

        // GET: herbdetails/Create
        public ActionResult Create()
        {
            ViewBag.HerbName = new SelectList(db.herb, "HerbName", "NameOther");
            return View();
        }

        // POST: herbdetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DetailID,HerbName,Properties,Help,Warning,ResearchName,Research,Author,Link")] herbdetail herbdetail)
        {
            if (ModelState.IsValid)
            {
                db.herbdetail.Add(herbdetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HerbName = new SelectList(db.herb, "HerbName", "NameOther", herbdetail.HerbName);
            return View(herbdetail);
        }

        // GET: herbdetails/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            herbdetail herbdetail = db.herbdetail.Find(id);
            if (herbdetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.HerbName = new SelectList(db.herb, "HerbName", "NameOther", herbdetail.HerbName);
            return View(herbdetail);
        }

        // POST: herbdetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DetailID,HerbName,Properties,Help,Warning,ResearchName,Research,Author,Link")] herbdetail herbdetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(herbdetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HerbName = new SelectList(db.herb, "HerbName", "NameOther", herbdetail.HerbName);
            return View(herbdetail);
        }

        // GET: herbdetails/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            herbdetail herbdetail = db.herbdetail.Find(id);
            if (herbdetail == null)
            {
                return HttpNotFound();
            }
            return View(herbdetail);
        }

        // POST: herbdetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            herbdetail herbdetail = db.herbdetail.Find(id);
            db.herbdetail.Remove(herbdetail);
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
