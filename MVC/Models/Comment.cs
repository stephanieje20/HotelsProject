using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public DateTime DateUpload { get; set; }
        public string Contents { get; set; }
        public int PostID { get; set; }
        [ForeignKey("PostID")]
        public Post Post { get; set; }
    }
}