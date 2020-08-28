using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CombineAgricultureFarm.Models;

namespace CombineAgricultureFarm.Controllers
{
    public class CropInformationController : Controller
    {
        Models.CombineAgricultureFarmEntities db = new CombineAgricultureFarmEntities();
        // GET: CropInformation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CropInfo()
        {
            return View(db.CropInformations.ToList());
        }

        [HttpGet]
        public ActionResult CropInfoCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CropInfoCreate([Bind(Include = "CropInfod,CropName,CropInformation1,CropMedicine,CropPicture")] CropInformation cropInformation)
        {
            if (ModelState.IsValid)
            {
                db.CropInformations.Add(cropInformation);
                db.SaveChanges();
                return RedirectToAction("CropInfo");
            }
            return View(cropInformation);
        }

        [HttpGet]
        public ActionResult CropInfoUpdate(int?id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CropInformation cropInformation = db.CropInformations.Find(id);
            if (cropInformation==null)
            {
                HttpNotFound();
            }
            return View(cropInformation);
        }

        [HttpPost]
        public ActionResult CropInfoUpdate([Bind(Include = "CropInfod,CropName,CropInformation1,CropMedicine,CropPicture")] CropInformation cropInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cropInformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("CropInfo");
            }
            return View(cropInformation);
        }

        [HttpGet]
        public ActionResult CropInfoDelete(int?id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropInformation cropInformation = db.CropInformations.Find(id);
            if (cropInformation == null)
            {
                return HttpNotFound();
            }
            return View(cropInformation);
        }

        [HttpPost]
        public ActionResult CropInfoDelete(int id)
        {
            CropInformation cropInformation = db.CropInformations.Find(id);
            db.CropInformations.Remove(cropInformation);
            db.SaveChanges();
            return RedirectToAction("CropInfo");
        }
        
    }
}