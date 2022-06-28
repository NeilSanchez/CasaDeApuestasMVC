using CasaDeApuestasMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CasaDeApuestasMVC.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Listado()
        {
            var usuarios = await UsuarioService.GetAll();
            return View(usuarios);
        }
    }

    
}
