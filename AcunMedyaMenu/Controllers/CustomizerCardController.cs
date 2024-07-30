using AcunMedyaMenu.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AcunMedyaMenu.Controllers
{
    public class CustomizerCardController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-scraper-api2.p.rapidapi.com/v1/info?username_or_id_or_url=https%3A%2F%2Fwww.instagram.com%2Facunmedyaakademi%2F"),
                Headers =
    {
        { "x-rapidapi-key", "a2e9d72138msha7393d48f8ba847p186269jsnd49e10d843c6" },
        { "x-rapidapi-host", "instagram-scraper-api2.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<InstaViewModel>(body);
                return View(values.data);
            }

        }

        public async Task<IActionResult> Finance()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/latest?from=USD&to=TRY"),
                Headers =
    {
        { "x-rapidapi-key", "a2e9d72138msha7393d48f8ba847p186269jsnd49e10d843c6" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<FinanceViewModel>(body);
                return View(values.data);
            }

        }

    }
}
