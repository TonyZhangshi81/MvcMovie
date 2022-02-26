using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class InputAreaViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Total price")]
        public decimal Price { get; set; }
    }
}
