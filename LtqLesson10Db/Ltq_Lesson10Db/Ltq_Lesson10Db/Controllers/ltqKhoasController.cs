using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ltq_Lesson10Db.Models;

namespace Ltq_Lesson10Db.Controllers
{
    public class ltqKhoasController : Controller
    {
        private LtqCNTT2_Lesson10DbEntities db = new LtqCNTT2_Lesson10DbEntities();

        // GET: ltqKhoas
        public ActionResult Index()
        {
            return View(db.ltqKhoa.ToList());
        }

        // GET: ltqKhoas/Details/5
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

        // GET: ltqKhoas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ltqKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LtqMaKH,LtqTenKH")] ltqKhoa ltqKhoa)
        {
            if (ModelState.IsValid)
            {
                db.ltqKhoa.Add(ltqKhoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ltqKhoa);
        }

        // GET: ltqKhoas/Edit/5
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

        // POST: ltqKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LtqMaKH,LtqTenKH")] ltqKhoa ltqKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ltqKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ltqKhoa);
        }

        // GET: ltqKhoas/Delete/5
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

        // POST: ltqKhoas/Delete/5
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
