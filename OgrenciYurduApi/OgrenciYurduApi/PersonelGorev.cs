//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OgrenciYurduApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonelGorev
    {
        public int GorevID { get; set; }
        public Nullable<int> PersonelID { get; set; }
        public int YoneticiID { get; set; }
        public string GorevAciklama { get; set; }
    
        public virtual Personel Personel { get; set; }
        public virtual Yonetici Yonetici { get; set; }
    }
}