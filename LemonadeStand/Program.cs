using static LemonadeStand.WeatherGenerator;

namespace LemonadeStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                WeatherGenerator weatherGenerator = new WeatherGenerator();

                string randomWeather = weatherGenerator.GenerateRandomWeather();
                Console.WriteLine("Actual Weather: " + randomWeather);

                string forecastedWeather = weatherGenerator.GenerateForecastedWeather();
                Console.WriteLine("Forecasted Weather: " + forecastedWeather);
            }
        }
    }
}