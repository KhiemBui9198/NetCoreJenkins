﻿using Microsoft.AspNetCore.Mvc;
using NetCoreJenkins.Models;
using System.Diagnostics;

namespace NetCoreJenkins.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index( Employee employee)
        {
            ViewBag.Formvalue = string.Format("Form Field Value is : {0} {1} {2}", employee.FirstName, employee.LastName, employee.Address);
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}