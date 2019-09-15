using System;
using Weather.Core;

namespace Weather.Dao
{
    public interface IWeatherData
    {
        WeatherModel GetByLocation(string location);
    }

    public class OwmData : IWeatherData
    {
        WeatherModel weatherModel { get; set; }
        public WeatherModel GetByLocation(string location)
        {
            weatherModel = new WeatherModel(location);

            return null;
        }
    }
}
