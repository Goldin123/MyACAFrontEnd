using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyACAWebsite.Data;
using MyACAWebsite.Models;

namespace MyACAWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApiContext _context;

        public HomeController(ApiContext context)
        {
            _context = context;
        }
        public  IActionResult Index()
        {
            var users = _context.Users.ToList();

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

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            var user = new User();
            return View();
        }

        [HttpPost]
        public IActionResult DoRegistration(User user)
        {
            if (ModelState.IsValid)
            { }

            return RedirectToAction("Login");
        }

    }
}
