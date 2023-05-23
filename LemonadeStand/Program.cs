namespace LemonadeStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Good Morning, for SOLID principles, in the store there is a good example of Open/Closed Principle with the WelcomeToStore method.
            //another good example of this is SellLemons, that is complex code but does one thing really well, sells lemons!
            Console.WriteLine("Welcome to your Lemonade Stand! \nEach day you will get to choose your lemonade recipe and see how much you can sell, \nkeep in mind the weather forecast!");
            Game game = new Game();
        }
    }
}