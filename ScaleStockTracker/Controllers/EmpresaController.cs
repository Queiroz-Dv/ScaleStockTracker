using Microsoft.AspNetCore.Mvc;

namespace ScaleStockTracker.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
