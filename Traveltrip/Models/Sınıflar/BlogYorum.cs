using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Traveltrip.Models.Sınıflar
{
    public class BlogYorum
    {   
        public IEnumerable<Blog> Deger1 { get; set; } // IEnumerable ile birde fazla yerden  veri çekebiliyoruz ama diğerlerinde
                                                         // @model<Blog >yazdığımızda sadece blog içerisinden veri çekebiliyoruz.
        public IEnumerable<Yorumlar> Deger2 { get; set;}
        public IEnumerable<Blog> Deger3 { get; set; }
    }
}