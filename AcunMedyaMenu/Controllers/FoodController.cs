using AcunMedyaMenu.Context;
using AcunMedyaMenu.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AcunMedyaMenu.Controllers
{
    public class FoodController : Controller
    {
        MenuContext context = new MenuContext();

        public IActionResult Index()
        {
            var values = context.Foods.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateFood()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFood(Food food)
        {
            context.Foods.Add(food);
            context.SaveChanges();
            return RedirectToAction("Index", "Food");
        }

        public IActionResult DeleteFood(int id)
        {
            var value = context.Foods.Find(id);
            context.Foods.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index", "Food");
        }

        [HttpGet]
        public IActionResult UpdateFood(int id)
        {
            var value = context.Foods.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateFood(Food food)
        {
            context.Foods.Update(food);
            context.SaveChanges();
            return RedirectToAction("Index", "Food");
        }

        public IActionResult ToggleActive(int id)
        {
            var food = context.Foods.Find(id);
            if (food != null)
            {
                food.IsActive = !food.IsActive;
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Food");
        }

    }
}
