using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Day
    {
        public List<Customer> customers;
        public Weather weather;
        WeatherGenerator Weather { get; set; }
        List<Customer> customers { get; set; }

    }
}
