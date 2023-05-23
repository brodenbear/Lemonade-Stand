using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {
        public string condition;
        public int temperature;
        List<string> weatherConditions = new List<string>
        {
            "Sunny" ,
            "Cloudy",
            "Raining",
            "Snowing",
            "Hot"
        };
        public string predictedForecast;
        private Random random;

        public Weather() 
        {
            GenerateRandomWeather();
        }
        public void GenerateRandomWeather()
        {
            random = new Random();
          temperature = random.Next(101); // Generates a random number from 0 to 100 

            if (temperature <= 22)
            {
                condition = weatherConditions[3];
                predictedForecast = weatherConditions[3];
            }
            else if (temperature > 22 && temperature <= 45)
            {
                condition = weatherConditions[2];
                predictedForecast = weatherConditions[2];
            }
            else if (temperature > 45 && temperature <= 60)
            {
                condition = weatherConditions[1];
                predictedForecast = weatherConditions[0];
            }
            else if (temperature > 60 && temperature <= 75)
            {
                condition = weatherConditions[1];
                predictedForecast = weatherConditions[0];

            }
            else
            {
                condition = weatherConditions[4];
                predictedForecast = weatherConditions[4];
            }

        }
        public void DisplayCurrentDay() 
        { 
            Console.WriteLine($"Today's temperature is {temperature} degrees, and it is predicted to be {predictedForecast}");
        }
        public void DisplayEndDayWeather()
        {
            Console.WriteLine($"It turned out to be {condition} today");
        }
    }
    
    
    }
    

