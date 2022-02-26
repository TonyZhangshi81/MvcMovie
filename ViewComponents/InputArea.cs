using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.ViewComponents
{
    /// <summary>
    /// 
    /// </summary>
    public class InputArea : ViewComponent
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IViewComponentResult Invoke(MovieGenreViewModel model)
        {
            return View(model);
        }
    }
}
