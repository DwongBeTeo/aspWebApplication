using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai5_demoTheoVideo.Models;

namespace bai5_demoTheoVideo.Controllers
{
    public class TDdCustomerController : Controller
    {
        // GET: TDdCustomer
        public ActionResult Index()
        {
            return View();
        }
        //Action: TDdCustomerDetail
        public ActionResult TDdCustomerDetail()
        {
            //tạo đối tượng dữ liệu
            var Customer = new TDdCustomer()
            {
                CustomerId = 1,
                FirstName = "Trần Đăng",
                LastName = "Dương",
                Address = "K22CNT2",
                YearOfBirth = 2004
            };
            ViewBag.customer = Customer;
            return View();
        }
        //GET: TDdListCustomer
        public ActionResult TDdListCustomer()
        {
            var list = new List<TDdCustomer>()
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
            ViewBag.list = list; //đưa dữ liệu ra view bằng đối tượng viewbag
            return View();
        }
    }
}