using AcunMedyaMenu.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.ViewComponents
{
	public class _MenuListComponentPartial:ViewComponent
	{
		MenuContext context = new MenuContext();
		public IViewComponentResult Invoke()
		{
			var values = context.Products.Where(x => x.IsActive).ToList();
            return View(values);
		}
	}
}
