using System;

namespace VeriKatmani.Entities
{
    public class Education
    {
        public int id { get; set; }
        //public int? start_year { get; set; }
        //public int? end_year { get; set; }
        //public string? degree { get; set; }
        //public string? institution { get; set; }
        //public string? location { get; set; }
        //public string? description { get; set; }
        //public string? SchoolName { get; set; }

        
           
            public int? StartYear { get; set; }
            public int? EndYear { get; set; }
            public string Degree { get; set; }
            public string Institution { get; set; }
            public string Location { get; set; }
            public string Description { get; set; }
        

        public class MyViewModel
        {
            public List<Education> Education { get; set; }
        }


    }
}
