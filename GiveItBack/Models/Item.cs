using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiveItBack.Models
{
    

    public class Item
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public DateTime LendDate { get; set; }
        public User Contact { get; set; }
    }
}