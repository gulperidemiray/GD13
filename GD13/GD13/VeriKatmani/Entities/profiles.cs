using System;
using System.Collections.Generic;

namespace VeriKatmani.Entities;
public partial class profiles
{

    public int id { get; set; }
    public string? profile_name { get; set; }
    public string? profile_icon_url { get; set; }
    public string? profile_url { get; set; }
    public int? KullaniciNo { get; set; }

}


