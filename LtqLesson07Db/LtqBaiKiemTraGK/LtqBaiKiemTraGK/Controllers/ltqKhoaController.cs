using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LtqBaiKiemTraGK.Models;

namespace LtqBaiKiemTraGK.Controllers
{
    public class ltqKhoaController : Controller
    {
        private LtqCNTT2Lesson07DbEntities db = new LtqCNTT2Lesson07DbEntities();

        // GET: ltqKhoa
        public ActionResult Index()
        {
            return View(db.ltqKhoa.ToList());
        }

        // GET: ltqKhoa/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ltqKhoa ltqKhoa = db.ltqKhoa.Find(id);
            if (ltqKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ltqKhoa);
        }

        // GET: ltqKhoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ltqKhoa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LtqMaKH,LtqtenKH,LtqTrangThai")] ltqKhoa ltqKhoa)
        {
            if (ModelState.IsValid)
            {
                db.ltqKhoa.Add(ltqKhoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ltqKhoa);
        }

        // GET: ltqKhoa/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ltqKhoa ltqKhoa = db.ltqKhoa.Find(id);
            if (ltqKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ltqKhoa);
        }

        // POST: ltqKhoa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LtqMaKH,LtqtenKH,LtqTrangThai")] ltqKhoa ltqKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ltqKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ltqKhoa);
        }

        // GET: ltqKhoa/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ltqKhoa ltqKhoa = db.ltqKhoa.Find(id);
            if (ltqKhoa == null)
            {
                return HttpNotFound();
            }
            return View(ltqKhoa);
        }

        // POST: ltqKhoa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ltqKhoa ltqKhoa = db.ltqKhoa.Find(id);
            db.ltqKhoa.Remove(ltqKhoa);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
