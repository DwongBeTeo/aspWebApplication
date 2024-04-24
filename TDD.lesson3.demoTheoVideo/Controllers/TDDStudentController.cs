using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDD.lesson3.demoTheoVideo.Controllers
{
    public class TDDStudentController : Controller
    {
        // GET: TDDStudent
        public ActionResult Index()
        {
            //dữ liệu từ viewdata
            ViewData["msg"]= "View Data - tran dang duong";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }
        public ActionResult StudentList()
        {
            //sử dụng viewbag
            //lưu trữ giá trị đơn
            ViewBag.titleName = "danh sach hoc vien - tran dang duong";
            //giá trị là một tập hợp
            string[] names = { "phi manh", "quang nam", "thanh doanh", "dang duong", "phan hoa" };
            ViewBag.list = names;
            // giá trị là một đối tượng
            var obj = new
            {
                ID = 100,
                Name = "duong duong",
                Age = 20
            };
            ViewBag.student = obj;

            return View();
        }
        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}