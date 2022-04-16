using Microsoft.AspNetCore.Mvc;

namespace ASK.AspNetCoreRoute.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
