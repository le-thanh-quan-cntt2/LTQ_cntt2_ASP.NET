using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQ_BTTL3._2.Controllers
{
    public class LTQ_Controller : Controller
    {
        // GET: LTQ_
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FormRegister()
        {
            ViewBag.listType = new List<LTQ_BTTL>(){
                new LTQ_BTTL(){ID = "0", Name = "--Chọn loại hình doanh nghiệp--" },
                new LTQ_BTTL(){ID = "Đơn vị sử nghiệp nhà nước", Name = "Đơn vị sử nghiệp nhà nước"},
                new LTQ_BTTL(){ID = "Doanh nghiệp cá nhân", Name = "Doanh nghiệp cá nhân" },
                new LTQ_BTTL(){ID = "Doanh nghiệp hợp danh", Name = "Doanh nghiệp hợp danh"},
                new LTQ_BTTL(){ID = "Công ty cổ phần", Name = "Công ty cổ phần"},
                new LTQ_BTTL(){ID = "Công ty hợp danh có trách nhiệm hữu hạn", Name = "Công ty hợp danh có trách nhiệm hữu hạn"}
            };
            return View();
        }
        public ActionResult Register()
        {
            TempData["DVT"] = Request["txtDVT"];
            TempData["LHDN"] = Request["LHDN"];
            TempData["SL"] = Request["txtSL"];
            TempData["Address"] = Request["txtAddress"];
            TempData["LH"] = Request["txtLH"];
            TempData["SDT"] = Request["txtSDT"];
            TempData["FAX"] = Request["txtFAX"];
            TempData["Email"] = Request["txtEmail"];
            TempData["Website"] = Request["txtWebsite"];
            TempData["UserName"] = Request["txtUserName"];
            TempData["Password"] = Request["txtPassword"];
            TempData["RPassword"] = Request["txtRPassword"];
            TempData["Receive"] = Request["btnReceive"];
            return View();
        }
    }
}