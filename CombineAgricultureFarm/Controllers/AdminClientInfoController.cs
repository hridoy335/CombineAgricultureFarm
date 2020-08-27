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
    public class AdminClientInfoController : Controller
    {
        Models.CombineAgricultureFarmEntities db = new CombineAgricultureFarmEntities();

        // GET: AdminClientInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ClientInformation()
        {
            return View(db.ClientInformations.ToList());
        }

        [HttpGet]
        public ActionResult ClientInfoUpdate(int? id)
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

      [HttpPost]
      public ActionResult ClientInfoUpdate([Bind(Include = "ClientId,ClientName,ClientEmail,ClientMobile,ClientAddress,FurmName,UserName,Password,ClientType")] ClientInformation clientInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clientInformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ClientInformation");
            }
            return View(clientInformation);

        }


    }
}