using System;
using VeriKatmani.Contexts;
using DTO.Reponse;
namespace Islem
{
	public class KullaniciBilgileri
	{
        public static DTO.Reponse.GD13 Kullanici(int KullaniciNo)
        {

            GD13Context Model = new GD13Context();
            DTO.Reponse.GD13 Kullanici1 = new DTO.Reponse.GD13();
            Kullanici1 = Model.Kullanici.Where(q => q.No == KullaniciNo)
                .Select(s => new DTO.Reponse.GD13
                {
                    No = s.No,
                    Ad = s.Ad,
                    Soyad = s.Soyad,
                }).FirstOrDefault();
            return Kullanici1;
        }

        public static List<DTO.Reponse.profiles> profiles (int KullaniciNo)
        {
            GD13Context Model = new GD13Context();
            List<DTO.Reponse.profiles> profiles = Model.profiles
                .Where(q => q.KullaniciNo == KullaniciNo)
                .Select(s => new DTO.Reponse.profiles
                {
                    profile_url = s.profile_url,
                    profile_name = s.profile_name,
                    profile_icon_url = s.profile_icon_url,


                }).ToList();

            return profiles;
        }
    }
}

