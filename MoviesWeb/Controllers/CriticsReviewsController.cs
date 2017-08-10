using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MoviesWeb.Models;

namespace MoviesWeb.Controllers
{
    public class CriticsReviewsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CriticsReviews
        public ActionResult Index()
        {
            return View(db.CriticsReviews.ToList());
        }

        // GET: CriticsReviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CriticsReviews criticsReviews = db.CriticsReviews.Find(id);
            if (criticsReviews == null)
            {
                return HttpNotFound();
            }
            return View(criticsReviews);
        }

        // GET: CriticsReviews/Create
        public ActionResult Create()
        {
           // CriticsReviewsViewModel obj = new CriticsReviewsViewModel();
            //obj.MoviesList = MoviesSelectList();

            // List <Movies> movieList =  new List<Movies>();
            //List<SelectListItem> items = new List<SelectListItem>();
            // var model = new Movies();
            ApplicationDbContext db1 = new ApplicationDbContext();
            var model = new CriticsReviewsViewModel
            {
                //SelectedCode = 5, //Default value
                myList = db1.Movies.AsEnumerable().Select(x => new SelectListItem
                {
                    Value = x.ID.ToString(),
                    Text = x.MName
                })
            };

            return View(model);

            //return View(obj);
        }

        // POST: CriticsReviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReviewId,CriticName,Rating,SourceName,SourceURL,ShortReview,FullReview,MovieId")] CriticsReviews criticsReviews)
        {
            if (ModelState.IsValid)
            {
                db.CriticsReviews.Add(criticsReviews);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(criticsReviews);
        }

        // GET: CriticsReviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CriticsReviews criticsReviews = db.CriticsReviews.Find(id);
            if (criticsReviews == null)
            {
                return HttpNotFound();
            }
            return View(criticsReviews);
        }

        // POST: CriticsReviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReviewId,CriticName,Rating,SourceName,SourceURL,ShortReview,FullReview")] CriticsReviews criticsReviews)
        {
            if (ModelState.IsValid)
            {
                db.Entry(criticsReviews).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(criticsReviews);
        }

        // GET: CriticsReviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CriticsReviews criticsReviews = db.CriticsReviews.Find(id);
            if (criticsReviews == null)
            {
                return HttpNotFound();
            }
            return View(criticsReviews);
        }

        // POST: CriticsReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CriticsReviews criticsReviews = db.CriticsReviews.Find(id);
            db.CriticsReviews.Remove(criticsReviews);
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
