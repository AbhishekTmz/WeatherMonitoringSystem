using System.Collections.Generic;
using WeatherMonitoringSystem.Interfaces;

namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Singleton class for weather data.
    /// </summary>
    public class SingletonWeatherData
    {
        private static SingletonWeatherData instance;
        private float temperature;
        private float humidity;
        private float pressure;
        private List<IDisplay> displays = new List<IDisplay>();

        private SingletonWeatherData() { }

        /// <summary>
        /// To get the instance of SingletonWeatherData.
        /// </summary>
        /// <returns>Instance of SingletonWeatherData.</returns>
        public static SingletonWeatherData GetInstance()
        {
            if (instance == null)
            {
                instance = new SingletonWeatherData();
            }
            return instance;
        }

        /// <summary>
        /// Update the data of weather and notify it to observer.
        /// </summary>
        /// <param name="temperature">Temperature value.</param>
        /// <param name="humidity">Humidity value.</param>
        /// <param name="pressure">Pressure value.</param>
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            NotifyObservers();
        }

        /// <summary>
        /// Registers a display to receive weather updates.
        /// </summary>
        /// <param name="display">The display to register.</param>
        public void RegisterDisplay(IDisplay display)
        {
            displays.Add(display);
        }

        /// <summary>
        /// Removes a display from receiving weather updates.
        /// </summary>
        /// <param name="display">The display to remove.</param>
        public void RemoveDisplay(IDisplay display)
        {
            displays.Remove(display);
        }

        private void NotifyObservers()
        {
            foreach (var display in displays)
            {
                display.Display();
            }
        }
    }
}
