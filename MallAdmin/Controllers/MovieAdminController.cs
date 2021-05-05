using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MallAdmin.Controllers
{
    public class MovieAdminController : Controller
    {
        // GET: MovieAdmin
        public ActionResult Index()
        {
            return View();
        }

        // GET: MovieAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieAdmin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
