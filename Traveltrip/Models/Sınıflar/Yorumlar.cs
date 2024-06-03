using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Traveltrip.Models.Sınıflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }

        public string KullanıcıAdı { get; set; }

        public string Mail { get; set; }

        public string  Yorum{ get; set; }

        public int Blogid { get; set; }

        public virtual Blog Blog { get; set; } //bir blogta birden fazla yorum olablir.

    }
}