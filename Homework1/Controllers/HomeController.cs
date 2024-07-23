using Homework1.Entities;
using Homework1.Models;
using Homework1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Homework1.Controllers
{
    public class HomeController : Controller
    {
        List<Drink> drinks = new List<Drink>
            {
                new Drink()
                {
                    Id = 1,
                    Name = "Drink1",
                    Description = "First Drink",
                },
                new Drink()
                {
                    Id = 2,
                    Name = "Drink2",
                    Description = "Second Drink",
                },
                new Drink()
                {
                    Id = 3,
                    Name = "Drink3",
                    Description = "Third Drink",
                }
            };
        List<FastFood> fastFoods = new List<FastFood>
            {
                new FastFood()
                {
                    Id = 1,
                    Name = "Fast Food1",
                    Description = "First Fast Food",
                },
                new FastFood()
                {
                    Id = 2,
                    Name = "Fast Food2",
                    Description = "Second Fast Food",
                },
                new FastFood()
                {
                    Id = 3,
                    Name = "Fast Food3",
                    Description = "Third Fast Food",
                }
            };
        List<HotMeal> hotMeals = new List<HotMeal>
            {
                new HotMeal()
                {
                    Id = 1,
                    Name = "Hot Meal1",
                    Description = "First Hot Meal",
                },
                new HotMeal()
                {
                    Id = 2,
                    Name = "Hot Meal2",
                    Description = "Second Hot Meal",
                },
                new HotMeal()
                {
                    Id = 3,
                    Name = "Hot Meal3",
                    Description = "Third Hot Meal",
                }
            };

        public IActionResult Index()
        {

            var viewModel = new DatasViewModel()
            {
                Drinks = drinks,
                HotMeals = hotMeals,
                FastFoods = fastFoods
            };


            return View(viewModel);

        }


        public IActionResult Drink()
        {
            return View(drinks);
        }
        public IActionResult FastFood()
        {
            return View(fastFoods);
        }
        public IActionResult HotMeal()
        {
            return View(hotMeals);
        }



    }
}
