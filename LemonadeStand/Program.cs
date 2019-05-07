using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface game = new UserInterface();
            Console.WriteLine("How to play! You'll recieve starting funds, with those funds you must decide how much of ");
            Console.WriteLine("Ice, Cups, Lemons, and Sugar you think you will need.");
            Console.WriteLine("Before the start of each day, you will be prompted with the current weather and the next ");
            Console.WriteLine("days forcasted weather.");
            Console.WriteLine("Once the day starts, customers will purchase your lemonade based off of the weather.");
            Console.WriteLine("When the day has ended, you will be shown how much you earned in lemonade sales.");
            Console.WriteLine("Any materials spent on making lemonade but not sold is lost.");
            Console.WriteLine("And if your balance ever reaches zero, then you've gone out of business and lost!");
            Console.WriteLine("How long can you last?");
            Console.WriteLine("Press enter.....");
            Console.ReadLine();
            game.MasterMeth();
        }
    }
}
