using AcunMedyaMenu.Context;
using AcunMedyaMenu.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaMenu.Controllers
{
    public class NewsletterController : Controller
    {
        MenuContext context = new MenuContext();

        [HttpGet]
        public IActionResult Index()
        {
            var values = context.Subscribers.ToList();
            return View(values);
        }

        public IActionResult DeleteNewsletter(int id)
        {
            var values = context.Subscribers.Find(id);
            context.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe(string fullName, string email)
        {
            if (ModelState.IsValid)
            {
                var subscriber = new Subscriber
                {
                    FullName = fullName,
                    Email = email,
                    SubscribedAt = DateTime.UtcNow
                };

                context.Subscribers.Add(subscriber);
                await context.SaveChangesAsync();

                // Başarılı abonelik sonrası bir bildirim veya yönlendirme yapabilirsiniz
                return RedirectToAction("Index", "Default");
            }

            return View(); // Abonelik başarısız olursa
        }
    }
}
