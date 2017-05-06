using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppCompositionRoot.MyTypes;

namespace WebAppCompositionRoot.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieManager movieManager;

        public MovieController(IMovieManager movieManager)
        {
            this.movieManager = movieManager;
        }
        public IActionResult Index()
        {
            return View();
        }


    }
}
