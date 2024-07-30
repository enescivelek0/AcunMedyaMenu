//using Microsoft.AspNetCore.Mvc;
//using System.Threading.Tasks;
//using AcunMedyaMenu.Models;

//namespace AcunMedyaMenu.ViewComponents.DashboardViewComponents
//{
//    public class _WeatherDashboardComponentPartial : ViewComponent
//    {
//        private readonly WeatherService _weatherService;

//        public _WeatherDashboardComponentPartial(WeatherService weatherService)
//        {
//            _weatherService = weatherService;
//        }

//        public async Task<IViewComponentResult> InvokeAsync(string city)
//        {
//            var weatherData = await _weatherService.GetWeatherAsync(city);
//            return View(weatherData);
//        }
//    }
//}
