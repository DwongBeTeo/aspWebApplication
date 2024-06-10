using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tdd_baithigiuaky.Models;

namespace Tdd_baithigiuaky.Controllers
{
    public class TddCustomerController : Controller
    {
        private static List<TddCustomer> List = new List<TddCustomer>()
        {
            new TddCustomer{TddId=2210900097,TddFullName="Trần Đăng Dương",TddEmail="Duong@gmail.com",TddPhone=1234567890,TddAge=20,TddGender=0},
            new TddCustomer{TddId=2210900096,TddFullName="Tạ Đình Thành Doanh",TddEmail="Doanh@gmail.com",TddPhone=1234567891,TddAge=19,TddGender=1},
        };
        // GET: TddCustomer
        public ActionResult Index()
        {
            return View(List);
        }
        //Get: TddCreate
        public ActionResult TddCreate()
        {
            var tddCustomer = new TddCustomer();

            return View(tddCustomer);
        }
        //Post: TddCreate
        [HttpPost]
        public ActionResult TddCreate(TddCustomer tddCustomer)
        {
            if (!ModelState.IsValid) //nếu có lỗi
            {
                return View(tddCustomer);
            }
            //nếu dữ liệu đúng
            List.Add(tddCustomer);
            return RedirectToAction("List");
        }

    }
}