using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GD13.Models;
using System;
using GD13.Models;
using System.Linq;
namespace GD13.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        int KullaniciNo = 4;

        List<DTO.Reponse.profiles> ProfilListe = Islem.profiles.ProfilListe(KullaniciNo);
        DTO.Reponse.GD13 Kullanici1 = Islem.KullaniciBilgileri.Kullanici(KullaniciNo);
        List<DTO.Reponse.GD13> Education = Islem.Egitim.Education();


        var Cevap = (Education, ProfilListe, Kullanici1);

        return View("Index",Cevap);
    }
    public IActionResult Oturum()
    {
        int KullaniciNo = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(f => f.Type == "No").Value);

        List<DTO.Reponse.GD13> Education = Islem.Egitim.Education();

        List<DTO.Reponse.profiles> ProfilListe = Islem.profiles.ProfilListe(KullaniciNo);
        DTO.Reponse.GD13 Kullanici1 = Islem.KullaniciBilgileri.Kullanici(KullaniciNo);


        var Cevap = (Education, ProfilListe, Kullanici1);

        return View( Cevap);
    }

    public IActionResult Education()
    {
        return View("Index", Islem.Egitim.Education());

    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    
}

