using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlertMns.Models;
using AlertMns.ViewModels;
using AlertMns.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace AlertMns.Controllers
{
    [Authorize] /*> pour contrôleur Home(séparé) qui force le login avant d'accéder aux liens*/
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        //private readonly SignInManager<User> signInManager;
        private readonly ILogger<HomeController> _logger;

        public HomeController(DataContext context, ILogger<HomeController> logger)
        {
            //this.signInManager = signInManager;
            _context = context;
            _logger = logger;
        }

        //[AllowAnonymous]
        //public IActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> LoginAsync(LoginViewModel model)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        var result = await signInManager.PasswordSignInAsync(model.Email!, model.Password!, model.RememberMe, false);

        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("Dashboard", "Home");
        //        }
        //        ModelState.AddModelError("", "Identifiant / mot de passe erronnés");
        //        return View(model);
        //    }
        //    return View(model);
        //}

        //GET: Home/Dashboard
        public async Task<IActionResult> Dashboard()
        {
            return View(await _context.Meetings.ToListAsync());
        }
    }
}
