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
    
    public partial class BoMon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BoMon()
        {
            this.ChuyenNganhs = new HashSet<ChuyenNganh>();
            this.GiaoViens = new HashSet<GiaoVien>();
        }
    
        public string Mabomon { get; set; }
        public string tenbomon { get; set; }
        public string Makhoa { get; set; }
    
        public virtual Khoa Khoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuyenNganh> ChuyenNganhs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien> GiaoViens { get; set; }
    }
}
