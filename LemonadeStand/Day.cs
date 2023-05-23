using LemonadeStand;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Day
    {
        public List<Customer> customers;
        public Weather weather;

        public Day()
        {
            this.weather = new Weather();
             this.customers = new List<Customer>()
            {
                new Customer(false, 20),
                new Customer(true, 20),
                new Customer(false, 20),
                new Customer(true, 20),
                new Customer(false, 20),
                new Customer(true, 20),
                new Customer(false, 20),
                new Customer(true, 20),
                new Customer(false, 20),
                new Customer(true, 20),
                new Customer(false, 10),
                new Customer(true, 10),
                new Customer(false, 10),
                new Customer(true, 10),
                new Customer(false, 10),

            };
            GenerateHype();
        }
        public void GenerateHype()
        {
            if (weather.condition == "Sunny")
            {
                foreach (Customer customer in customers)
                {
                    customer.willingToBuy = true;
                }
            }
            else if (weather.condition == "Cloudy")
            {
                new Customer(false, 5);
                new Customer(true, 5);
                new Customer(true, 5);
            }
            else if (weather.condition == "Raining")
            {
                new Customer(false, 0);
                new Customer(false, 0);
                new Customer(true, 0);
            }
            else if (weather.condition == "Snowing")
            {
                foreach (Customer customer in customers)
                {
                    customer.willingToBuy = false;
                }
            }

            else
            {
                foreach (Customer customer in customers)
                {
                    customer.willingToBuy = true;
                }

            }
        }
    }
}
    


