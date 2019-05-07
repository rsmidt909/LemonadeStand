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
        Player player;
        Game game;



        //Constructor (BUILDS OBJECT)
        public UserInterface()
        {
            instructions = null;
            player = new Player();
            game = new Game();
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

        public void MasterMeth()
        {
            Console.WriteLine("Youre Total Money is " + player.totalMoney);
            player.customer.day.weather.WeatherChooserToday();
            Console.WriteLine("Todays weather will be " + player.customer.day.weather.currentWeather);
            player.customer.day.weather.WeatherChooserTomorrow();
            Console.WriteLine("Tommorow's weather MAY be " + player.customer.day.weather.forecastedWeather);
            Console.WriteLine("The price of lemons are " + player.CostOfLemon + " Dollars");
            player.CheckLemonOrderingMoney();
            game.GameCheck();
            Console.WriteLine("You have " + player.totalMoney + " Dollars left.");
            Console.WriteLine("The price of Sugar cubes are " + player.CostOfSugar + " Dollars");
            player.CheckSugarOrderingMoney();
            game.GameCheck();
            Console.WriteLine("You have " + player.totalMoney + " Dollars left.");
            Console.WriteLine("The price of Ice are " + player.CostOfIce + " Dollars");
            player.CheckIceOrderingMoney();
            game.GameCheck();
            Console.WriteLine("You have " + player.totalMoney + " Dollars left.");
            Console.WriteLine("The price of Cups are " + player.CostOfCup + " Dollars");
            player.CheckCupOrderingMoney();
            game.GameCheck();
            player.CanIMakeLemonade();
            Console.WriteLine("What would you like to set the price of one cup of lemonade?");
            Console.WriteLine("You cannot set the price higher than 2 times the amount that the supplies cost individually.");
            Console.WriteLine("The max set price is " + player.maxPrice + " Dollars.");
            player.SetPurchasePrice();
            Console.Clear();
            Console.WriteLine("Time to sell some Lemonade!");
            player.FlowOfCustomers();
            Console.WriteLine("No more customers for the day!");
            Console.ReadLine();
            player.ProfitFromLemonadeSold();
            player.inventory.Perishable();
            game.StatReset();
            Console.WriteLine("Youre profit for the day is " + player.profit);
            game.GameCheck();
            MasterMeth();

        }




    }
}
