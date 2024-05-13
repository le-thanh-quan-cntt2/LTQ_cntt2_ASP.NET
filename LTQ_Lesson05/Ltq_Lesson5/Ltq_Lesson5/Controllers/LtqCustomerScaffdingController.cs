using Ltq_Lesson5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ltq_Lesson5.Controllers
{
    public class LtqCustomerScaffdingController : Controller
    {
        //mocdata
        private static List<LtqCustomer> listCustomer = new List<LtqCustomer>()
        {
             new LtqCustomer()
            {
                CustomerId = 1,
                FirsName="Lê Thanh ",
                LastName="Quan",
                Address="K22CNTT2",
                YearOfBirth=2004
            },
               new LtqCustomer()
               {
                   CustomerId=2,
                   FirsName="Đàm Vĩnh ",
                   LastName="Trinh",
                   Address="CNTT2",
                   YearOfBirth=2022
               },
               new LtqCustomer()
               {
                   CustomerId=3,
                   FirsName="Đàm Vĩnh ",
                   LastName="Trinh 1",
                   Address="CNTT2",
                   YearOfBirth=2022
               },
               new LtqCustomer()
               {
                   CustomerId=3,
                   FirsName="Đàm Vĩnh ",
                   LastName="Trinh 2",
                   Address="CNTT2",
                   YearOfBirth=2022
               },
        };
        // GET: LtqCustomerScaffding
        //listCustomer
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult LtqCreate()
        {
            var model = new LtqCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult LtqCreate(LtqCustomer model)
        {
            //Thêm mới đối tượng vào danh savhs sữ liệu
            listCustomer.Add(model);
            //return View(model);
            // Chuyển về trang danh sách
            return RedirectToAction("Index");

        }
        public ActionResult LtqEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerId == id);
            return View(customer);

        }
    }
}