using Microsoft.AspNetCore.Mvc;

namespace FutbolYa.Controllers
{
    public class RankingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
