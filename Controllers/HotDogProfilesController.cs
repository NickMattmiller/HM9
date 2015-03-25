using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentExample.Models;

namespace StudentExample.Controllers
{
    public class HotDogProfilesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HotDogProfiles
        public ActionResult Index()
        {
            return View(db.HotDogProfiles.ToList());
        }

        // GET: HotDogProfiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HotDogProfile hotDogProfile = db.HotDogProfiles.Find(id);
            if (hotDogProfile == null)
            {
                return HttpNotFound();
            }
            return View(hotDogProfile);
        }

        // GET: HotDogProfiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HotDogProfiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Pic,Name,Bio,Favorite_Meat,Favorite_Bun")] HotDogProfile hotDogProfile)
        {
            if (ModelState.IsValid)
            {
                db.HotDogProfiles.Add(hotDogProfile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hotDogProfile);
        }

        // GET: HotDogProfiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HotDogProfile hotDogProfile = db.HotDogProfiles.Find(id);
            if (hotDogProfile == null)
            {
                return HttpNotFound();
            }
            return View(hotDogProfile);
        }

        // POST: HotDogProfiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Pic,Name,Bio,Favorite_Meat,Favorite_Bun")] HotDogProfile hotDogProfile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hotDogProfile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hotDogProfile);
        }

        // GET: HotDogProfiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HotDogProfile hotDogProfile = db.HotDogProfiles.Find(id);
            if (hotDogProfile == null)
            {
                return HttpNotFound();
            }
            return View(hotDogProfile);
        }

        // POST: HotDogProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HotDogProfile hotDogProfile = db.HotDogProfiles.Find(id);
            db.HotDogProfiles.Remove(hotDogProfile);
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
