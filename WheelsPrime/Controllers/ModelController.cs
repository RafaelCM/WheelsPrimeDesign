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
    public class ModelController : Controller
    {
        private WheelsprimeDBContext db = new WheelsprimeDBContext();

        // GET: Models
        public ActionResult Index()
        {
            return View(db.Model.ToList());
        }

        // GET: Models/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Model model = db.Model.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        private void PopulateBrandDropDownList(object selectedBrand = null)
        {
            var brandlist = from b in db.Brand
                            orderby b.Name
                            select b;
            ViewBag.brand = new SelectList(brandlist, "ID", "Name", selectedBrand);
        }

        // GET: Models/Create
        public ActionResult Create()
        {
            PopulateBrandDropDownList();
            return View();
        }

        // POST: Models/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Model model, int? brand)
        {
            if (ModelState.IsValid && brand != null)
            {
                if (!String.IsNullOrWhiteSpace(model.Name))
                {
                    db.Model.Add(model);
                    var selectedbrand = db.Brand.FirstOrDefault(b => b.ID == brand);
                    selectedbrand.Model.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.modelnameerror = "Não foi colocado nome para o modelo";
                }
            }
            PopulateBrandDropDownList(model.Brand);
            return View(model);
        }

        // GET: Models/Create
        public ActionResult Create()
        {
            PopulateBrandDropDownList();
            return View();
        }

        // POST: Models/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Model model, int? brand)
        {
            if (ModelState.IsValid && brand != null)
            {
                if (!String.IsNullOrWhiteSpace(model.Name))
                {
                    db.Model.Add(model);
                    var selectedbrand = db.Brand.FirstOrDefault(b => b.ID == brand);
                    selectedbrand.Model.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.modelnameerror = "Não foi colocado nome para o modelo";
                }
            }
            PopulateBrandDropDownList(model.Brand);
            return View(model);
        }

        // GET: Models/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Model model = db.Model.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Models/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Model model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: Models/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Model model = db.Model.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: Models/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Model model = db.Model.Find(id);
            db.Model.Remove(model);
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
