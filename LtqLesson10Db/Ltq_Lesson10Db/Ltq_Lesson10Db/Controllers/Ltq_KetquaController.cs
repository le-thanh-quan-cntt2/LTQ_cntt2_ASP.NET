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
    public class Ltq_KetquaController : Controller
    {
        private LtqCNTT2_Lesson10DbEntities db = new LtqCNTT2_Lesson10DbEntities();

        // GET: Ltq_Ketqua
        public ActionResult LtqIndex()
        {
            var ltq_Ketqua = db.Ltq_Ketqua.Include(l => l.Ltq_Monhoc).Include(l => l.Ltq_SinhVien);
            return View(ltq_Ketqua.ToList());
        }

        // GET: Ltq_Ketqua/Details/5
        public ActionResult LtqDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ltq_Ketqua ltq_Ketqua = db.Ltq_Ketqua.Find(id);
            if (ltq_Ketqua == null)
            {
                return HttpNotFound();
            }
            return View(ltq_Ketqua);
        }

        // GET: Ltq_Ketqua/Create
        public ActionResult LtqCreate()
        {
            ViewBag.LtqMaMH = new SelectList(db.Ltq_Monhoc, "LtqMaMH", "LtqTenMH");
            ViewBag.LtqMaSV = new SelectList(db.Ltq_SinhVien, "LtqMaSV", "LtqHoSV");
            return View();
        }

        // POST: Ltq_Ketqua/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LtqCreate([Bind(Include = "LtqMaSV,LtqMaMH,LtqDiem")] Ltq_Ketqua ltq_Ketqua)
        {
            if (ModelState.IsValid)
            {
                db.Ltq_Ketqua.Add(ltq_Ketqua);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LtqMaMH = new SelectList(db.Ltq_Monhoc, "LtqMaMH", "LtqTenMH", ltq_Ketqua.LtqMaMH);
            ViewBag.LtqMaSV = new SelectList(db.Ltq_SinhVien, "LtqMaSV", "LtqHoSV", ltq_Ketqua.LtqMaSV);
            return View(ltq_Ketqua);
        }

        // GET: Ltq_Ketqua/Edit/5
        public ActionResult LtqEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ltq_Ketqua ltq_Ketqua = db.Ltq_Ketqua.Find(id);
            if (ltq_Ketqua == null)
            {
                return HttpNotFound();
            }
            ViewBag.LtqMaMH = new SelectList(db.Ltq_Monhoc, "LtqMaMH", "LtqTenMH", ltq_Ketqua.LtqMaMH);
            ViewBag.LtqMaSV = new SelectList(db.Ltq_SinhVien, "LtqMaSV", "LtqHoSV", ltq_Ketqua.LtqMaSV);
            return View(ltq_Ketqua);
        }

        // POST: Ltq_Ketqua/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LtqEdit([Bind(Include = "LtqMaSV,LtqMaMH,LtqDiem")] Ltq_Ketqua ltq_Ketqua)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ltq_Ketqua).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LtqMaMH = new SelectList(db.Ltq_Monhoc, "LtqMaMH", "LtqTenMH", ltq_Ketqua.LtqMaMH);
            ViewBag.LtqMaSV = new SelectList(db.Ltq_SinhVien, "LtqMaSV", "LtqHoSV", ltq_Ketqua.LtqMaSV);
            return View(ltq_Ketqua);
        }

        // GET: Ltq_Ketqua/Delete/5
        public ActionResult LtqDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ltq_Ketqua ltq_Ketqua = db.Ltq_Ketqua.Find(id);
            if (ltq_Ketqua == null)
            {
                return HttpNotFound();
            }
            return View(ltq_Ketqua);
        }

        // POST: Ltq_Ketqua/Delete/5
        [HttpPost, ActionName("LtqDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ltq_Ketqua ltq_Ketqua = db.Ltq_Ketqua.Find(id);
            db.Ltq_Ketqua.Remove(ltq_Ketqua);
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
