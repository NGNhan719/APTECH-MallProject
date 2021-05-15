using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MumbaiMallLibrary;

namespace MallAdmin.Controllers
{
    public class ScreenHallsController : Controller
    {
        private malldbEntities db = new malldbEntities();

        // GET: ScreenHalls
        public ActionResult Index()
        {
            var screenHalls = db.ScreenHalls.Include(s => s.ServiceProvider);
            return View(screenHalls.ToList());
        }

        // GET: ScreenHalls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScreenHall screenHall = db.ScreenHalls.Find(id);
            if (screenHall == null)
            {
                return HttpNotFound();
            }
            return View(screenHall);
        }

        // GET: ScreenHalls/Create
        public ActionResult Create()
        {
            ViewBag.ServiceProviderId = new SelectList(db.ServiceProviders, "Id", "Name");
            return View();
        }

        // POST: ScreenHalls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ScreenName,SeatQty,ServiceProviderId,Avatar,FromDay,ToDay,Opened,Closed")] ScreenHall screenHall)
        {
            if (ModelState.IsValid)
            {
                db.ScreenHalls.Add(screenHall);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ServiceProviderId = new SelectList(db.ServiceProviders, "Id", "Name", screenHall.ServiceProviderId);
            return View(screenHall);
        }

        // GET: ScreenHalls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScreenHall screenHall = db.ScreenHalls.Find(id);
            if (screenHall == null)
            {
                return HttpNotFound();
            }
            ViewBag.ServiceProviderId = new SelectList(db.ServiceProviders, "Id", "Name", screenHall.ServiceProviderId);
            return View(screenHall);
        }

        // POST: ScreenHalls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ScreenName,SeatQty,ServiceProviderId,Avatar,FromDay,ToDay,Opened,Closed")] ScreenHall screenHall)
        {
            if (ModelState.IsValid)
            {
                db.Entry(screenHall).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ServiceProviderId = new SelectList(db.ServiceProviders, "Id", "Name", screenHall.ServiceProviderId);
            return View(screenHall);
        }

        // GET: ScreenHalls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScreenHall screenHall = db.ScreenHalls.Find(id);
            if (screenHall == null)
            {
                return HttpNotFound();
            }
            return View(screenHall);
        }

        // POST: ScreenHalls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ScreenHall screenHall = db.ScreenHalls.Find(id);
            db.ScreenHalls.Remove(screenHall);
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
