using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class WeatherGenerator
    {
        public Random random;
        private Random forecastRandom;
        private List<string> weatherConditions;


        public WeatherGenerator()
        {
            weatherConditions = new List<string>
        {
            "raining",
            "cloudy",
            "hazy",
            "clear",
            "hot"
         
        };
            random = new Random();
            forecastRandom = new Random();
        }
        public string GenerateRandomWeather()
        {
            TemperatureGenerator temperatureGenerator = new TemperatureGenerator();
            int temperature = temperatureGenerator.GenerateRandomTemperature();

            if (temperature <= 22) 
            { 
            return weatherConditions[2];
            }
            else if (temperature > 22 && temperature <= 45)
            { 
                return weatherConditions[0];
            }
            else if (temperature > 45 && temperature <= 60)
            {
                return weatherConditions[1];
            }
            else if (temperature > 60 && temperature <= 75)
            {
                return weatherConditions[3];                           
            }
            else 
            {
                return weatherConditions[4];
            }
        }


        public string GenerateForecastedWeather()
        {
            if (forecastRandom.Next(10) < 8) // 80% chance of mostly accurate forecast
            {
                return GenerateRandomWeather();
            }
            else // 20% chance of different weather in forecast
            {
                return GenerateForecastedWeather();
            }
        }
    }
}
