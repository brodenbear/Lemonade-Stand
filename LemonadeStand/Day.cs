using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Day
    {
        List<Customer> customers;   
        public Weather weather;

        public Day() 
        
        {

            Weather weather = new Weather();

            string randomWeather = weather.GenerateRandomWeather();
            Console.WriteLine("Random Weather: " + randomWeather);

            string forecastedWeather = weather.GenerateForecastedWeather();
            Console.WriteLine("Forecasted Weather: " + forecastedWeather);


        }

    }
}
