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
    public class herbsController : Controller
    {
        private socialherbdbEntities1 db = new socialherbdbEntities1();

        // GET: herbs
        public ActionResult Index()
        {
            return View(db.herb.ToList());
        }

        // GET: herbs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            herb herb = db.herb.Find(id);
            if (herb == null)
            {
                return HttpNotFound();
            }
            return View(herb);
        }

        // GET: herbs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: herbs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HerbName,NameOther,HerbImg,Leaf,LeafImg,Trunk,TrunkImg,Root,RootImg,Crop,CropImg,Corm,CormImg,Flower,FlowerImg")] herb herb)
        {
            if (ModelState.IsValid)
            {
                db.herb.Add(herb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(herb);
        }

        // GET: herbs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            herb herb = db.herb.Find(id);
            if (herb == null)
            {
                return HttpNotFound();
            }
            return View(herb);
        }

        // POST: herbs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HerbName,NameOther,HerbImg,Leaf,LeafImg,Trunk,TrunkImg,Root,RootImg,Crop,CropImg,Corm,CormImg,Flower,FlowerImg")] herb herb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(herb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(herb);
        }

        // GET: herbs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            herb herb = db.herb.Find(id);
            if (herb == null)
            {
                return HttpNotFound();
            }
            return View(herb);
        }

        // POST: herbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            herb herb = db.herb.Find(id);
            db.herb.Remove(herb);
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
