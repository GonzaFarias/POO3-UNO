using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PruebaController : Controller
    {
        private readonly ILogger<PruebaController> _logger;

        public PruebaController(ILogger<PruebaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Informacion()
        {
            // ViewBag.usuario = "PEPE";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
