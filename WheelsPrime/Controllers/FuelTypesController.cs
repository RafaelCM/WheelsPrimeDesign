using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WheelsPrime.DAL;
using WheelsPrime.Models;

namespace WheelsPrime.Controllers
{
    public class FuelTypesController : Controller
    {
        private WheelsprimeDBContext db = new WheelsprimeDBContext();

        // GET: FuelTypes
        public ActionResult Index()
        {
            return View(db.FuelType.ToList());
        }

        // GET: FuelTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuelType fuelType = db.FuelType.Find(id);
            if (fuelType == null)
            {
                return HttpNotFound();
            }
            return View(fuelType);
        }

        // GET: FuelTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FuelTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Type")] FuelType fuelType)
        {
            if (ModelState.IsValid)
            {
                db.FuelType.Add(fuelType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fuelType);
        }

        // GET: FuelTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuelType fuelType = db.FuelType.Find(id);
            if (fuelType == null)
            {
                return HttpNotFound();
            }
            return View(fuelType);
        }

        // POST: FuelTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Type")] FuelType fuelType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fuelType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fuelType);
        }

        // GET: FuelTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuelType fuelType = db.FuelType.Find(id);
            if (fuelType == null)
            {
                return HttpNotFound();
            }
            return View(fuelType);
        }

        // POST: FuelTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FuelType fuelType = db.FuelType.Find(id);
            db.FuelType.Remove(fuelType);
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
