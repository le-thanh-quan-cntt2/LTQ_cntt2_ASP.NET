using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab05._1.Controllers
{
    public class LTQMemberController : Controller
    {
        // GET: LTQMember
        public ActionResult Index()
        {
            return View();
        }
        // GET: /Member/CreateOne

        public ActionResult CreateOne()

        {
            return View();
        }

        //POST: /Member/CreateOne

        [HttpPost]
        public ActionResult CreateOne(Member m)
        {
            // chuyến dữ liệu nhận được tới View Details
            return View("Details", m);

        }

        //POST:/Member/CreateTwo
        public ActionResult CreateTow()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTwo(Member m)
        {
            //kiểm tra trống các trường và thông báo lỗi tới VIEW

            if (m.Id == null)

            {
                ViewBag.error error = "Hãy nhập mã số";
                return View();

            }

            if (m.Username == null)

            {

                ViewBag.error = "Hãy nhập tên đăng nhập";
                return View();
            }

            if (m.FullName == null)

            {

                ViewBag.error = "Hãy nhập tên họ và tên";
                return View();
            }
            if (m.Age == null)
            {
                ViewBag.error = "Hãy nhập tuổi";
                return View();

            }
            if (m.Email == null)
            {
                ViewBag.error = "Hãy nhâp Email";
                return View();

            }
            //mẫu kiểm tra Email

            string regexPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4)";

            if
             (!System.Text.RegularExpressions.IsMatch(m.Email, regexPatter))
            {
                ViewBag.error = "Hãy nhập đúng định dạng";

                return View();

            }
            // nếu không xảy ra lỗi thì chuyền dữ liệu tới View Details

            return View("Details", m);

        }

        //GET: /Member/CreateThree
        [HttpPost]
        public ActionResult CreateThree(Member m)

        {
            //Nếu trạng thái dữ liệu của Model hợp lệ thì chuyển dữ liệu tới View Detalls 
            if (ModelState.IsValid)
                return View("Details", m);
            else
                return View(); // quay lại view Three để báo lỗi
        }
        //GET:/Member/Details
        public ActionResult Details()
        {
            return View();
        }

    }
}