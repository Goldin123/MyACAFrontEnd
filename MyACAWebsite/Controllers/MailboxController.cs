using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyACAWebsite.Controllers
{
    public class MailboxController : Controller
    {
        public IActionResult Inbox()
        {
            return View();
        }
        public IActionResult EmailView()
        {
            return View();
        }

        public IActionResult ComposeEmail()
        {
            return View();
        }

        public IActionResult EmailTemplates()
        {
            return View();
        }

    }
}
