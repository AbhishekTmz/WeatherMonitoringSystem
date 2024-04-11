using WeatherMonitoringSystem.Interfaces;

namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Create display objects using factory class
    /// </summary>
    public class WeatherStation
    {
        /// <summary>
        /// bbject is displayed on given data type
        /// </summary>
        /// <param name="displayType">type of display to create.</param>
        /// <param name="weatherData">SingletonWeatherData instance.</param>
        /// <returns>created display object.</returns>
        public IDisplay CreateDisplay(string displayType, SingletonWeatherData weatherData)
        {
            switch (displayType)
            {
                case "Currentweather":
                    return new CurrentConditionsDisplay(weatherData);
                case "Statistics":
                    return new StatisticsDisplay(weatherData);
                case "Forecast weather":
                    return new ForecastDisplay(weatherData);
                default:
                    return new CurrentConditionsDisplay(weatherData);
            }
        }
    }
}
