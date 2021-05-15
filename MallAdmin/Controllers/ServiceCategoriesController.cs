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
    public class ServiceCategoriesController : Controller
    {
        private malldbEntities db = new malldbEntities();

        // GET: ServiceCategories
        public ActionResult Index()
        {
            var categoryList = db.ServiceCategories.ToList();

            return View(categoryList);
        }

        // GET: ServiceCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceCategory serviceCategory = db.ServiceCategories.Find(id);
            if (serviceCategory == null)
            {
                return HttpNotFound();
            }

            return View(serviceCategory);
        }

        // GET: ServiceCategories/Create
        public ActionResult Create()
        {
            ViewBag.SubCategories = db.ServiceCategories.ToList().FindAll(obj => obj.ParentId == 0 || obj.ParentId == null);

            return View();
        }

        // POST: ServiceCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CategoryName,ParentId")] ServiceCategory serviceCategory)
        {
            if (ModelState.IsValid)
            {
                db.ServiceCategories.Add(serviceCategory);
                db.SaveChanges();
                return View("_success");
            }

            ViewBag.SubCategories = db.ServiceCategories.ToList().FindAll(obj => obj.ParentId == 0 || obj.ParentId == null);

            return View(serviceCategory);
        }

        // GET: ServiceCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceCategory serviceCategory = db.ServiceCategories.Find(id);
            if (serviceCategory == null)
            {
                return HttpNotFound();
            }

            ViewBag.SubCategories = db.ServiceCategories.ToList().FindAll(obj => obj.ParentId == 0 || obj.ParentId == null);

            return View(serviceCategory);
        }

        // POST: ServiceCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CategoryName,ParentId")] ServiceCategory serviceCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceCategory).State = EntityState.Modified;
                db.SaveChanges();
                return View("_success");
            }

            ViewBag.SubCategories = db.ServiceCategories.ToList().FindAll(obj => obj.ParentId == 0 || obj.ParentId == null);

            return View(serviceCategory);
        }

        // GET: ServiceCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceCategory serviceCategory = db.ServiceCategories.Find(id);
            if (serviceCategory == null)
            {
                return HttpNotFound();
            }
            return View(serviceCategory);
        }

        // POST: ServiceCategories/Delete/5
        [HttpPost]
        //, ActionName("Delete")
        //[ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceCategory serviceCategory = db.ServiceCategories.Find(id);
            db.ServiceCategories.Remove(serviceCategory);
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
