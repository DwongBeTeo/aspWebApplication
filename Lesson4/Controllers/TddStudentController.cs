using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson4.Controllers
{
    //Trần Đăng Dương
    //CNTT2
    public class TddStudentController : Controller
    {
        // GET: TddStudent
        public ActionResult Index()
        {
            //truyền dữ liệu từ controller đến view
            ViewBag.fullName = "Trần Đăng Dương";
            ViewData["birthday"] = "19/08/2004";
            TempData["Phone"] = "12345678910";
            return View();
        }
        public ActionResult Details()
        {
            string tddStr = "";
            tddStr += "<h3>Họ và tên: Trần Đăng Dương<h3/>";
            tddStr += "<p> Mã số:2210900097";
            tddStr += "<p> Địa chỉ email:duongdangtran54321@gmail.com";
            
            ViewBag.Details = tddStr;
            return View("chiTiet");
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "trần đăng dương", "nguyễn phi mạnh", "nguyễn quang nam", "phan văn hòa", "cao thanh đạt", "tạ đình thành doanh" };
            ViewBag.names = names;
            return View();
        }
        //HTML Helper
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form )
        {
            string fullname = form["fullName"];
            string masv = form["maSV"];
            string taikhoan = form["TaiKhoan"];
            string matkhau = form["MatKhau"];

            string tddStr = "<h3>" + fullname + "<h3/>";
            tddStr += "<p>" + masv;
            tddStr += "<p>" + taikhoan;
            tddStr += "<p>" + matkhau;

            ViewBag.info = tddStr;
            return View("Ketqua");
        }
    }
}