using System;
namespace DTO.Request
{
	public class ProfilEkle
	{
        public string? profile_name { get; set; }
        public string? profile_icon_url { get; set; }
        public string? profile_url { get; set; }
        public int? KullaniciNo { get; set; }
    }
}

