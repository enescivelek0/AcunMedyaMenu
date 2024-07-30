using AcunMedyaMenu.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AcunMedyaMenu.ViewComponents
{
    public class _FoodComponenetPartial : ViewComponent
    {
        MenuContext context = new MenuContext();

        public IViewComponentResult Invoke()
        {
            // Yalnızca aktif olan yiyecekleri listele
            var values = context.Foods.Where(x => x.IsActive).ToList();
            return View(values);
        }
    }
}
