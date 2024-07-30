using AcunMedyaMenu.Context;
using AcunMedyaMenu.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.Controllers
{
    public class ContactController : Controller
    {
        MenuContext context = new MenuContext();

        [HttpGet]
        public IActionResult Index()
        {
            var values = context.UserMessages.ToList();
            return View(values);
        }
       

        [HttpPost]
        public async Task<IActionResult> UserMessage(string fullName, string email,string subject,string message)
        {
            if (ModelState.IsValid)
            {
                var userMessage = new UserMessage
                {
                    Name = fullName,
                    Email = email,
                    Subject = subject,
                    Message = message,
                    CreatedAt = DateTime.UtcNow
                };

                context.UserMessages.Add(userMessage);
                await context.SaveChangesAsync();

                // Başarılı abonelik sonrası bir bildirim veya yönlendirme yapabilirsiniz
                return RedirectToAction("Index", "Default");
            }

            return View(); // Abonelik başarısız olursa
        }
    }
}
