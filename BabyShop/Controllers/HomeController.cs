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

        public ActionResult SanPhamTop()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult HienThiThongTin()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult HienThiLienHe()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}