//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_Son_Kısım
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_notlar
    {
        public int notid { get; set; }
        public Nullable<int> ogr { get; set; }
        public Nullable<int> ders { get; set; }
        public Nullable<short> sınav1 { get; set; }
        public Nullable<short> sınav2 { get; set; }
        public Nullable<short> sınav3 { get; set; }
        public Nullable<decimal> ortalama { get; set; }
        public Nullable<bool> durum { get; set; }
    
        public virtual dersler dersler { get; set; }
        public virtual tblogrenci tblogrenci { get; set; }
    }
}
