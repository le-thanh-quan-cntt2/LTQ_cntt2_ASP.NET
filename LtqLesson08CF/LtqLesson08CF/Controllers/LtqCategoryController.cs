using LtqLesson08CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LtqLesson08CF.Controllers
{
    public class LtqCategoryController : Controller
    {
        private static LtqBookStore _LtqBookstore;
        public LtqCategoryController()
        {
            _LtqBookstore = new LtqBookStore();
        }    
        // GET: LtqCategory
        public ActionResult LtqIndex()
        {
            var ltqCategory = _LtqBookstore.LtqCategories.ToList();
            return View(ltqCategory);
        }
        [HttpGet]
        public ActionResult LtqCreate()
        {
            var ltqCategory = new LtqCategory();
            return View();
        }
        [HttpPost]
        public ActionResult LtqCreate(LtqCategory ltqCategory)
        {
            _LtqBookstore.LtqCategories.Add(ltqCategory);
            _LtqBookstore.SaveChanges();
          
            return RedirectToAction("LtqIndex");
        }
    }
}