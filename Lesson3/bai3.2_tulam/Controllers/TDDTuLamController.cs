using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai3._2_tulam.Models;
namespace bai3._2_tulam.Controllers
{
    public class TDDTuLamController : Controller
    {
        // GET: TDDTuLam
        public ActionResult FormRegister()
        {
            ViewBag.listLHDN = new List<LHDN>()
            {
                new LHDN(){ID="0",Name="-- Chọn Loại Hình Doanh Nghiệp --"},
                new LHDN(){ID="Đơn vị sự nghiệp nhà nước",Name="Đơn vị sự nghiệp nhà nước"},
                new LHDN(){ID="Doanh nghiệp cá nhân",Name="Doanh nghiệp cá nhân"},
                new LHDN(){ID="Doanh nghiệp tư nhân",Name="Doanh nghiệp tư nhân"},
                new LHDN(){ID="Công ty cổ phần",Name="Công ty cổ phần"},
                new LHDN(){ID="Công ty trách nhiệm hữu hạn",Name="Công ty trách nhiệm hữu hạn"},
            };
            return View();
        }
        public ActionResult Register()
        {
            TempData["TDVT"] = Request["txtTDVT"];
            TempData["LHDN"] = Request["txtLHDN"];
            TempData["SLNV"] = Request["txtSLNV"];
            TempData["DC"] = Request["txtDC"];
            TempData["NLH"] = Request["txtNLH"];
            TempData["SDT"] = Request["txtSDT"];
            TempData["SF"] = Request["txtSF"];
            TempData["Email"] = Request["txtEmail"];
            TempData["DCWS"] = Request["txtDCWS"];
            TempData["TDN"] = Request["txtTDN"];
            TempData["MK"] = Request["txtMK"];
            TempData["XNMK"] = Request["txtXNMK"];
            TempData["NTDT"] = Request["txtNTDT"];
            return View();
        }

    }
}