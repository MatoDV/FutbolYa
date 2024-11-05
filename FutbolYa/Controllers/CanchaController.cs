using Microsoft.AspNetCore.Mvc;

namespace FutbolYa.Controllers
{
    public class CanchaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
