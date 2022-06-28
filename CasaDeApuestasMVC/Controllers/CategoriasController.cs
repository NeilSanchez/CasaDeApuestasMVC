using Microsoft.AspNetCore.Mvc;

namespace CasaDeApuestasMVC.Controllers
{
    public class CategoriasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
