using Microsoft.AspNetCore.Mvc;

namespace ASK.AspNetCoreRoute.Areas.Account.Controllers
{
    [Area("Account")]
    public class InfoController : Controller
    {
        [HttpGet]
        public IActionResult Detail()
        {
            return View();
        }
    }
}
