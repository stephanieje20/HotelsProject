using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Hotel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Contents { get; set; }
        public string Photo { get; set; }
        public string Video { get; set; }
        public int Stars { get; set; }
        public int Rate { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}