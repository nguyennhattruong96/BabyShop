using BabyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BabyShop.ViewModels
{
    public class SanPhamGioHangViewModel
    {
        public SanPham sanPham { get; set; }
        public int  soLuong { get; set; }

        public SanPhamGioHangViewModel(SanPham sp)
        {
            sanPham = sp;
            soLuong = 1;
        }

        public SanPhamGioHangViewModel(SanPham sp, int sl)
        {
            sanPham = sp;
            soLuong = sl;
        }

        public void ThemMot()
        {
            soLuong++;
        }
    }

    public class GioHangViewModel
    {
        public List<SanPhamGioHangViewModel> lstSanPhamGioHang { get; set; }
        
        public  GioHangViewModel()
        {
            lstSanPhamGioHang = new List<SanPhamGioHangViewModel>();
        }

        public void Add(SanPham sp)
        {
            if (lstSanPhamGioHang.Count == 0)
            {
                lstSanPhamGioHang.Add(new SanPhamGioHangViewModel(sp));
            }
            else
            {
                //Gio hang da co san pham 
                foreach(SanPhamGioHangViewModel item in lstSanPhamGioHang)
                {
                    if(item.sanPham.MaSanPham == sp.MaSanPham)
                    {
                        item.ThemMot();
                        return;
                    }
                }

                lstSanPhamGioHang.Add(new SanPhamGioHangViewModel(sp));
            }
        }

        public void Delete(SanPham sp)
        {
            foreach(SanPhamGioHangViewModel item in lstSanPhamGioHang)
            {
                if(item.sanPham.MaSanPham == sp.MaSanPham)
                {
                    lstSanPhamGioHang.Remove(item);
                    return;
                }
            }
        }

        public void Delete(int MaSanPham)
        {
            foreach (SanPhamGioHangViewModel item in lstSanPhamGioHang)
            {
                if (item.sanPham.MaSanPham == MaSanPham)
                {
                    lstSanPhamGioHang.Remove(item);
                    return;
                }
            }
        }

        public void DeleteAll()
        {
            lstSanPhamGioHang.RemoveAll(sp => true);
        }
    }
}