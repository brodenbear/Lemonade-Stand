using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Day
    {
        WeatherGenerator Weather { get; set; }
        List<Customer> customers { get; set; }
    }
}
