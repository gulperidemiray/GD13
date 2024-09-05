
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriKatmani.Contexts;
using VeriKatmani.Entities;

namespace Islem
{
    public class Egitim

    {

        public static List<DTO.Reponse.GD13> Education()
        {
            GD13Context Model = new GD13Context();
            List<DTO.Reponse.GD13> Education = Model.Education.Select(s => new DTO.Reponse.GD13
            {
                StartYear = s.StartYear,
                EndYear=s.EndYear,
                Institution=s.Institution,
                Location=s.Location,
                Description=s.Description,
            }).ToList();
            return Education;
        }

    }
    
}