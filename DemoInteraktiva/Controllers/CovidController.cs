using DemoInteraktiva.Models.ViewModels;
using DemoInteraktiva.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Controllers
{
    public class CovidController : Controller
    {
        private readonly IRepository repository;
        private readonly IConfiguration configuration;

        public CovidController(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            var countries = await repository.GetCountriesAsync();
            var model = new CovidViewModel(countries);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Search(string selectedCountry)
        {
            var countries = await repository.GetCountriesAsync();
            var data = await repository.GetContryTotal(selectedCountry);
            if (data.Count() == 0)
            {
                ModelState.AddModelError("NoContent", "Det finns ingen statistik för det landet");
            }
            var model = new CovidViewModel(countries);
            return View("index", model);
        }
    }
}
