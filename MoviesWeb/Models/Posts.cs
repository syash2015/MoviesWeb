using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesWeb.Models
{
    public class Posts
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        [AllowHtml]
        public string Description { get; set; }
        public string Date { get; set; }
        public string Source { get; set; }
        public string ShortDesc { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? CreatedOn { get; set; }
        public string Image { get; set; }
        public string CreatedBy { get; set; }
        public Posts()
        {
            this.CreatedOn = DateTime.Now;
        }
    }
}