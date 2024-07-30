//using System.Net.Http;
//using System.Text.Json;
//using System.Threading.Tasks;
//using AcunMedyaMenu.Models;

//public class WeatherService
//{
//    private readonly HttpClient _httpClient;

//    public WeatherService(HttpClient httpClient)
//    {
//        _httpClient = httpClient;
//    }

//    //public async Task<WeatherViewModel> GetWeatherAsync(string city)
//    //{
//    //    var request = new HttpRequestMessage
//    //    {
//    //        Method = HttpMethod.Get,
//    //        RequestUri = new Uri($"https://weather-api-by-any-city.p.rapidapi.com/weather/{city}"),
//    //        Headers =
//    //        {
//    //            { "x-rapidapi-key", "a2e9d72138msha7393d48f8ba847p186269jsnd49e10d843c6" },
//    //            { "x-rapidapi-host", "weather-api-by-any-city.p.rapidapi.com" },
//    //        },
//    //    };

//    //    using (var response = await _httpClient.SendAsync(request))
//    //    {
//    //        response.EnsureSuccessStatusCode();
//    //        var body = await response.Content.ReadAsStringAsync();
//    //        var weatherData = JsonSerializer.Deserialize<WeatherViewModel>(body);
//    //        return weatherData;
//    //    }
//    }
//}
