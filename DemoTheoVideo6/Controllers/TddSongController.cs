using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoTheoVideo6.Models;

namespace DemoTheoVideo6.Controllers
{
    public class TddSongController : Controller
    {
        private static List<TddSong> TddSongs = new List<TddSong>()
        {
            new TddSong{Id=2210900097,TddTitle="Trần Đăng Dương",TddAuthor="K22CNT2",TddArtist="Dương",TddYearRelaese=2024},
            new TddSong{Id=2210900096,TddTitle="Tạ Đình Thành Doanh",TddAuthor="K22CNT2",TddArtist="đẹp trai nhất lớp",TddYearRelaese=2024},
        };
        // GET: TddSong

        public ActionResult TddIndex()
        {
            return View(TddSongs);
        }
        //Get: TddCreate
        
        public ActionResult TddCreate()
        {
            var tddSong = new TddSong();
            
            return View(tddSong);
        }
        //Post: TddCreate
        [HttpPost]
        public ActionResult TddCreate(TddSong tddSong)
        {
            if (!ModelState.IsValid) //nếu có lỗi
            {
                return View(tddSong);
            }
            //nếu dữ liệu đúng
            TddSongs.Add(tddSong);
            return RedirectToAction("TddIndex"); 
        }
    }
}