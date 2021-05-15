using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MumbaiMallLibrary;
using System.Data.Entity;

namespace MallAdmin.Controllers
{
    public class MovieAdminController : Controller
    {
        // GET: MovieAdmin/Index
        public ActionResult Index()
        {
            using(malldbEntities dbEntities = new malldbEntities())
            {
                  return View(dbEntities.Movies.ToList());
            }
            
        }

        // GET: MovieAdmin/Details/5
        public ActionResult Details(int id)
        {
            using(malldbEntities dbEntities = new malldbEntities())
            {
                return View( dbEntities.Movies.Where(x => x.Id == id).FirstOrDefault());
            }
            
        }

        // GET: MovieAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieAdmin/Create
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            try
            {
                using (malldbEntities dbEntities = new malldbEntities())
                {
                    dbEntities.Movies.Add(movie);
                    dbEntities.SaveChanges();
                }

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
            using (malldbEntities dbEntities = new malldbEntities())
            {
                return View(dbEntities.Movies.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: MovieAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Movie movie)
        {
            try
            {
                using(malldbEntities dbEntities = new malldbEntities())
                {
                    dbEntities.Entry(movie).State = EntityState.Modified;
                    dbEntities.SaveChanges();
                   
                }
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
            using (malldbEntities dbEntities = new malldbEntities())
            {
                return View(dbEntities.Movies.Where(x => x.Id == id).FirstOrDefault());
            }
            
        }

        // POST: MovieAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using(malldbEntities dbEntities = new malldbEntities())
                {
                    Movie movie = dbEntities.Movies.Where(x => x.Id == id).FirstOrDefault();
                    dbEntities.Movies.Remove(movie);
                    dbEntities.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
