using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Game
    {
        Player player;
        public List<Day> days;
        private int currentDay;

        public Game() 
        {
            Weather weather = new Weather();
            this.player = new Player();
            this.currentDay = 0;
            for (int i = 0; i < 8; i++)
            {
                weather.DisplayCurrentDay(); 
                StartGame();
            }
            Console.WriteLine($"Congratulations{player.name}! You have won the week with a total of {player.wallet.Money}!");
        }
        public void StartGame()
        {
            
            PurchaseStore();
            player.recipe.DisplayRecipe();
            player.recipe.ChangeRecipe();
            UserInterface.GetNumberOfPitchers();
            SellLemons();
            this.currentDay++;
                          
        }
        public void PurchaseStore()
        {
            Player player = this.player;
            Store store = new Store();
            store.WelcomeToStore(player);
            Console.WriteLine($"\nYou have {player.inventory.lemons.Count} lemons.\nLemons cost 50 cents\n");
            store.SellLemons(player);
            Console.WriteLine($"\nYou have {player.inventory.iceCubes.Count} ice cubes.\nice cubes cost 01 cent\n");
            store.SellIceCubes(player);
            Console.WriteLine($"\nYou have {player.inventory.sugarCubes.Count} sugar cubes.\nsugar cubes cost 10 cents\n");
            store.SellSugarCubes(player);
            Console.WriteLine($"\nYou have {player.inventory.cups.Count} cups.\ncups cost 25  cents\n");
            store.SellCups(player);
            Console.WriteLine($"\nYou now own\n{player.inventory.cups.Count} cups\n{player.inventory.sugarCubes.Count} sugar cubes\n{player.inventory.iceCubes.Count} ice cubes\n{player.inventory.lemons.Count} lemons\n");

        }
        public void SellLemons()
        {
            Day day = new Day();
            int sellCount = 0;
            int totalSales = 0;
            foreach (Customer customer in day.customers)
            {
                if (customer.willingToBuy == true && customer.money > player.recipe.price)
                {
                    sellCount+=player.recipe.price;
                   customer.money -= player.recipe.price;
                    Console.WriteLine("Lemonade sold!");
                    totalSales+=player.recipe.price;

                }           
            }
            day.weather.DisplayEndDayWeather();
            Console.WriteLine($"You have sold a total of ${sellCount} in Lemonade today,\nyou put it in your wallet.");
            player.wallet.AcceptMoney(sellCount);
            sellCount = 0;
            Console.WriteLine($"You have made total so far of {totalSales}");
        }
    }
        
    }
            

    
    

