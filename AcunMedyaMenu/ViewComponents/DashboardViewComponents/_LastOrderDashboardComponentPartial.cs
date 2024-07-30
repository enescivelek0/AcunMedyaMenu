using AcunMedyaMenu.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.ViewComponents.DashboardViewComponents
{
	public class _LastOrderDashboardComponentPartial:ViewComponent
	{
		MenuContext context = new MenuContext();
		public IViewComponentResult Invoke()
		{
			var values = context.Orders.ToList();
			return View(values);
		}
	}
}
