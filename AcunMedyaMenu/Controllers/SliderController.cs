using AcunMedyaMenu.Context;
using AcunMedyaMenu.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.Controllers
{
    public class SliderController : Controller
    {
        MenuContext context = new MenuContext();
        public IActionResult Index()
        {
            var values = context.Sliders.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSlider(Slider slider)
        {
            context.Sliders.Add(slider);
            context.SaveChanges();
            return RedirectToAction("Index", "Slider");
        }

        public IActionResult DeleteSlider(int id)
        {
            var value = context.Sliders.Find(id);
            context.Sliders.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index", "Slider");
        }

        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            var value = context.Sliders.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSlider(Slider slider)
        {
            context.Sliders.Update(slider);
            context.SaveChanges();
            return RedirectToAction("Index", "Slider");
        }
    }
}
