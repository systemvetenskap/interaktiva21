using DemoInteraktiva.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // smart kod som hämtar från ett api
            // hantera resultatet
            return View();
        }

    }
}
