﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Traveltrip.Models.Sınıflar
{
    public class Hakkımızda
    {
        [Key]
        public int ID{ get; set; }
        public  string FotoUrl{ get; set; }

        public string icerik { get; set; }
    }
}