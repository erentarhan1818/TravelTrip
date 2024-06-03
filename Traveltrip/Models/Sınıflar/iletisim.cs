using System.ComponentModel.DataAnnotations;

namespace Traveltrip.Models.Sınıflar
{
    public class iletisim
    {
        [Key]
        public int ID { get; set; }

        public string ADSoyad { get; set; }

        public string Mail { get; set; }

        public string  Konu{ get; set; }
        public string Mesaj{ get; set; }
    }
}