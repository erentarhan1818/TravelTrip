using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Traveltrip.Models.Sınıflar;

namespace Traveltrip.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c =new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);

        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();  
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");       

        }
        public ActionResult BlogSil(int id)
        {
            var  b = c.Blogs.Find(id);  
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir",bl);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Acıklama = b.Acıklama;
            blg.Baslık = b.Baslık;
            blg.BlogImage = b.BlogImage;
            blg.Tarih =b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
           
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var b = c.yorumlars.Find(id);
            c.yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yl = c.yorumlars.Find(id);
            return View("YorumGetir", yl);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.yorumlars.Find(y.ID);
            yrm.KullanıcıAdı = y.KullanıcıAdı;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");

        }
       
    }
}