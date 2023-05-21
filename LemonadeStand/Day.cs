using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LemonadeStand.Weather;

namespace LemonadeStand
{
    internal class Day
    {
        List<Customer> customers = new List<Customer>();
        public Weather weather;
        public Day()

        {
            Weather weather = new Weather();
           
        }
        public void StartDay() 
        {
            Weather weather = new Weather();
            TemperatureGenerator temperatureGenerator = new TemperatureGenerator();
            WeatherGenerator weatherGenerator = new WeatherGenerator();

            temperatureGenerator.GenerateRandomTemperature();
            Console.WriteLine("Random Temperature: " + weather.temperature + " degrees");

            weatherGenerator.GenerateForecastedWeather();

            Console.WriteLine("Forecasted Weather: " + weather.condition);

            weatherGenerator.GenerateRandomWeather();

            Console.WriteLine("Today's Weather: " + weather.condition);



        }

    }
}

