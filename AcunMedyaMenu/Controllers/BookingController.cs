using AcunMedyaMenu.Context;
using AcunMedyaMenu.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaMenu.Controllers
{
	public class BookingController : Controller
	{
		MenuContext context = new MenuContext();
		public IActionResult Index()
		{
			var values = context.Bookings.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateBooking()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateBooking(Booking booking)
		{
			context.Bookings.Add(booking);
			context.SaveChanges();
			return RedirectToAction("Index", "Booking");
		}

		public IActionResult DeleteBooking(int id)
		{
			var value = context.Bookings.Find(id);
			context.Bookings.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index", "Booking");
		}

		[HttpGet]
		public IActionResult UpdateBooking(int id)
		{
			var value = context.Bookings.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateBooking(Booking booking)
		{
			context.Bookings.Update(booking);
			context.SaveChanges();
			return RedirectToAction("Index", "Booking");
		}
	}
}
