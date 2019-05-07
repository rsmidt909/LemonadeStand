using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LemonadeStand
{
    class Game
    {

        //member variables (HAS A)
        
        public Store store;
        public Player player;
        public UserInterface userInterface;              
        public int amountOfCustomers;
        
        




        //Constructor (BUILDS OBJECT)
        public Game()
        {
            
            amountOfCustomers = 30;
            store = new Store();
            player = new Player();
            userInterface = new UserInterface();
            
            


        }
        


        //member methods(CAN DO)
        public void GameCheck()
        {
            if (player.totalMoney <= player.costOfSupplies)
            {
                Console.WriteLine("You ran out of money to make a single cup of lemonade! Game Over!");
                Console.ReadLine();
                Environment.Exit(0);
            } 
        }

        
        public void FlowOfCustomers()
        {
            for(int i = 0; i < amountOfCustomers; i++)
            {
                player.customer.HowMuchThirst();
                player.customer.BuyLemonade();
                player.LemonadePurchased();
                Thread.Sleep(1000);
            }
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
            GameCheck();
            Console.WriteLine("You have " + player.totalMoney + " Dollars left.");
            Console.WriteLine("The price of Sugar cubes are " + player.CostOfSugar + " Dollars");
            player.CheckSugarOrderingMoney();
            GameCheck();
            Console.WriteLine("You have " + player.totalMoney + " Dollars left.");
            Console.WriteLine("The price of Ice are " + player.CostOfIce + " Dollars");
            player.CheckIceOrderingMoney();
            GameCheck();
            Console.WriteLine("You have " + player.totalMoney + " Dollars left.");
            Console.WriteLine("The price of Cups are " + player.CostOfCup + " Dollars");
            player.CheckCupOrderingMoney();
            GameCheck();
            player.CanIMakeLemonade();
            Console.WriteLine("What would you like to set the price of one cup of lemonade?");
            Console.WriteLine("You cannot set the price higher than 2 times the amount that the supplies cost individually.");
            Console.WriteLine("The max set price is " + player.maxPrice + " Dollars.");
            player.SetPurchasePrice();
            Console.Clear();
            Console.WriteLine("Time to sell some Lemonade!");
            FlowOfCustomers();
            Console.WriteLine("No more customers for the day!");
            Console.ReadLine();
            player.ProfitFromLemonadeSold();
            Console.WriteLine("Youre profit for the day is "+ player.profit);
            GameCheck();
            MasterMeth();
            
        }

    }
}
