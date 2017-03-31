using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesWeb.Models
{
    public class News
    {
        [Key]
        public int NewsId { get; set; }
        public string Title { get; set; }
        [AllowHtml]
        public string Description { get; set; }
        public string Date { get; set; }
        public string Source { get; set; }
        public string ShortDesc { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}