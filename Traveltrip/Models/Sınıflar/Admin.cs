using System.ComponentModel.DataAnnotations;

namespace Traveltrip.Models.Sınıflar
{
    public class Admin
    {

        [Key] 
        public int ID { get; set; }
        public string  Kullanıcı{ get; set; }
        public string sifre { get; set; }

    }
}