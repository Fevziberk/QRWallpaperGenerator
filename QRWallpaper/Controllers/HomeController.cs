using Microsoft.AspNetCore.Mvc;

namespace BookWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EditPage()
        {
            return View();
        }
    }
}
