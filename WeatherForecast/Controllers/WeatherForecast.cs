using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Models;

namespace WeatherForecast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class WeatherForecast : ControllerBase
    {
        private readonly CurrentWeather _currentWeather;

        public WeatherForecast(CurrentWeather currentWeather)
        {
            _currentWeather = currentWeather;
        }

        

    }
}
