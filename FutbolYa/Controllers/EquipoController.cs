using Microsoft.AspNetCore.Mvc;

namespace FutbolYa.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
