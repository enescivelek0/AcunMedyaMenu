using AcunMedyaMenu.Context;
using AcunMedyaMenu.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.Controllers
{
    public class ChefController : Controller
    {
        MenuContext context = new MenuContext();
        public IActionResult Index()
        {
            var values = context.Chefs.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateChef()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateChef(Chef chef)
        {
            context.Chefs.Add(chef);
            context.SaveChanges();
            return RedirectToAction("Index", "Chef");
        }

        public IActionResult DeleteChef(int id)
        {
            var value = context.Chefs.Find(id);
            context.Chefs.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index", "Chef");
        }

        [HttpGet]
        public IActionResult UpdateChef(int id)
        {
            var value = context.Chefs.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateChef(Chef chef)
        {
            context.Chefs.Update(chef);
            context.SaveChanges();
            return RedirectToAction("Index", "Chef");
        }
    }
}
