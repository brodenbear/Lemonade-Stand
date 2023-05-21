using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  public class TemperatureGenerator
        {
            private Random random;

            public TemperatureGenerator()
            {
                random = new Random();

            }

            public int GenerateRandomTemperature()
            {
                return random.Next(101); // Generates a random number from 0 to 100 
            }

        }
    }
