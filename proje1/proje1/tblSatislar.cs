//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proje1
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSatislar
    {
        public int satisID { get; set; }
        public Nullable<int> urun { get; set; }
        public Nullable<int> musteri { get; set; }
        public Nullable<int> adet { get; set; }
        public Nullable<int> toplamFiyat { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
    
        public virtual tblMusteriler tblMusteriler { get; set; }
        public virtual tblUrunler tblUrunler { get; set; }
    }
}
