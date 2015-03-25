using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;


namespace StudentExample.Models
{
    class HotDog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Meat { get; set; }
        public string Bun { get; set; }
       

        //public HotDogProfile HotDogProfile { get; set; }
    }
}
