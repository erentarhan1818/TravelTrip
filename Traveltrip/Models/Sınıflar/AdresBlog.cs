﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Traveltrip.Models.Sınıflar
{
    public class AdresBlog
       {
        [Key]
        public int ID { get; set; }

        public string Baslık{ get; set; }

        public string Acıklama { get; set; }
        public string AdresAcık { get; set; }
        public string Mail { get; set; }
        public string Telefon{ get; set; }
        public string Konum { get; set; }


    }
}