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
    
    public partial class DiyetSablons
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiyetSablons()
        {
            this.OgunIcerikleris = new HashSet<OgunIcerikleris>();
            this.Ogunlers = new HashSet<Ogunlers>();
        }
    
        public int DiyetSablonID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public System.DateTime OlusturmaTarihi { get; set; }
        public decimal ToplamKalori { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OgunIcerikleris> OgunIcerikleris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ogunlers> Ogunlers { get; set; }
    }
}
