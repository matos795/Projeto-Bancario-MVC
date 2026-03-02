using Microsoft.AspNetCore.Mvc;

namespace SistemaBancario.Controllers
{
    public class ContaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
