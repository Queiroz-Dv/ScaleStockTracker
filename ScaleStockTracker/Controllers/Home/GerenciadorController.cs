using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScaleStockTracker.Models;
using System.Diagnostics;

namespace ScaleStockTracker.Home
{
    public class GerenciadorController : Controller
    {
        private readonly ILogger<GerenciadorController> _logger;

        public GerenciadorController(ILogger<GerenciadorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
