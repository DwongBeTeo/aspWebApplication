
using lesson2_bai2_tulam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson2_bai2_tulam.Controllers
{
    public class SongController : Controller
    {
        private static List<Song> songs = new List<Song>
        {
            new Song { Id = 1, Title = "Khóa Ly Biệt  Voi Bản Đôn", FilePath = "/Content/y2mate.com - Khóa Ly Biệt  Voi Bản Đôn  The Masked Singer Vietnam 2023 Audio Lyric.mp3" },
            new Song { Id = 2, Title = "Nơi Tình Yêu Bắt Đầu  Bùi Anh Tuấn", FilePath = "/Content/y2mate.com - Nơi Tình Yêu Bắt Đầu  Bùi Anh Tuấn  Lyrics Video.mp3" },
            new Song { Id = 3, Title = "Noo Phước Thịnh Cơn Mơ Băng Giá", FilePath = "/Content/y2mate.com - Noo Phước Thịnh COVER Cơn Mơ Băng Giá LIVE  Mây in the Nest.mp3" },
            new Song { Id = 4, Title = "Sau lời từ khước  Phan Mạnh Quỳnh", FilePath = "/Content/y2mate.com - Sau lời từ khước OST MAI  Phan Mạnh Quỳnh  Lyrics video.mp3" },
            new Song { Id = 5, Title = "Tệ Thật Anh Nhớ Em  Thanh Hưng", FilePath = "/Content/y2mate.com - Tệ Thật Anh Nhớ Em  Thanh Hưng  Official Lyric Video.mp3" }
        };
        
        public ActionResult Index()
        {
            return View(songs);
        }
        public ActionResult Detail(int id)
        {
            var song = songs.Find(s => s.Id == id);
            return View(song);
        }

        public ActionResult Download(int id)
        {
            var song = songs.Find(s => s.Id == id);
            if (song != null)
            {
                return File(song.FilePath, "audio/mpeg", song.Title + ".mp3");
            }
            return HttpNotFound();
        }
    }
}
