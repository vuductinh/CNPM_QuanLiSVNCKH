//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quan_li_sinh_vien_nghien_cuu_khoa_hoc
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuanliTH
    {
        public string MaSV { get; set; }
        public string Madetai { get; set; }
        public string NDthuchien { get; set; }
        public string ketqua { get; set; }
        public string vaitro { get; set; }
    
        public virtual DetaiNCKH DetaiNCKH { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}
