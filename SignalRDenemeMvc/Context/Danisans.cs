//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SignalRDenemeMvc.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Danisans
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Danisans()
        {
            this.danisanTahlilDosyas = new HashSet<danisanTahlilDosyas>();
            this.Gorusmelers = new HashSet<Gorusmelers>();
        }
    
        public int DanisanID { get; set; }
        public string AdiSoyadi { get; set; }
        public string Email { get; set; }
        public string TlfNo { get; set; }
        public string Cinsiyet { get; set; }
        public System.DateTime DogumTarihi { get; set; }
        public string Image { get; set; }
        public System.DateTime DiyetBaslamatarihi { get; set; }
        public bool Status { get; set; }
        public string EgitimDurumu { get; set; }
        public float Boy { get; set; }
        public float Kilo { get; set; }
        public int Yas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<danisanTahlilDosyas> danisanTahlilDosyas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gorusmelers> Gorusmelers { get; set; }
    }
}