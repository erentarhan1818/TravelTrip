using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Traveltrip.Models.Sınıflar
{
    public class Otel
    {
        [Key]
        public int ID { get; set; }
        public string Baslık { get; set; }
        public DateTime Tarih { get; set; }
        public string Acıklama { get; set; }
        public string BlogImage { get; set; }

    }
}