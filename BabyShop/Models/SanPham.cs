//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BabyShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.ChiTietDonDatHangs = new HashSet<ChiTietDonDatHang>();
        }
    
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string HinhURL { get; set; }
        public Nullable<int> GiaSanPham { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
        public Nullable<int> SoLuongBan { get; set; }
        public Nullable<int> SoLuocXem { get; set; }
        public string MoTa { get; set; }
        public Nullable<int> BiXoa { get; set; }
        public Nullable<int> MaLoaiSanPham { get; set; }
        public Nullable<int> MaHangSanXuat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
        public virtual HangSanXuat HangSanXuat { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
    }
}