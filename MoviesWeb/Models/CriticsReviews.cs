using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesWeb.Models
{
    public class CriticsReviews
    {
        [Key]
        public int ReviewId { get; set; }
        public string CriticName { get; set; }
        public string Rating { get; set; }
        public string SourceName { get; set; }
        public string SourceURL { get; set; }
        public string ShortReview { get; set; }
        public string FullReview { get; set; }
    }
}