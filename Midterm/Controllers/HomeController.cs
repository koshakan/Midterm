using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Midterm.Data;
using Midterm.Models;

namespace Midterm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
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

        [HttpPost]
        public IActionResult Math(Models.Math1 math)
        {
            math.Add = math.A + math.B;
            math.Substract = math.A - math.B;
            math.Multiply = math.A * math.B;
            math.Division = math.A / math.B;
            _context.Maths.Add(math);
            _context.SaveChanges();
            TempData["Add"] = math.Add.ToString();
            TempData["Substract"] = math.Substract.ToString();
            TempData["Multiply"] = math.Multiply.ToString();
            TempData["Division"] = math.Division.ToString();
            return RedirectToAction("Index");
        }
    }
}
