using AcunMedyaMenu.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaMenu.Context
{
	public class MenuContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=ENES;initial catalog=AcunMedyaMenuDb;integrated security=true;trustServerCertificate=true");
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Chef> Chefs { get; set; }
		public DbSet<Booking> Bookings { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Slider> Sliders { get; set; }
		public DbSet<Food> Foods { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		public DbSet<UserMessage> UserMessages { get; set; }
		public DbSet<Subscriber> Subscribers { get; set; }
	}
}
