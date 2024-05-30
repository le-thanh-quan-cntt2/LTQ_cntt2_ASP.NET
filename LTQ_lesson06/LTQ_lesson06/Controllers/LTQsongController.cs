using LTQ_lesson06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQ_lesson06.Controllers
{
    public class LTQsongController : Controller
    {
        public static List<LTQsong> TDTDSongs = new List<LTQsong>()
         {
            new LTQsong{ ID = 221090005,LTQTitle = "Lê Thanh Quan", LTQAuthor = "CNTT2" , LTQArtist = "Quan", LTQYearRelease = 2020},
            new LTQsong{ ID =  22109000,LTQTitle = "Nguyễn Văn A", LTQAuthor = "CNTT2",LTQArtist = "A", LTQYearRelease = 2021},
        };
        // GET: LTQsong
        public ActionResult LTQIndex()
        {
            return View();
        }
        public ActionResult LTQCreate()
        {
            var ltqsong = new LTQsong();
            return View(ltqsong);
        }
        [HttpPost]
        public ActionResult LTQCreate(LTQsong lTQSong)
        {
            if (!ModelState.IsValid) // Nếu có lỗi
                return View(lTQsong);
            }
        // Nếu dữ liệu đúng
            ltqSongs.Add(lTQsong;
            return RedirectToAction("LTQIndex");
        }
    }
}