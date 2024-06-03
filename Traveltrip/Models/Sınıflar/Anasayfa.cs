using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Traveltrip.Models.Sınıflar
{
    public class Anasayfa
    {
        [Key]
        public int ID { get; set; }
        public string Baslık { get; set; }
        public  string Acıklama { get; set; }
        
    }
}