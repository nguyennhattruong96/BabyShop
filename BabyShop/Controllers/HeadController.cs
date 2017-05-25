using BabyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BabyShop.Controllers
{
    public class HeadController : Controller
    {
        BabyShopEntities db = new BabyShopEntities ();
        // GET: Head
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult getMenu()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult getSearch()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public ActionResult getCart()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public ActionResult getLogin()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult ShowMenuLoai()
        {
            List <LoaiSanPham> list = db.LoaiSanPhams.ToList<LoaiSanPham>();
            return PartialView(list);
        }

        [ChildActionOnly]
        public ActionResult ShowMenuHang()
        {
            List<HangSanXuat> list = db.HangSanXuats.ToList<HangSanXuat>();
            return PartialView(list);
        }
    }
}