using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDenemeMvc.Models
{
    public class BesinList
    {
        public int BesinID { get; set; }
        public string Yemek { get; set; }
        public string Miktar { get; set; }
        public string OlcuBirimi { get; set; }
        public string Kalori { get; set; }
        public string Protein { get; set; }
        public string Karbonhidrat { get; set; }
        public string Yağ { get; set; }
        public int CategoriesID { get; set; }
    }
}