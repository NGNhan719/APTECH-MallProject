using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MumbaiMallLibrary;

namespace MallofMumbai.Controllers
{
    public class ServiceProvidersController : Controller
    {
        private malldbEntities db = new malldbEntities();

        // GET: ServiceProviders
        public ActionResult Index()
        {
            return View(db.ServiceProviders.ToList());
        }

        // GET: Shops
        public ActionResult Shop()
        {
            var shopCateList = db.ServiceCategories.ToList().FindAll(obj => obj.ParentId == 1).OrderBy(obj => obj.CategoryName).ToList();

            var shopList = db.ServiceProviders.ToList().FindAll(obj => obj.Services.ToList().Any(obj1 => obj1.ServiceCategory.ParentId == 1));

            if (Convert.ToInt32(Request["filter"]) != 0)
            {
                shopList = shopList.FindAll(obj => obj.Services.ToList().Any(obj1 => obj1.ServiceCategory.Id == Convert.ToInt32(Request["filter"])));
            }

            if (Request["sort"] == "desc")
            {
                shopList = shopList.OrderByDescending(obj => obj.Name).ToList();
            }
            else
            {
                shopList = shopList.OrderBy(obj => obj.Name).ToList();
            }


            ViewData["shopCateList"] = shopCateList;

            return View(shopList);
        }

        // GET: Dining
        public ActionResult FoodCourt()
        {
            var foodCateList = db.ServiceCategories.ToList().FindAll(obj => obj.ParentId == 2).OrderBy(obj => obj.CategoryName).ToList();

            var diningList = db.ServiceProviders.ToList().FindAll(obj => obj.Services.ToList().Any(obj1 => obj1.ServiceCategory.ParentId == 2));

            if (Convert.ToInt32(Request["filter"]) != 0)
            {
                diningList = diningList.FindAll(obj => obj.Services.ToList().Any(obj1 => obj1.ServiceCategory.Id == Convert.ToInt32(Request["filter"])));
            }

            if (Request["sort"] == "desc")
            {
                diningList = diningList.OrderByDescending(obj => obj.Name).ToList();
            }
            else
            {
                diningList = diningList.OrderBy(obj => obj.Name).ToList();
            }


            ViewData["foodCateList"] = foodCateList;

            return View(diningList);
        }

        // GET: Entertainment
        public ActionResult Showtime()
        {
            // Find only showtime from today
            //var showList = db.Movies.ToList()
            //                .FindAll(obj => obj.ShowTimes.ToList().Any(obj1 => obj1.Date.Value.DayOfYear == DateTime.Today.DayOfYear));

            var showList = db.ShowTimes.ToList()
                            .FindAll(obj => obj.Date.Value.DayOfYear == DateTime.Today.DayOfYear);

            return View(showList);
        }

        // GET: ServiceProviders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceProvider serviceProvider = db.ServiceProviders.Find(id);
            if (serviceProvider == null)
            {
                return HttpNotFound();
            }
            return View(serviceProvider);
        }

        // GET: ServiceProviders/Details/5
        public ActionResult ShopDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceProvider serviceProvider = db.ServiceProviders.Find(id);
            if (serviceProvider == null)
            {
                return HttpNotFound();
            }
            return View(serviceProvider);
        }

        // GET: ServiceProviders/Details/5
        public ActionResult FoodCourtDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceProvider serviceProvider = db.ServiceProviders.Find(id);
            if (serviceProvider == null)
            {
                return HttpNotFound();
            }
            return View(serviceProvider);
        }

        // GET: ServiceProviders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiceProviders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Floor,Tel,Description,Avatar,FromDay,ToDay,Opened,Closed")] ServiceProvider serviceProvider)
        {
            if (ModelState.IsValid)
            {
                db.ServiceProviders.Add(serviceProvider);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(serviceProvider);
        }

        // GET: ServiceProviders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceProvider serviceProvider = db.ServiceProviders.Find(id);
            if (serviceProvider == null)
            {
                return HttpNotFound();
            }
            return View(serviceProvider);
        }

        // POST: ServiceProviders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Floor,Tel,Description,Avatar,FromDay,ToDay,Opened,Closed")] ServiceProvider serviceProvider)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceProvider).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(serviceProvider);
        }

        // GET: ServiceProviders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceProvider serviceProvider = db.ServiceProviders.Find(id);
            if (serviceProvider == null)
            {
                return HttpNotFound();
            }
            return View(serviceProvider);
        }

        // POST: ServiceProviders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceProvider serviceProvider = db.ServiceProviders.Find(id);
            db.ServiceProviders.Remove(serviceProvider);
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
