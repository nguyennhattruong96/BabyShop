using BabyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BabyShop.Controllers
{
    public class SanPhamController : Controller
    {
        BabyShopEntities db = new BabyShopEntities();

        public ActionResult HienThiSanPhamTheoHang(int id)
        {
            List<SanPham> listSanPhamTheoHang = db.SanPhams.Where(s => s.BiXoa == 0 && s.MaHangSanXuat == id).ToList<SanPham>();
            HangSanXuat Hang = db.HangSanXuats.Single(l => l.MaHangSanXuat == id);
            ViewBag.TieuDe = "Danh sách sản phẩm theo Hãng " + Hang.TenHangSanXuat;
            return View("DanhSachSanPham",listSanPhamTheoHang);
        }

        public ActionResult HienThiSanPhamTheoLoai(int id)
        {
            List<SanPham> listSanPhamTheoLoai = db.SanPhams.Where(s => s.BiXoa == 0 && s.MaLoaiSanPham == id).ToList<SanPham>();
            LoaiSanPham Loai = db.LoaiSanPhams.Single(l => l.MaLoaiSanPham == id);
            ViewBag.TieuDe = "Danh sách sản phẩm theo Loại " + Loai.TenLoaiSanPham;
            return View("DanhSachSanPham", listSanPhamTheoLoai);
        }


        [ChildActionOnly]
        public ActionResult LogoHangSanXuat()
        {
            List<HangSanXuat> listLogoHangSanXuat = db.HangSanXuats.Where(s => s.BiXoa == 0).ToList<HangSanXuat>();
            return PartialView(listLogoHangSanXuat);
        }
        public ActionResult ChiTiet(int id)
        {
            SanPham sp = db.SanPhams.Single(s => s.MaSanPham == id);
            return View(sp);
        }

        [ChildActionOnly]
        public ActionResult HienThiSanPhamHot()
        {
            List<SanPham> listSanPham = db.SanPhams.Where(s => s.BiXoa == 0).OrderByDescending(s => s.SoLuocXem).Take(5).ToList<SanPham>();
            ViewBag.GroupTitle = "Sản Phẩm hot";
            return PartialView("TemplateSanPham", listSanPham);
        }

        [ChildActionOnly]
        public ActionResult HienThiSanPhamBanChayNhat()
        {
            List<SanPham> listSanPham = db.SanPhams.Where(s => s.BiXoa == 0).OrderByDescending(s => s.SoLuongBan).Take(5).ToList<SanPham>();
            ViewBag.GroupTitle = "Sản Phẩm Bán Chạy Nhất";
            return PartialView("TemplateSanPham", listSanPham);
        }

        [ChildActionOnly]
        public ActionResult HienThiSanPhamMoiNhat()
        {
            List<SanPham> listSanPham = db.SanPhams.Where(s => s.BiXoa == 0).OrderByDescending(s => s.NgayNhap).Take(5).ToList<SanPham>();
            ViewBag.GroupTitle = "Sản Phẩm Mới Nhất ";
            return PartialView("TemplateSanPham", listSanPham);
        }
    }
}