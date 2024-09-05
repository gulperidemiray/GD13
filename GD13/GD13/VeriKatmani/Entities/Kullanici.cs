using System;
using System.Collections.Generic;

namespace VeriKatmani.Entities;

public partial class Kullanici
{
    
    public int No { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public string? KullaniciAd { get; set; }

    public string? Sifre { get; set; }

    public string? Eposta { get; set; }

    public string? Adres { get; set; }

    public int? RolNo { get; set; }

    public virtual Rol? RolNoNavigation { get; set; }
}
