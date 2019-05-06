using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {


        //member variables (HAS A)
        string instructions;
        string results;



        //Constructor (BUILDS OBJECT)





        //member methods(CAN DO)
        public void HowToPlay()
        {
            Console.WriteLine("How to play! You'll recieve starting funds, with those funds you must decide how much of Ice, Cups, Lemons, and Sugar you think you will need.");
            Console.WriteLine("Before the start of each day, you will be prompted with the current weather and the next days forcasted waeather.");
            Console.WriteLine("Once the day starts, customers will purchase your lemonade based off of the weather. When the day has ended, you will be shown how much you earned in lemonade sales.");
            Console.WriteLine("Any materials spent on making lemonade but not sold is lost. And if your balance ever reaches zero, then you've goen out of business and lost!");
            Console.WriteLine("How long can you last?");
        }



    }
}
