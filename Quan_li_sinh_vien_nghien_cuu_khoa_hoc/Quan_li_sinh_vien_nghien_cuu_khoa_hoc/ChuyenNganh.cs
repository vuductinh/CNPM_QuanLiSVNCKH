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
    
    public partial class ChuyenNganh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuyenNganh()
        {
            this.DetaiNCKHs = new HashSet<DetaiNCKH>();
        }
    
        public string MaCN { get; set; }
        public string tenCN { get; set; }
        public string Mabomon { get; set; }
    
        public virtual BoMon BoMon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetaiNCKH> DetaiNCKHs { get; set; }
    }
}
