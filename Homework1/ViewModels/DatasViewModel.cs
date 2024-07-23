using Homework1.Entities;
using System.Collections.Generic;

namespace Homework1.ViewModels
{
    public class DatasViewModel
    {
        public List<Drink> Drinks { get; set; }
        public List<FastFood> FastFoods { get; set; }
        public List<HotMeal> HotMeals { get; set; }
    }
}
