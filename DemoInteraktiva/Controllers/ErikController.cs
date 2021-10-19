using DemoInteraktiva.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInteraktiva.Controllers
{
    public class ErikController : Controller
    {
        public IActionResult Index()
        {
            // ViewData - dictionary
            // ViewBag - dynamisk property
            // TempData - session skicka data mellan controllers
            // Todo: Fixa så att vi kan hämta data = model från metoder,
            // men gör att de blir abstrakta och uppfyller SOLID

            // var result = repo.GetConfirmedCases();
            return View();
        }
    }
}
