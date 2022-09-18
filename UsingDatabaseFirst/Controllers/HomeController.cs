using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using UsingDatabaseFirst.Models;
using UsingDatabaseFirst.Models.db;

namespace UsingDatabaseFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly thaivbShopContext _db;

        public HomeController(thaivbShopContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var ps = from p in _db.Products select p;
            if (ps == null)
            {
                return NotFound();
            }
            return View(await ps.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}