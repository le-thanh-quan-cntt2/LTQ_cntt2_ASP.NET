using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQ_LessonOnline.Controllers
{
    /// <summary>
    /// Author:Lê Thanh Quan
    /// Class: CNTT2
    /// </summary>
    public class LTQStudentController : Controller
    {
        // GET: LTQStudent
        public ActionResult Index()
        {
            //  Truyền dữ liệu từ controller->View
            ViewBag.fullName = "Lê Thanh Quan";
            ViewData["Birthday"] = "05/04/2004";
            TempData["Phone"] = "0357695529";
            return View();
        }
        public ActionResult Details()
        {
            string ltqStr = "";
            ltqStr += "<h3>Họ và tền:Lê Thanh Quan</h3>";
            ltqStr += "<p>Mã số :2210900057";
            ltqStr += "<p> Địa chỉ mail:quanlekrn01@gmail.com";

            ViewBag.Details =ltqStr;

            return View("chiTiet");
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "Lê Thanh Quan", "Lê Văn b", "Phạm Văn c", "Mai Văn D" };
            ViewBag.names = names;
            return View();
        }
        //HTMLHelper
        //GET:LTQStuden/AddNewStudent
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form )
        {
            //Lấy dữ liệu trên form
            string fullname = form["fullName"];
            string masv = form["masv"];
            string taikhoan = form["taikhoan"];
            string Matkhau = form["Matkhau"];

            string ltqStr = "<h3>" + fullname + "</h3>";
             ltqStr += "<p>" + masv;
             ltqStr += "<p>" + taikhoan;
             ltqStr += "<p>" + Matkhau;
            ViewBag.info = ltqStr;
            return View("Ketqua");
        }

    }
}