using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace taibaihat.Controllers
{
    public class lethanhquanController : Controller
    {
        // GET: lethanhquan
        private List<Song> GetSongs()
        {
            return new List<Song>
            {
                new Song{ Id = 1 , FileName = "Co-Sao-Gio-Lai-Chia-Xa-Bich-Phuong.mp3" },
                new Song{ Id = 2 , FileName = "spotifydown.com - Vi-Nguoi-Khong-Xung-Dang-Tuan-Hung.mp3" },
                new Song{ Id = 3 , FileName = "spotifydown.com - Thiên Lý Ơi.mp3" },
                new Song{ Id = 4 , FileName = "spotifydown.com - Vo-Nguoi-Ta-Phan-Manh-Quynh.mp3" },
                new Song{ Id = 5 , FileName = "spotifydown.com - Yeu-Em-Rat-Nhieu-Hoang-Ton.mp3"},
                new Song{ Id = 6 , FileName = "spotifydown.com - Yeu-Nhau-Nua-Ngay-Phan-Manh-Quynh.mp3"}

            };
        }

        public ActionResult Index()
        {
            ViewBag.message = "Danh sách nhạc";
            return View();
        }

        // Action method để hiển thị danh sách bài hát
        public ActionResult ShowSongs()
        {
            List<Song> songs = GetSongs();
            return View(songs);
        }

        public ActionResult PreviewSong(int id)
        {
            Song song = GetSongs().FirstOrDefault(s => s.Id == id);
            return View(song);
        }

        // Action method để tải về một bài hát
        public ActionResult Download(int id)
        {
            // Lấy thông tin của bài hát theo Id
            Song song = GetSongs().FirstOrDefault(s => s.Id == id);

            if (song != null)
            {
                // Đường dẫn tới thư mục chứa các file bài hát
                string filePath = Server.MapPath("~/Content/Songs/" + song.FileName);

                // Trả về file để tải về
                return File(filePath, "audio/mpeg", song.FileName);
            }

            return View(song);
        }
    }
}