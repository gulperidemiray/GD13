using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VeriKatmani.Entities;

namespace DTO.Reponse
{
    public class GD13
    {
        //Profil
        public int id { get; set; }
        public string profile_name { get; set; }
        public int KullaniciNo { get; set; }
        public int profile_icon_url { get; set; }
        public int profile_url { get; set; }

        //Eğitim
        public int start_year { get; set; }
        public int end_year { get; set; }
        public int degree { get; set; }
        public string institution { get; set; }
        public string location { get; set; }
        public string description { get; set; }
        public string SchoolName { get; set; }
        public string Name { get; set; }
        public string IconUrl { get; set; }
        public string Link { get; set; }
        public int No { get; set; }

        //Oturum Sayfası

        public string? Ad { get; set; }

        public string? Soyad { get; set; }

        public string? KullaniciAd { get; set; }

        public string? Sifre { get; set; }

        public string? Eposta { get; set; }

        public string? Adres { get; set; }

        public int? RolNo { get; set; }

        //Eğitim Bilgileri 2
        public virtual Rol? RolNoNavigation { get; set; }
        public int? StartYear{ get; set; }
        public int? EndYear { get; set; }
        public string Degree { get; set; }
        public string Institution { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        //Profiller
        public string UserName { get; set; }
        public string LinkedInUrl { get; set; }
        public string GitHubUrl { get; set; }
    }
}