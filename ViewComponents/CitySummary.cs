using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.ViewComponents
{
    /// <summary>
    /// 
    /// </summary>
    public class CitySummary : ViewComponent
    {
        private readonly MvcMovieContext _context;

        /// <summary>
        /// 
        /// </summary>
        public CitySummary(MvcMovieContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public IViewComponentResult Invoke(decimal? price)
        {
            return View(new CitySummaryViewModel()
            {
                Counts = _context.Movie.Count(),
                Price = price ?? _context.Movie.Sum(d => d.Price)
            });
        }
    }
}
