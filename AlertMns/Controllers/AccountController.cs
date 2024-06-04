using AlertMns.Data;
using AlertMns.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AlertMns.Models;
using AlertMns.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace AlertMns.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext _context;
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> _userManager;

        public AccountController(DataContext context, SignInManager<User> signInManager)
        {
            _context = context;
            this.signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Login
                var result = await signInManager.PasswordSignInAsync(model.Username!, model.Password!, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Dashboard", "Home");
                }
                ModelState.AddModelError("", "Identifiant / mot de passe invalides.");
                return View(model);
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
