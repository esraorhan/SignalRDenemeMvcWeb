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
    
    public partial class OgunIcerikleris
    {
        public int OgunIcerikID { get; set; }
        public string Miktar { get; set; }
        public string Olcubirimi { get; set; }
        public string Kalori { get; set; }
        public string Protein { get; set; }
        public string Karbonhidrat { get; set; }
        public string Yağ { get; set; }
        public int OgunID { get; set; }
        public int DiyetSablonID { get; set; }
        public int BesinID { get; set; }
    
        public virtual DiyetSablons DiyetSablons { get; set; }
        public virtual Ogunlers Ogunlers { get; set; }
    }
}