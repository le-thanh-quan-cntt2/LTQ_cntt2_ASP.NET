using Ltq_Lesson5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ltq_Lesson5.Controllers
{
    public class LtqCustomerController : Controller
    {
        // GET: LtqCustomer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LtqCustomerDetail()
        {
            //Tạo đối tượng dữ liệu 
            var customer = new LtqCustomer()
            {
                CustomerId = 1,
                FirsName="Lê Thanh Quan",
                LastName="Quan",
                Address="K22CNTT2",
                YearOfBirth=2004
            };
            ViewBag.customer = customer;
            return View();

        }
        // GET: LtqListCustomer
        public ActionResult LtqListCustomer()
        {
            var list = new List<LtqCustomer>()
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
            //ViewBag.list = list;// Đưa đối tượng ra view bằng viewBag

            return View(list);


        }
    }
}