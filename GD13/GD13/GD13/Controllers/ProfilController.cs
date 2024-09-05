using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VeriKatmani.Entities;
using DTO.Reponse;
using DTO.Request;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GD13.Controllers
{
    public class ProfilController : Controller
    {
        public IActionResult ProfilEkle(string profil_url, string profile_name, string profile_icon_url)
        {
            DTO.Request.ProfilEkle Nesne = new DTO.Request.ProfilEkle();
            Nesne.KullaniciNo = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(f => f.Type == "No").Value);
            Nesne.profile_url = profil_url;
            Nesne.profile_name = profile_name;
            Nesne.profile_icon_url = profile_icon_url;
            Islem.profiles.ProfilEkle(Nesne);



            int KullaniciNo = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(f => f.Type == "No").Value);
            List<DTO.Reponse.profiles> ProfilListe = Islem.profiles.ProfilListe(KullaniciNo);
             DTO.Reponse.GD13 Kullanici1 = Islem.KullaniciBilgileri.Kullanici(KullaniciNo);
            List<DTO.Reponse.GD13> Education = Islem.Egitim.Education();


            var Cevap = (Education, ProfilListe,Kullanici1);
            return View("/Views/Home/OturumSayfasi.cshtml", Cevap);
        }
        public IActionResult ProfilSil(string Id)
        {
            int ProfilNo = Convert.ToInt32(Id);
            Islem.profiles.ProfilSil(ProfilNo);
            int KullaniciNo = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(f => f.Type == "No").Value);
            List<DTO.Reponse.profiles> ProfilListe = Islem.profiles.ProfilListe(KullaniciNo);
            DTO.Reponse.GD13 Kullanici1 = Islem.KullaniciBilgileri.Kullanici(KullaniciNo);
            List<DTO.Reponse.GD13> Education = Islem.Egitim.Education();
            var Cevap = (Education, ProfilListe, Kullanici1);
            return View("/Views/Home/OturumSayfasi.cshtml", Cevap);
        }
    }
}

