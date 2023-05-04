using Microsoft.AspNetCore.Mvc;

namespace ScaleStockTracker.Controllers.Empresa
{
    public class EmpresaController : Controller
    {
        public IActionResult EmpresaBoard()
        {
            return View();
        }
    }
}
