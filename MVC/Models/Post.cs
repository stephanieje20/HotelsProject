using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime DateUpload { get; set; }
        public string Contents { get; set; }
        public string Photo { get; set; }
        public string Video { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public int HotelID { get; set; }
        [ForeignKey("HotelID")]
        public Hotel Hotel { get; set; }
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
    }
}