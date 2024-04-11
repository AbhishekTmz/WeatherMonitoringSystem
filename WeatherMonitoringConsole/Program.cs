
namespace WeatherMonitoringSystem;
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create WeatherData singleton instance
            var weatherData = SingletonWeatherData.GetInstance();

            Console.WriteLine("Please enter the type of weather data you would like to display: (current, forecast, statistics)");
            var weatherDataType = Console.ReadLine();

            // Create WeatherStation factory instance
            var weatherStationFactory = new WeatherStationFactory();

            // Create display based on user input
            var display = weatherStationFactory.CreateDisplay(weatherDataType ?? "current", weatherData);

            // Simulate changes in weather data
            SimulateWeatherChanges(weatherData);

            // Display updated weather information
            display.Display();
        }

        static void SimulateWeatherChanges(SingletonWeatherData weatherData)
        {
           
            Random rnd = new Random();
            weatherData.Temperature = rnd.Next(50, 100); // temperature range from 50-100 degrees Fahrenheit
            weatherData.Humidity = rnd.Next(0, 100); //  humidity range from  0-100%
            
        }
    }
}
