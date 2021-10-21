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
            try
            {
                 var task2 = repository.GetCountriesAsync(); // 5 min
                 var task1 = repository.GetSummaryAsync(); // 20 min

            await Task.WhenAll(task1, task2);

            var summary = await task1;
            var countries = await task2;
            var model = new HomeViewModel(summary);
            
             // hantera resultatet
            return View(model);
            }
            catch (System.Exception)
            {
                var model = new HomeViewModel();
                ModelState.AddModelError(string.Empty, "Fick inte kontakt med Covidstatistiken, visar istället gårdagens siffror");
                return View(model);
                throw;
            }
            


           
           
           
        }

    }
}
