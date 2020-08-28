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
    public class FarmInfoController : Controller
    {
        Models.CombineAgricultureFarmEntities db = new CombineAgricultureFarmEntities();
        // GET: FarmInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FarmType()
        {
            return View(db.FarmingTypes.ToList());
        }

        [HttpGet]
        public ActionResult FarmTypeCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FarmTypeCreate([Bind(Include = "FarmingTypeId,FarmingTyeName")] FarmingType farmingType)
        {
            if (ModelState.IsValid)
            {
                db.FarmingTypes.Add(farmingType);
                db.SaveChanges();
                return RedirectToAction("FarmType");

            }
            return View(farmingType);
        }

        [HttpGet] 
        public ActionResult FarmTypeUpdated(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FarmingType farmingType = db.FarmingTypes.Find(id);
            if (farmingType == null)
            {
                return HttpNotFound();
            }
            return View(farmingType);
        }

        [HttpPost]
        public ActionResult FarmTypeUpdated([Bind(Include = "FarmingTypeId,FarmingTyeName")] FarmingType farmingType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(farmingType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("FarmType");
            }
            return View(farmingType);
        }

        [HttpGet]
        public ActionResult FarmTypeDelete(int?id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FarmingType farmingType = db.FarmingTypes.Find(id);
            if (farmingType == null)
            {
                return HttpNotFound();
            }
            return View(farmingType);
        }


        [HttpPost]
        public ActionResult FarmTypeDelete(int id)
        {
           // ClientInformation clientInformation = db.ClientInformations.Find(id);
            FarmingType farmingType = db.FarmingTypes.Find(id);
            db.FarmingTypes.Remove(farmingType);
            db.SaveChanges();
            return RedirectToAction("FarmType");
        }

        // End farmtype 

        // Start farm session

        public ActionResult FarmSessiontype()
        {
            return View(db.FarmingSessionInfoes.ToList());
        }

        [HttpGet]
        public ActionResult FarmingSessionCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FarmingSessionCreate([Bind(Include = "SessionInfoId,SessionInfoName")] FarmingSessionInfo farmingSessionInfo)
        {
            if (ModelState.IsValid)
            {
                db.FarmingSessionInfoes.Add(farmingSessionInfo);
                db.SaveChanges();
                return RedirectToAction("FarmSessiontype");
            }

            return View(farmingSessionInfo);
        }

        [HttpGet]
        public ActionResult FarmingSessionUpdate(int?id) 
        {
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            FarmingSessionInfo farmingSessionInfo = db.FarmingSessionInfoes.Find(id);
            if (farmingSessionInfo==null)
            {
                return HttpNotFound();
            }

            return View(farmingSessionInfo);
        }

        [HttpPost]
        public ActionResult FarmingSessionUpdate([Bind(Include = "SessionInfoId,SessionInfoName")] FarmingSessionInfo farmingSessionInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(farmingSessionInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("FarmSessiontype");
            }
            return View(farmingSessionInfo);
        }

        [HttpGet]
        public ActionResult FarmingSessionDelete(int?id)
        {
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FarmingSessionInfo farmingSessionInfo = db.FarmingSessionInfoes.Find(id);
            if (farmingSessionInfo == null)
            {
                return HttpNotFound();
            }

            return View(farmingSessionInfo);
        }

        [HttpPost]
        public ActionResult FarmingSessionDelete(int id)
        {
            FarmingSessionInfo farmingSessionInfo = db.FarmingSessionInfoes.Find(id);
            db.FarmingSessionInfoes.Remove(farmingSessionInfo);
            db.SaveChanges();
            return RedirectToAction("FarmSessiontype");
        }


    }
}