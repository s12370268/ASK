using Microsoft.AspNetCore.Mvc;

namespace ASK.AspNetCoreRoute.Areas.Notices.Controllers
{
    [Area("Notices")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(string title)
        {
            ViewBag.Title = title;
            return View();
        }
    }
}
