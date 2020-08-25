using CombineAgricultureFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.UI.WebControls;

namespace CombineAgricultureFarm.Controllers
{
   
    public class ClientController : Controller
    {

        Models.CombineAgricultureFarmEntities db = new CombineAgricultureFarmEntities();
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp([Bind(Include = "ClientId,ClientName,ClientEmail,ClientMobile,ClientAddress,FurmName,UserName,Password,ClientType")] ClientInformation clientInformation)
        {
            if (ModelState.IsValid)
            {
                db.ClientInformations.Add(clientInformation);
                db.SaveChanges();
                return RedirectToAction("SignIn");
            }

            return View(clientInformation);
           
        }
        
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(String username, String password)
        {
            int er = 0;
            if (username == "")
            {
                er++;
                ViewBag.username = "Username required";
            }
            if (password == "")
            {
                er++;
                ViewBag.password = "Password required";
            }
            if (er > 0)
            {
                return View();
            }
            var logininfo = db.ClientInformations.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();
            if (logininfo != null)
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.message = "Login fail";
                return View(logininfo);
            }

            
        }
    }
}