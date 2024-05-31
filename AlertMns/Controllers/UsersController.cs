using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlertMns.Models;
using AlertMns.ViewModels;
using AlertMns.Data;

namespace AlertMns.Controllers
{
    public class UsersController : Controller
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
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

        //// GET: Users/Create
        //public IActionResult Create()
        //{
        //    var viewModel = new UserViewModel()
        //    {
        //        Companies = _context.Companies.ToList(),
        //        Positions = _context.Positions.ToList(),
        //        Roles = _context.Roles.ToList()
        //    };
        //    return View(viewModel);
        //}

        //// POST: Users/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("LastName,FirstName,Email,Password, CompanyId, PositionId")] UserViewModel user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        User newUser = new User()
        //        {
        //            LastName = user.LastName,
        //            FirstName = user.FirstName,
        //            Email = user.Email,
        //            Password = user.Password,
        //            CompanyId = user.CompanyId,
        //            PositionId = user.PositionId,
        //            RoleId = 3, // rôle utilisateur par défaut (ayant le moins de droits, par sécurité)
        //            CreationDate = DateTime.Now,
        //            ConnectionDate = null,
        //            Status = false
        //        };

        //        // Attribution du rôle en fonction du poste occupé (si différent du rôle par défaut)
        //        if (user.PositionId == 1 || user.PositionId == 2 || user.PositionId == 3 || user.PositionId == 4)
        //        {
        //            newUser.RoleId = 1;
        //        } else if (user.PositionId == 5)
        //        {
        //            newUser.RoleId = 2;
        //        }

        //        _context.Add(newUser);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(user);
        //}

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
