using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonasFisicasPrueba.Areas.Main.Controllers
{
    [Area("Main")]
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
