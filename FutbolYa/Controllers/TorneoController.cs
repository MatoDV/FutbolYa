using Microsoft.AspNetCore.Mvc;

namespace FutbolYa.Controllers
{
    public class TorneoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
