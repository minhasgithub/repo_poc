using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleWebDotNetCore.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleWebDotNetCore.Controllers
{
    public class FilmController : Controller
    {
        // GET: /<controller>/
        public IActionResult movies()
        {
          InfyContext   context  = HttpContext.RequestServices.GetService(typeof(SampleWebDotNetCore.Models.InfyContext)) as InfyContext;

            return View(context.GetAllFilms());
        }
    }
}
