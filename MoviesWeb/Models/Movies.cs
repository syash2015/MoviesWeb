using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesWeb.Models
{
    public class Movies
    {
        public int ID { get; set; }
        public string MName { get; set; }
        public string MDuration { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Cast { get; set; }
        public string Direcotr { get; set; }
        public string Image { get; set; }
        public byte[] Thumbnail { get; set; }
        public string CreatedBy { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? CreatedOn { get; set; }
        public Movies()
        {
            this.CreatedOn = DateTime.Now;
        }

    }
}