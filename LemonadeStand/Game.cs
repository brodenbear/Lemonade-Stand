using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Game
    {
        private Player player;
        private List<Day> days;
        private int currentDay;

        public Game()
        {

        }
        public void RequestName()
        {
            Player player = new Player();

            player.RequestName();

            Console.WriteLine($"Hello {player.name} and welcome to your Lemonade Stand!\n\nYou are in charge of making a profit. The weather, price and recipe will determine how much you sell.\n\nGood luck!");
        

        }
    }
}
