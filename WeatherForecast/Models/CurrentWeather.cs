using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecast.Models
{
    /// <summary>
    /// Date
    /// Tempreture
    /// Wind speed
    /// Сloudy
    /// </summary>
    public class CurrentWeather
    {
        public DateTime Date { get; set; }
        public int Temprecure { get; set; }
        public double WindSpeed { get; set; }
        public double Cloudy{ get; set; }
    }
}
