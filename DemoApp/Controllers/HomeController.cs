using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoApp.Models;

namespace DemoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.ErrorMessage = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            ViewBag.UsernameErrorMessage = "";
            ViewBag.PasswordErrorMessage = "";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.UsernameErrorMessage = string.IsNullOrWhiteSpace(username) ? "Username cannot be empty" : "";
                ViewBag.PasswordErrorMessage = string.IsNullOrWhiteSpace(password) ? "Password cannot be empty" : "";
                return View();
            }

            if (password == "badPassword")
            {
                ViewBag.PasswordErrorMessage = "That password is incorrect";
                return View();
            }

            return RedirectToAction("Index", "Table");
        }
    }
}
