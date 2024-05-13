﻿using Ltq_lap05._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ltq_lap05._1.Controllers
{
    public class LtqCustomerController : Controller
    {
        // GET: LtqCustomer
        public ActionResult Index()
        {
            return View();
        }
        // GET: /Customer/CustomerDetail (action trả về thông tin chi tiết 1 khách hàng cho view CustomerDetail
        public ActionResult CustomerDetail()
        {
            //tạo một đối tượng Customer ( nhớ using Lab04.Models vào nhé)
            var customer = new LtqCustomer()
            {
                CustomerId = "KH001",
                FullName = "Lê Thanh Quan",
                Address = "Hà Nội",
                Email = "quanlekrn01@gmail.com",
                Phone = "0357695529",
                Balance = 15200000
            };
            //cách 1 gán dữ liệu vào ViewBag để chuyển tới View
            //ViewBag.customer = cus;
            //return View();
            //có thể truyền dữ liệu qua đối tượng model để chuyển tới View
            return View(customer);
        }
        //GET /Product/CustomerList (action trả về danh sách khách hàng cho view CustomerList)
        public ActionResult LtqCustomerList()
        {
            //tạo một danh sách khách hàng
            List<LtqCustomer> listcustomer = new List<LtqCustomer>()
           {
              new LtqCustomer()
              {
                  CustomerId = "KH001",
                  FullName = "Lê Thanh Quan",
                  Address = "Hà Nội",
                  Email = "quanlekrn01@gmail.com",
                  Phone = "0357695529",
                  Balance = 15200000},
              new LtqCustomer()
              {
                  CustomerId = "KH002",
                  FullName = "Đỗ Thị Cúc",
                  Address = "Hà Nội",
                  Email = "cucdt@gmail.com",
                  Phone = "0986.767.444",Balance = 2200000},
              new LtqCustomer()
              {
                   CustomerId = "KH003",
                   FullName = "Nguyễn Tuấn Thắng",
                   Address = "Nam Định",
                   Email = "thangnt@gmail.com",
                   Phone = "0924.656.542",
                   Balance = 1200000},
              new LtqCustomer()
              {
                   CustomerId = "KH004",
                   FullName = "Lê Ngọc Hải",
                   Address = "Hà Nội",
                   Email = "hailn@gmail.com",
                   Phone = "0996.555.267",
                   Balance = 6200000 }
             };
            // gán dữ liệu vào ViewBag để chuyển qua View
            ViewBag.listcustomer = listcustomer;
            return View(listcustomer);
        }
    }
}