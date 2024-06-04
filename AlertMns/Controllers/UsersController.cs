using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlertMns.Models;
using AlertMns.ViewModels;
using AlertMns.Data;
using Microsoft.AspNetCore.Identity;

namespace AlertMns.Controllers
{
    // CREATE et LOGIN > ACCOUNTCONTROLLER
    public class UsersController : Controller
    {
        private readonly DataContext _context;
        private readonly UserManager<User> _userManager;

        public UsersController(DataContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Users
        public IActionResult Index()
        {
            return View();
        }

        // GET: Users/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var user = await _context.Users
        //        .FirstOrDefaultAsync(m => m.UserId == id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(user);
        //}

        // GET: Users/Create
        public IActionResult Create()
        {
            var viewModel = new RegisterViewModel()
            {
                Companies = _context.Companies.ToList(),
                Positions = _context.Positions.ToList(),
                Roles = _context.Roles.ToList()
            };
            return View(viewModel);
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User()
                {
                    LastName = model.LastName,
                    FirstName = model.FirstName,
                    Email = model.Email,
                    UserName = model.Email,
                    CompanyId = model.CompanyId,
                    PositionId = model.PositionId,
                    RoleId = 3, // rôle utilisateur par défaut (ayant le moins de droits, par sécurité)
                    CreationDate = DateTime.Now,
                    ConnectionDate = null,
                    Status = false
                };

                // Attribution du rôle en fonction du poste occupé (si différent du rôle par défaut)
                if (model.PositionId == 1 || model.PositionId == 2 || model.PositionId == 3 || model.PositionId == 4)
                {
                    newUser.RoleId = 1;
                }
                else if (model.PositionId == 5)
                {
                    newUser.RoleId = 2;
                }

                var result = await _userManager.CreateAsync(newUser, model.Password!);

                if (result.Succeeded)
                {
                    return RedirectToAction("Dashboard", "Home");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        //// GET: Users/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var user = await _context.Users.FindAsync(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(user);
        //}

        //// POST: Users/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,LastName,FirstName,Email,Password,CreationDate,ConnectionDate,Status")] User user)
        //{
        //    if (id != user.UserId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(user);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!UserExists(user.UserId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(user);
        //}

        //// GET: Users/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var user = await _context.Users
        //        .FirstOrDefaultAsync(m => m.UserId == id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(user);
        //}

        //// POST: Users/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var user = await _context.Users.FindAsync(id);
        //    if (user != null)
        //    {
        //        _context.Users.Remove(user);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool UserExists(int id)
        //{
        //    return _context.Users.Any(e => e.UserId == id);
        //}
    }
}
