using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NightsCoffee.Models;
using NightsCoffee.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NightsCoffee.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoffeeRepository _coffeeRepository;

        //constructor injection
        public HomeController(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
           

            var coffees = _coffeeRepository.GetAllCoffees().OrderBy(c => c.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Night's Coffee",
                Coffees = coffees.ToList()
            };


            return View(homeViewModel);
        }
    }
}
