using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesWeb.Models
{
    public class CriticsReviews
    {
        [Key]
        public int ReviewId { get; set; }
        public int MovieId { get; set; }
        public string CriticName { get; set; }
        public string Rating { get; set; }
        public string SourceName { get; set; }
        public string SourceURL { get; set; }
        public string ShortReview { get; set; }
        public string FullReview { get; set; }

       
    }

    public class CriticsReviewsViewModel
    {
        public int ReviewId { get; set; }
        public int MovieId { get; set; }
        public string CriticName { get; set; }
        public string Rating { get; set; }
        public string SourceName { get; set; }
        public string SourceURL { get; set; }
        public string ShortReview { get; set; }
        public string FullReview { get; set; }
        public List<Movies> MoviesList { get; set; }
        public IEnumerable<SelectListItem> myList { get; set; }
    }
}