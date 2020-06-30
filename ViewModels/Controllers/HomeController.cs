using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModels.Models;
using ViewModels.ViewModels;

namespace ViewModels.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            Student student = new Student() 
            {
                StudentId = 1,
                Name = "Jan",
                Branch = "Computers",
                Section = "D",
                Gender = "M"
            };

            Address address = new Address() 
            {
                StudentId = 1,
                Country = "Belgium",
                City = "Brussels",
                Street = "Rouppeplein"
            };

            ViewModelStudentAddress vm = new ViewModelStudentAddress()
            {
                Student = student,
                Address = address,
                Title = ".NET generation 2019-2020",
                Schoolname = "Intec"
            };

            return View(vm);
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
