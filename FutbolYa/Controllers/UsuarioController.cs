using Microsoft.AspNetCore.Mvc;

namespace FutbolYa.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
