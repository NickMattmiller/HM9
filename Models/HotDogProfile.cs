using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentExample.Models
{
    public class HotDogProfile
    {
        public int Id { get; set; }
        public string Title {get; set;}
        public string Pic { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

        public string Favorite_Meat { get; set; }
        public string Favorite_Bun { get; set; }
    }
}