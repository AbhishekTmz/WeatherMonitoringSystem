using WeatherMonitoringSystem.Interfaces;

namespace WeatherMonitoringSystem.Observers{

/// <summary>
/// Observer for weather statistics display.
/// </summary>
public class StatisticsDisplayObserver : IDisplay
{
    private SingletonWeatherData weatherData;

    public StatisticsDisplayObserver(SingletonWeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterDisplay(this);
    }

    public void Display()
    {
        // Display weather statistics
        Console.WriteLine($"Weather statistics: Temperature: {weatherData.Temperature}, Humidity: {weatherData.Humidity}, Pressure: {weatherData.Pressure}");
    }
}
}