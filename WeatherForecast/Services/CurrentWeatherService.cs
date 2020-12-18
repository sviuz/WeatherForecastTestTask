using Newtonsoft.Json.Linq;

namespace WeatherForecast.Services
{
    //API for current weather: api.openweathermap.org/data/2.5/weather?q={City name}&appid=a2f739994a3f26504af73970ccd31959
    //API for 5 days weather forecast: api.openweathermap.org/data/2.5/forecast?q={City name}&appid=7e9a815222cd756e1b4a4a9b77c99a0a
    public class CurrentWeatherService
    {
        public static string currentWeather = "api.openweathermap.org/data/2.5/weather?q=Dnipro&appid=a2f739994a3f26504af73970ccd31959";
        public string fiveDaysForecast = "api.openweathermap.org/data/2.5/forecast?q={City name}&appid=a2f739994a3f26504af73970ccd31959";


        //public string GetRespone()
        //{
        //    JObject response = JObject.Parse(new System.Net.WebClient().DownloadString(currentWeather));
        //    return response.ToString();
        //}
    }
}
