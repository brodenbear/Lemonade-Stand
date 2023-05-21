﻿using System;
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
            "snowing",
            "clear",
            "hot"
         
        };
            random = new Random();
            forecastRandom = new Random();
        }
        public string GenerateRandomWeather()
        {
            int index = random.Next(weatherConditions.Count);
            return weatherConditions[index];
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