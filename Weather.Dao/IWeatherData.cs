using System;
using Weather.Core;

namespace Weather.Dao
{
    public interface IWeatherData
    {
        WeatherModel GetByLocation(string location);
    }
}
