using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lesson8.Models;

namespace Lesson8.Controllers
{
    public class TddBooksController : Controller
    {
        private TddBookStore db = new TddBookStore();

        // GET: TddBooks
        public ActionResult TddIndex()
        {
            var tddBooks = db.TddBooks.Include(t => t.TddCategory);
            return View(tddBooks.ToList());
        }

        // GET: TddBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TddBook tddBook = db.TddBooks.Find(id);
            if (tddBook == null)
            {
                return HttpNotFound();
            }
            return View(tddBook);
        }

        // GET: TddBooks/Create
        public ActionResult Create()
        {
            ViewBag.TddCategoryId = new SelectList(db.TddCategories, "TddCategoryId", "TddCategoryId");
            return View();
        }

        // POST: TddBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TddBookId,TddTitle,TddAuthor,TddYear,TddPublisher,TddPicture,TddCategoryId")] TddBook tddBook)
        {
            if (ModelState.IsValid)
            {
                db.TddBooks.Add(tddBook);
                db.SaveChanges();
                return RedirectToAction("TddIndex");
            }

            ViewBag.TddCategoryId = new SelectList(db.TddCategories, "TddCategoryId", "TddCategoryId", tddBook.TddCategoryId);
            return View(tddBook);
        }

        // GET: TddBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TddBook tddBook = db.TddBooks.Find(id);
            if (tddBook == null)
            {
                return HttpNotFound();
            }
            ViewBag.TddCategoryId = new SelectList(db.TddCategories, "TddCategoryId", "TddCategoryId", tddBook.TddCategoryId);
            return View(tddBook);
        }

        // POST: TddBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TddBookId,TddTitle,TddAuthor,TddYear,TddPublisher,TddPicture,TddCategoryId")] TddBook tddBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tddBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TddIndex");
            }
            ViewBag.TddCategoryId = new SelectList(db.TddCategories, "TddCategoryId", "TddCategoryId", tddBook.TddCategoryId);
            return View(tddBook);
        }

        // GET: TddBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TddBook tddBook = db.TddBooks.Find(id);
            if (tddBook == null)
            {
                return HttpNotFound();
            }
            return View(tddBook);
        }

        // POST: TddBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TddBook tddBook = db.TddBooks.Find(id);
            db.TddBooks.Remove(tddBook);
            db.SaveChanges();
            return RedirectToAction("TddIndex");
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
