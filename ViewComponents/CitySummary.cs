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
        /// <param name="counts"></param>
        /// <param name="movies"></param>
        /// <returns></returns>
        public IViewComponentResult Invoke(int? counts, List<Movie> movies)
        {
            return View(new CitySummaryViewModel()
            {
                Counts = counts ?? _context.Movie.Count(),
                Price = movies.Sum(d => d.Price)
            });
        }
    }
}
