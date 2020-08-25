using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CombineAgricultureFarm.Models;

namespace CombineAgricultureFarm.Controllers
{
    public class ClientInformationsController : Controller
    {
        private CombineAgricultureFarmEntities db = new CombineAgricultureFarmEntities();

        // GET: ClientInformations
        public ActionResult Index()
        {
            return View(db.ClientInformations.ToList());
        }

        // GET: ClientInformations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientInformation clientInformation = db.ClientInformations.Find(id);
            if (clientInformation == null)
            {
                return HttpNotFound();
            }
            return View(clientInformation);
        }

        // GET: ClientInformations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientInformations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClientId,ClientName,ClientEmail,ClientMobile,ClientAddress,FurmName,UserName,Password")] ClientInformation clientInformation)
        {
            if (ModelState.IsValid)
            {
                db.ClientInformations.Add(clientInformation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clientInformation);
        }

        // GET: ClientInformations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientInformation clientInformation = db.ClientInformations.Find(id);
            if (clientInformation == null)
            {
                return HttpNotFound();
            }
            return View(clientInformation);
        }

        // POST: ClientInformations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClientId,ClientName,ClientEmail,ClientMobile,ClientAddress,FurmName,UserName,Password")] ClientInformation clientInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clientInformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clientInformation);
        }

        // GET: ClientInformations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientInformation clientInformation = db.ClientInformations.Find(id);
            if (clientInformation == null)
            {
                return HttpNotFound();
            }
            return View(clientInformation);
        }

        // POST: ClientInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClientInformation clientInformation = db.ClientInformations.Find(id);
            db.ClientInformations.Remove(clientInformation);
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
