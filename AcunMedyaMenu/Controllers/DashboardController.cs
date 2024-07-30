using AcunMedyaMenu.Context;
using AcunMedyaMenu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AcunMedyaMenu.Controllers
{
    public class DashboardController : Controller
    {
        MenuContext context = new MenuContext();
        public IActionResult Index()
        {
            return View();
        }

        // İstatistik Sayfası
        public IActionResult Statistics()
        {
            // Veri tabanından çekilen istatistikler
            ViewBag.productCount = context.Products.Count();
            ViewBag.chefCount = context.Chefs.Count();
            ViewBag.bookingCount = context.Bookings.Count();
            ViewBag.orderCount = context.Orders.Count();
            ViewBag.sliderCount = context.Sliders.Count();
            ViewBag.foodCount = context.Foods.Count();
            ViewBag.testimonialCount = context.Testimonials.Count();
            ViewBag.userMessageCount = context.UserMessages.Count();
            ViewBag.subscriberCount = context.Subscribers.Count();

            // Veri tabanından çekilen diğer istatistikler
            ViewBag.activeProductCount = context.Products.Where(x => x.Status == true).Count();
            ViewBag.avgProductPrice = context.Products.Average(x => x.Price);

            // Rastgele oluşturulan istatistikler
            Random rnd = new Random();
            ViewBag.visitors = rnd.Next(1000, 5000); // Örnek olarak rastgele bir sayı
            ViewBag.usersOnline = rnd.Next(10, 100); // Örnek olarak rastgele bir sayı
            ViewBag.newOrders = rnd.Next(1, 50); // Yeni sipariş sayısı
            ViewBag.dailyEarnings = rnd.Next(1000, 10000); // Günlük kazançlar
            ViewBag.newSubscribers = rnd.Next(1, 20); // Yeni aboneler

            return View();
        }



        // Geri Bildirim Sayfası
        public async Task<IActionResult> Feedback()
        {
            var messages = await context.UserMessages.ToListAsync();
            return View(messages);
        }

        

    }
}
