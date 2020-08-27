using System;
using System.Collections.Generic;
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

    }
}