using WeatherMonitoringSystem.Interfaces;

namespace WeatherMonitoringSystem.Observers{


/// <summary>
/// Create observer for forecast display
/// </summary>
public class ForecastDisplayObserver : IDisplay
{
    private SingletonWeatherData weatherData;

    public ForecastDisplayObserver(SingletonWeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterDisplay(this);
    }

    public void Display()
    {
        // Display weather forecast
        Console.WriteLine("Weather forecast: Winter");
    }
}
}
