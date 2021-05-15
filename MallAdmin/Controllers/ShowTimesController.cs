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
    public class ShowTimesController : Controller
    {
        private malldbEntities db = new malldbEntities();

        // GET: ShowTimes
        public ActionResult Index()
        {
            var showTimes = db.ShowTimes.Include(s => s.Movie).Include(s => s.ScreenHall);
            return View(showTimes.ToList());
        }

        // GET: ShowTimes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowTime showTime = db.ShowTimes.Find(id);
            if (showTime == null)
            {
                return HttpNotFound();
            }
            return View(showTime);
        }

        // GET: ShowTimes/Create
        public ActionResult Create()
        {
            ViewBag.MovieId = new SelectList(db.Movies, "Id", "Name");
            ViewBag.ScreenId = new SelectList(db.ScreenHalls, "Id", "ScreenName");
            return View();
        }

        // POST: ShowTimes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date,StartHour,TotalTicket,MovieId,ScreenId")] ShowTime showTime)
        {
            if (ModelState.IsValid)
            {
                db.ShowTimes.Add(showTime);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MovieId = new SelectList(db.Movies, "Id", "Name", showTime.MovieId);
            ViewBag.ScreenId = new SelectList(db.ScreenHalls, "Id", "ScreenName", showTime.ScreenId);
            return View(showTime);
        }

        // GET: ShowTimes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowTime showTime = db.ShowTimes.Find(id);
            if (showTime == null)
            {
                return HttpNotFound();
            }
            ViewBag.MovieId = new SelectList(db.Movies, "Id", "Name", showTime.MovieId);
            ViewBag.ScreenId = new SelectList(db.ScreenHalls, "Id", "ScreenName", showTime.ScreenId);
            return View(showTime);
        }

        // POST: ShowTimes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Date,StartHour,TotalTicket,MovieId,ScreenId")] ShowTime showTime)
        {
            if (ModelState.IsValid)
            {
                db.Entry(showTime).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MovieId = new SelectList(db.Movies, "Id", "Name", showTime.MovieId);
            ViewBag.ScreenId = new SelectList(db.ScreenHalls, "Id", "ScreenName", showTime.ScreenId);
            return View(showTime);
        }

        // GET: ShowTimes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowTime showTime = db.ShowTimes.Find(id);
            if (showTime == null)
            {
                return HttpNotFound();
            }
            return View(showTime);
        }

        // POST: ShowTimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShowTime showTime = db.ShowTimes.Find(id);
            db.ShowTimes.Remove(showTime);
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
