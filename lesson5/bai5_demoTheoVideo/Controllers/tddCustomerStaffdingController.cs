using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai5_demoTheoVideo.Models;

namespace bai5_demoTheoVideo.Controllers
{
    public class tddCustomerStaffdingController : Controller
    {
        //mockdata
        private static List<TDdCustomer> listCustomer = new List<TDdCustomer>()
            {
                    new TDdCustomer()
        {
            CustomerId = 1,
                    FirstName = "Trần Đăng",
                    LastName = "Dương",
                    Address = "K22CNT2",
                    YearOfBirth = 2004
                },
                    new TDdCustomer()
        {
            CustomerId = 2,
                    FirstName = "Tạ ĐÌnh Thành",
                    LastName = "Doanh",
                    Address = "Zai Đẹp Phòng 509",
                    YearOfBirth = 2004
                },
                    new TDdCustomer()
        {
            CustomerId = 3,
                    FirstName = "Nguyễn Quang ",
                    LastName = "Nam",
                    Address = "Máy Dập Hoài Đức",
                    YearOfBirth = 2004
                },
                    new TDdCustomer()
        {
            CustomerId = 4,
                    FirstName = "Phan Văn",
                    LastName = "Hòa",
                    Address = "Đẹp Trai Không Ai Sánh Bằng",
                    YearOfBirth = 2004
                },

            };
    // GET: tddCustomerStaffding
    //list customer
    public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult TddCreate()
        {
            var model = new TDdCustomer();
            return View(model);
        }
        public ActionResult TddCreate(TDdCustomer model)
        {
            //thêm mới đối tượng khách hàng vào danh sách dữ liệu
            listCustomer.Add(model);
            /*return View(model);*/
            return RedirectToAction("Index");
        }
    }
}