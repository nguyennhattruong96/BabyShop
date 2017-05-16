using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using BabyShop.Models;

namespace BabyShop.Controllers
{
    public class HomeController : Controller
    {
        BabyShopEntities db = new BabyShopEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            List<AspNetRole> role = db.AspNetRoles.ToList<AspNetRole>();
            role[0].AspNetUsers.Add()
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}