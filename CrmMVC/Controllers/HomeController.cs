using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrmMVC.Models;
using CrmApp.Services;

namespace CrmMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICustomerManager custMangr;

        public HomeController(ILogger<HomeController> logger, ICustomerManager _custMangr)
        {
            _logger = logger;
            custMangr = _custMangr;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        //localhost:port/Home/AddCustomer
        public IActionResult AddCustomer()
        {
            return View();
        }

        //localhost:port/Home/Customers
        public IActionResult Customers()
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
