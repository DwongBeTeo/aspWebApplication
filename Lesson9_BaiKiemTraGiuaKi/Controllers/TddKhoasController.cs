using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lesson9_BaiKiemTraGiuaKi.Models;

namespace Lesson9_BaiKiemTraGiuaKi.Controllers
{
    public class TddKhoasController : Controller
    {
        private TddK22CNT2Lesson07DbEntities db = new TddK22CNT2Lesson07DbEntities();

        // GET: TddKhoas
        public ActionResult TddIndex()
        {
            return View(db.tddKhoas.ToList());
        }

        // GET: TddKhoas/TddDetails/5
        public ActionResult TddDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tddKhoa tddKhoa = db.tddKhoas.Find(id);
            if (tddKhoa == null)
            {
                return HttpNotFound();
            }
            return View(tddKhoa);
        }

        // GET: TddKhoas/TddCreate
        public ActionResult TddCreate()
        {
            return View();
        }

        // POST: TddKhoas/TddCreate
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more TddDetails see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TddCreate([Bind(Include = "TddMaKH,TddTenKH,TddTrangThai")] tddKhoa tddKhoa)
        {
            if (ModelState.IsValid)
            {
                db.tddKhoas.Add(tddKhoa);
                db.SaveChanges();
                return RedirectToAction("TddIndex");
            }

            return View(tddKhoa);
        }

        // GET: TddKhoas/TddEdit/5
        public ActionResult TddEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tddKhoa tddKhoa = db.tddKhoas.Find(id);
            if (tddKhoa == null)
            {
                return HttpNotFound();
            }
            return View(tddKhoa);
        }

        // POST: TddKhoas/TddEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more TddDetails see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TddEdit([Bind(Include = "TddMaKH,TddTenKH,TddTrangThai")] tddKhoa tddKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tddKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TddIndex");
            }
            return View(tddKhoa);
        }

        // GET: TddKhoas/TddDelete/5
        public ActionResult TddDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tddKhoa tddKhoa = db.tddKhoas.Find(id);
            if (tddKhoa == null)
            {
                return HttpNotFound();
            }
            return View(tddKhoa);
        }

        // POST: TddKhoas/TddDelete/5
        [HttpPost, ActionName("TddDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tddKhoa tddKhoa = db.tddKhoas.Find(id);
            db.tddKhoas.Remove(tddKhoa);
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
