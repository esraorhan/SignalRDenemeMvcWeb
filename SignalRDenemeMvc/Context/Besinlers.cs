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
    
    public partial class Besinlers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Besinlers()
        {
            this.Ogunlers = new HashSet<Ogunlers>();
        }
    
        public int BesinID { get; set; }
        public string Yemek { get; set; }
        public string Miktar { get; set; }
        public string OlcuBirimi { get; set; }
        public string Kalori { get; set; }
        public string Protein { get; set; }
        public string Karbonhidrat { get; set; }
        public string Yağ { get; set; }
        public int CategoriesID { get; set; }
    
        public virtual Categories Categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ogunlers> Ogunlers { get; set; }
    }
}
