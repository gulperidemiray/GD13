using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DTO.Reponse;
using Islem;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using VeriKatmani.Contexts;
using VeriKatmani.Entities;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GD13.Controllers
{
    public class OturumController : Controller
    {
        public IActionResult Index()
        {
            return View("/Views/Login/Login.cshtml");
        }
        public IActionResult Login(string KullaniciAd, string Parola)
        {
            GD13Context Model = new GD13Context();

            var Kullanici = Model.Kullanici.FirstOrDefault(f => f.KullaniciAd == KullaniciAd && f.Sifre == Parola);

            if (Kullanici != null)
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim("No", Kullanici.No.ToString()));
                claims.Add(new Claim("Ad", Kullanici.Ad));
                claims.Add(new Claim("Soyad", Kullanici.Soyad));
                claims.Add(new Claim(ClaimTypes.Role, Kullanici.RolNo.ToString()));

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                AuthenticationProperties properties = new AuthenticationProperties();
                ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    principal, properties);

                List<DTO.Reponse.GD13> Education = Islem.Egitim.Education();

                List<DTO.Reponse.profiles> ProfilListe = Islem.profiles.ProfilListe(Kullanici.No);
                DTO.Reponse.GD13 Kullanici1 = Islem.KullaniciBilgileri.Kullanici(Kullanici.No);


                var Cevap = (Education, ProfilListe, Kullanici1);


                return View("/Views/Home/OturumSayfasi.cshtml", Cevap);

            }

            return View("/Views/Login/login.cshtml");
        }

        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync();
            int KullaniciNo = 4;

            List<DTO.Reponse.profiles> ProfilListe = Islem.profiles.ProfilListe(KullaniciNo);
            DTO.Reponse.GD13 Kullanici1 = Islem.KullaniciBilgileri.Kullanici(KullaniciNo); 
            List<DTO.Reponse.GD13> Education = Islem.Egitim.Education();


            var Cevap = (Education, ProfilListe, Kullanici1);

            return RedirectToAction("Index", "Home",Cevap);

        }
        
    }
}


