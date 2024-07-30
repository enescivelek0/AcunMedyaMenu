using AcunMedyaMenu.Context;
using AcunMedyaMenu.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AcunMedyaMenu.Controllers
{
    public class DefaultController : Controller
    {
        MenuContext _context = new MenuContext();

        public IActionResult Index()
        {
            ViewBag.p1 = "Rezervasyon yapmanız yeterli";
            ViewBag.p2 = "Rezervasyon yapmanız yeterli 2";

            var activeFoods = _context.Foods.Where(f => f.IsActive).ToList();
            ViewBag.ActiveFoods = activeFoods; // Aktif yiyecekleri ViewBag ile gönderiyoruz

            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialTeam()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }

        // Booking Alanı
        [HttpGet]
        public PartialViewResult CreateBooking()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult CreateBooking(Booking booking)
        {
            booking.Description = "Rezervasyon Alındı";
            _context.Bookings.Add(booking);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // PartialContact partial view için GET isteği
        public IActionResult PartialContact()
        {
            return PartialView();
        }

        // Form verilerini işlemek için POST isteği
        [HttpPost]
        public async Task<IActionResult> SendMessage(UserMessage model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.UserMessages.Add(model);
                    await _context.SaveChangesAsync();
                    // Başarıyla kaydedildikten sonra bir geri bildirim gösterebilir veya yönlendirebilirsiniz
                    return RedirectToAction("Index", "Home"); // Yönlendirme yapabilirsiniz
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Mesaj gönderilirken bir hata oluştu: " + ex.Message);
                }
            }

            // Hatalar durumunda formu tekrar yükle
            return PartialView("PartialContact", model);
        }

    }
}
