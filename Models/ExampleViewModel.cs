using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ExampleViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "MovieGenre")]
        public IEnumerable<SelectListItem> GenresItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "TitleItems")]
        public IEnumerable<SelectListItem> TitleItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string GenreTitle { get; set; }

    }
}