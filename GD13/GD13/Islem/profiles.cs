using System;
using VeriKatmani.Contexts;
namespace Islem
{
	public class profiles
	{
        public static void ProfilEkle(DTO.Request.ProfilEkle Veri)
        {
            GD13Context Model = new GD13Context();
            VeriKatmani.Entities.profiles Nesne = new VeriKatmani.Entities.profiles();
            Nesne.profile_icon_url = Veri.profile_icon_url;
            Nesne.profile_name = Veri.profile_name;
            Nesne.KullaniciNo = Veri.KullaniciNo;
            Nesne.profile_url = Veri.profile_url;
            Model.profiles.Add(Nesne);
            Model.SaveChanges();
        }
        public static List<DTO.Reponse.profiles> ProfilListe ( int KullaniciNo)
        {
            GD13Context Model = new GD13Context();
            List<DTO.Reponse.profiles> Osman = Model.profiles
                .Where(q => q.KullaniciNo == KullaniciNo)
                .Select(s => new DTO.Reponse.profiles
                {
                         profile_name=s.profile_name,
                           profile_url=s.profile_name,
                          id=s.id,
                          profile_icon_url=s.profile_icon_url,



    }).ToList();

            return Osman;
        }
        public static void ProfilSil(int No)
        {
            GD13Context Model = new GD13Context();
            ///var Nesne = Model.Sepet.Where(q => q.No == No).FirstOrDefault();
            var Nesne = Model.profiles.FirstOrDefault(f => f.id == No);

            Model.profiles.Remove(Nesne);
            Model.SaveChanges();

        }


    }
}

