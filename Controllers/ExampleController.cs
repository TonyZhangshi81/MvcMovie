using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class ExampleController : Controller
    {
        private readonly ILogger<ExampleController> _logger;
        private readonly MvcMovieContext _context;


        public ExampleController(ILogger<ExampleController> logger, MvcMovieContext context)
        {
            _logger = logger;
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(ExampleViewModel? viewModel)
        {
            if(viewModel is not null)
            {
                viewModel.GenresItems = new SelectList(await _context.Movie.ToListAsync(), "Genre", "Genre");
                viewModel.TitleItems = new SelectList(_context.Movie.Where(d => d.Genre == viewModel.Genre).ToList(), "Title", "Title");
                viewModel.GenreTitle = viewModel.Genre + viewModel.Title;

                this.ModelState.Clear();
                return View(viewModel);
            }

            var movieGenreVM = new ExampleViewModel
            {
                GenresItems = new SelectList(await _context.Movie.ToListAsync(), "Genre", "Genre"),
            };

            return View(movieGenreVM);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Genre"></param>
        /// <returns></returns>
        [HttpGet]
        public JsonResult GetTitleList(string Genre)
        {
            var TitleItems = new SelectList(_context.Movie.Where(d => d.Genre == Genre).ToList(), "Title", "Title");

            /*
            if (CountryId == 1)
            {
                StateList = new List<State> { new State { StateId = 1, CountryId = 1, StateName = "Stockholm" }, new State { CountryId = 1, StateName = "Malmö", StateId = 2 }, new State { CountryId = 1, StateId = 3, StateName = "Göteborg" } };
            }
            else
                StateList = new List<State> { new State { StateId = 1, CountryId = 1, StateName = "Oslo" } };
            */
            // , new Newtonsoft.Json.JsonSerializerSettings()

            return Json(TitleItems);
        }

    }
}