using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Recipe
    {
        // member variables (HAS A)
        public int numberOfLemons;
        public int numberOfSugarCubes;
        public int numberOfIceCubes;
        public int price;


        // constructor (SPAWNER)
        public Recipe()
        {
            numberOfLemons = 2;
            numberOfSugarCubes = 4;
            numberOfIceCubes = 10;
            price = 1;
        }

        //Member Methods (CAN DO)
        public void DisplayRecipe()
        {
            Console.WriteLine($"Your recipe currently consists of:\n{numberOfLemons} lemons per pitcher\n{numberOfSugarCubes} sugar cubes per pitcher\n{numberOfIceCubes} ice cubes per pitcher");
        }
        public void ChangeRecipe()
        {
            int lemonFromInventory = numberOfLemons;
            int sugarCubeFromInventory = numberOfSugarCubes;
            int iceCubeFromInventory = numberOfIceCubes;
            int cupFromInventory = 0;
            Inventory inventory = new Inventory();
            {
                bool userInputIsAnInteger = false;
                int quantityOfItem = -1;

                while (!userInputIsAnInteger || quantityOfItem < 0)
                {
                    Console.WriteLine($"Each pitcher has {numberOfLemons} lemons. How many lemons would you like to have in your recipe?");

                    userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
                }

                numberOfLemons = quantityOfItem;
                lemonFromInventory += quantityOfItem;
            }
            {
                bool userInputIsAnInteger = false;
                int quantityOfItem = -1;

                while (!userInputIsAnInteger || quantityOfItem < 0)
                {
                    Console.WriteLine($"Each pitcher has {numberOfSugarCubes} sugar cubes. How many sugar cubes would you like to have in your recipe?");

                    userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
                }

                numberOfSugarCubes = quantityOfItem;
                sugarCubeFromInventory += quantityOfItem;
            }
            {
                bool userInputIsAnInteger = false;
                int quantityOfItem = -1;

                while (!userInputIsAnInteger || quantityOfItem < 0)
                {
                    Console.WriteLine($"Each pitcher has {numberOfIceCubes} ice cubes. How many ice cubes would you like to have in your recipe?");

                    userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
                }

                numberOfIceCubes = quantityOfItem;
                iceCubeFromInventory += quantityOfItem;
            }
            {
                bool userInputIsAnInteger = false;
                int quantityOfItem = -1;

                while (!userInputIsAnInteger || quantityOfItem < 0)
                {
                    Console.WriteLine($"Each cup costs ${price}. How much would you like to sell each cup for?");

                    userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
                }

                price = quantityOfItem;
                cupFromInventory += 8;
                inventory.RecipeChosen(cupFromInventory, iceCubeFromInventory, sugarCubeFromInventory, lemonFromInventory);
            }
          
        }
     }
}
