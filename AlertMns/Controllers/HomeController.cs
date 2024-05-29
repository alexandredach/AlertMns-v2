using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlertMns.Models;
using AlertMns.ViewModels;
using AlertMns.Data;

namespace AlertMns.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Login(UserCredentials credentials)
        //{
        //    // Logique de vérification des identifiants et de connexion
        //    // ...

        //    // Si les identifiants sont corrects, redirige vers l'action Dashboard
        //    return RedirectToAction("Dashboard");
        //}

        // GET: Home/Dashboard
        public async Task<IActionResult> Dashboard()
        {
            return View(await _context.Meetings.ToListAsync());
        }
    }
}
