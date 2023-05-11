using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MovieMVC.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }


}









