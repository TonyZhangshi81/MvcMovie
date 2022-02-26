using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Genres { get; set; }

        public Movie? Movie { get; set; }

        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Total price")]
        public decimal Price { get; set; }
    }
}