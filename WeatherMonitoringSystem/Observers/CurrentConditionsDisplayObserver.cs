
// using WeatherMonitoringSystem;

using WeatherMonitoringSystem.Interfaces;

namespace WeatherMonitoringSystem.Observers
{


/// <summary>
/// Create observe for current weather display
/// </summary>
public class CurrentConditionsDisplayObserver : IDisplay
{
    private SingletonWeatherData weatherData;

    public CurrentConditionsDisplayObserver(SingletonWeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterDisplay(this);
    }

    public void Display()
    {
        // Current weather situations to be displayed
        Console.WriteLine($"Current conditions: {weatherData.Temperature}F degrees and {weatherData.Humidity}% humidity");
    }
}
}
