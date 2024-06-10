using Lesson8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson8.Controllers
{
    public class TddCategoryController : Controller
    {
        private static TddBookStore _TddBookStore;
        public TddCategoryController()
        {
            _TddBookStore = new TddBookStore();
        }
        // GET: TddCategory
        public ActionResult TddIndex()
        {
            var tddCategory = _TddBookStore.TddCategories.ToList();
            return View(tddCategory);
        }
        [HttpGet]
        public ActionResult TddCreate()
        {
            var tddCategory = new TddCategory();
            return View(tddCategory);
        }
        [HttpPost]
        public ActionResult TddCreate(TddCategory tddCategory)
        {
            _TddBookStore.TddCategories.Add(tddCategory);
            _TddBookStore.SaveChanges();
            return RedirectToAction("TddIndex");
        }
    }
}