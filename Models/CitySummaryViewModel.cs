using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class CitySummaryViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "The total number of films:")]
        public int Counts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Total price")]
        public decimal Price { get; set; }
    }
}
