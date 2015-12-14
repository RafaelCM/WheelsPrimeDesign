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
    public class VehicleExtrasController : Controller
    {
        private WheelsprimeDBContext db = new WheelsprimeDBContext();

        // GET: VehicleExtras
        public ActionResult Index()
        {
            return View(db.VehicleExtra.ToList());
        }

        // GET: VehicleExtras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleExtra vehicleExtra = db.VehicleExtra.Find(id);
            if (vehicleExtra == null)
            {
                return HttpNotFound();
            }
            return View(vehicleExtra);
        }

        // GET: VehicleExtras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleExtras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] VehicleExtra vehicleExtra)
        {
            if (ModelState.IsValid)
            {
                db.VehicleExtra.Add(vehicleExtra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vehicleExtra);
        }

        // GET: VehicleExtras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleExtra vehicleExtra = db.VehicleExtra.Find(id);
            if (vehicleExtra == null)
            {
                return HttpNotFound();
            }
            return View(vehicleExtra);
        }

        // POST: VehicleExtras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] VehicleExtra vehicleExtra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicleExtra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicleExtra);
        }

        // GET: VehicleExtras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleExtra vehicleExtra = db.VehicleExtra.Find(id);
            if (vehicleExtra == null)
            {
                return HttpNotFound();
            }
            return View(vehicleExtra);
        }

        // POST: VehicleExtras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VehicleExtra vehicleExtra = db.VehicleExtra.Find(id);
            db.VehicleExtra.Remove(vehicleExtra);
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
