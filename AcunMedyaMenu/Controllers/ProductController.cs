using AcunMedyaMenu.Context;
using AcunMedyaMenu.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.Controllers
{
    public class ProductController : Controller
    {
        MenuContext context = new MenuContext();
        public IActionResult Index()
        {
            var values = context.Products.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index", "Product");
        }

        public IActionResult DeleteProduct(int id)
        {
            var value = context.Products.Find(id);
            context.Products.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index", "Product");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = context.Products.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
            return RedirectToAction("Index", "Product");
        }

		public IActionResult ToggleActive(int id)
		{
			var product = context.Products.Find(id);
			if (product != null)
			{
				product.IsActive = !product.IsActive;
				context.SaveChanges();
			}
			return RedirectToAction("Index", "Product");
		}
	}
}
