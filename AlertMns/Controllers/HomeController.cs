using Microsoft.AspNetCore.Mvc;

namespace AlertMns.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
