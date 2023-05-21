using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {
        public string condition;
        public int temperature;
        public string predictedForecast;
 
        public Weather()
        {

            WeatherGenerator weatherGenerator = new WeatherGenerator();
            TemperatureGenerator temperatureGenerator = new TemperatureGenerator();

            temperature = temperatureGenerator.GenerateRandomTemperature();

            condition = weatherGenerator.GenerateRandomWeather();

            predictedForecast = weatherGenerator.GenerateForecastedWeather();
        }
       

        

       



        }
        

    }



