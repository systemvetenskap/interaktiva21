using DemoInteraktiva.Models;
using DemoInteraktiva.Models.ViewModels;
using DemoInteraktiva.Repositories;
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
        private IRepository repository;

        // Dependency injection
        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }
        // Dependency inversion

        public async Task<IActionResult> Index()
        {
            // smart kod som hämtar från ett api
            var summary = await repository.GetSummaryAsync();
            var model = new HomeViewModel()
            {
                TotalConfirmed = summary.Global.TotalConfirmed,
                ERik=123
            };
            // hantera resultatet
            return View(model);
        }

    }
}
