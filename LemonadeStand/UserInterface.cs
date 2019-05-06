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
        public string instructions;




        //Constructor (BUILDS OBJECT)
        public UserInterface()
        {
            instructions = null;
        }




        //member methods(CAN DO)
        public string HowToPlay()
        {
            instructions = ("How to play! You'll recieve starting funds, with those funds you must decide how much of Ice, Cups, Lemons, and Sugar you think you will need." +
            "Before the start of each day, you will be prompted with the current weather and the next days forcasted waeather."+
            "Once the day starts, customers will purchase your lemonade based off of the weather. When the day has ended, you will be shown how much you earned in lemonade sales."+
            "Any materials spent on making lemonade but not sold is lost. And if your balance ever reaches zero, then you've goen out of business and lost!"+
            "How long can you last?");
            return instructions;
        }



    }
}
