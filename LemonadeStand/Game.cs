using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
        public void StartLemonadeStand()
        {
            Player player = new Player();

            player.RequestName();

            Console.WriteLine($"Hello {player.name} and welcome to your Lemonade Stand!\n\nYou are in charge of making a profit. The weather, price and recipe will determine how much you sell.\n\nGood luck!");
            days = new List<Day>();
            currentDay = 0;
            do
            {
                Day day = new Day();
                day.StartDay();
                currentDay++;
                Console.WriteLine($"Would you like to purchase lemons, ice, cups or sugarcubes in the shop? \nType yes or no");
                string decision = Console.ReadLine();
                if (decision == "yes")
                {
                    Store store = new Store();
                    Console.WriteLine("Please choose what you want to purchase. \n1. Lemons \n2. Ice Cubes \n3. Cups \n4.Sugar Cubes");
                    Console.ReadLine();


                    
                }
                else if (decision == "Yes")
                {
                    Store store = new Store();
                    Console.WriteLine("Please choose what you want to purchase. \n1. Lemons \n2. Ice Cubes \n3. Cups \n4.Sugar Cubes");
                    string purchaseDecision = Console.ReadLine();
                    int purchaseChoice = int.Parse(purchaseDecision);
                    switch (purchaseChoice)
                    {
                        case 1:
                        store.SellLemons(player);
                            break;


                        case 2: 
                    
                        store.SellIceCubes(player);
                            break;

                        case 3:
                                                
                        store.SellCups(player);
                            break;

                        default:
                    
                        store.SellSugarCubes(player);
                            break;
                    
                   
                    
                    
                    }
                }

             
            }
            while (currentDay <= 7);
            {
                Console.WriteLine("End of the week");
            }
        }
    }
}
