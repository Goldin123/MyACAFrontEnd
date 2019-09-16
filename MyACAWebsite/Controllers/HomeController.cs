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

        public IActionResult Login()
        {
           
            return View();
        }

        public IActionResult Logout()
        {
            ClearCookie();
            return RedirectToAction("Login");
        }

        void ClearCookie()
        {
            GlobalVariables.UserID = 0;
            GlobalVariables.User = string.Empty;
            GlobalVariables.Age = string.Empty;
            GlobalVariables.Grade = string.Empty;
            GlobalVariables.ErrorMesage = string.Empty;
        }

        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public IActionResult DoRegistration(User user)
        {
            if (ModelState.IsValid)
            {
                int iMaxID = _context.Users.Max(a => (int)a.Id) + 1;
                using (var db = _context)
                {
                    user.Id = iMaxID;
                    db.Users.Add(user);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Login");
        }


        [HttpPost]
        public IActionResult DoAuthentication(Login login)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users.Where(a => a.Email == login.Username && a.Password == login.Password).SingleOrDefault();
                if (user != null)
                {
                    if (user.Id > 0)
                    {
                        GlobalVariables.User = $"{user.FirstName} {user.LastName}";
                        GlobalVariables.Grade = $"{user.Grade}";
                        return RedirectToAction("Landing");
                    }
                    else
                    {
                        GlobalVariables.ErrorMesage = "User Does not Exist.";
                        return RedirectToAction("Login");
                    }
                }
                else
                {
                    GlobalVariables.ErrorMesage = "User Does not Exist.";
                    return RedirectToAction("Login");
                }
            }
            else
            {
                GlobalVariables.ErrorMesage = "Please try Again";
                return RedirectToAction("Login");
            }
        }
        public IActionResult Landing()
        {
            if (!string.IsNullOrEmpty(GlobalVariables.User))
                return View();
            else
                return RedirectToAction("Login");
        }
        public IActionResult Profile()
        {
            if (!string.IsNullOrEmpty(GlobalVariables.User))
                return View();
            else
                return RedirectToAction("Login");
        }
        public IActionResult Calendar()
        {
            if (!string.IsNullOrEmpty(GlobalVariables.User))
                return View();
            else
                return RedirectToAction("Login");
        }
        public IActionResult Contacts()
        {
            if (!string.IsNullOrEmpty(GlobalVariables.User))
                return View();
            else
                return RedirectToAction("Login");
        }
        public IActionResult Notes()
        {
            if (!string.IsNullOrEmpty(GlobalVariables.User))
                return View();
            else
                return RedirectToAction("Login");
        }
        public IActionResult Blog()
        {
            if (!string.IsNullOrEmpty(GlobalVariables.User))
                return View();
            else
                return RedirectToAction("Login");
        }
        public IActionResult UploadFile()
        {
            if (!string.IsNullOrEmpty(GlobalVariables.User))
                return View();
            else
                return RedirectToAction("Login");
        }
        

    }
}
