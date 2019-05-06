using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {

        //member variables (HAS A)
        
        public Store store;
        public Player player;
        public UserInterface userInterface;
        public Day day;        
        public int amountOfCustomers;
        public static System.Timers.Timer aTimer;




        //Constructor (BUILDS OBJECT)
        public Game()
        {
            
            amountOfCustomers = 30;
            store = new Store();
            player = new Player();
            userInterface = new UserInterface();
            day = new Day();


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

        public void Timer()
        {
            aTimer = new System.Timers.Timer(1000);
        }
        public void FlowOfCustomers()
        {
            for(int i = 0; i < amountOfCustomers; i++)
            {
                player.customer.HowMuchThirst();
                player.customer.BuyLemonade();
                player.LemonadePurchased();
                Timer();
            }
        }

        public void MasterMeth()
        {
            Console.WriteLine("Youre Total Money is " + player.totalMoney);
            day.weather.WeatherChooserToday();
            Console.WriteLine("Todays weather will be " + day.weather.currentWeather);
            day.weather.WeatherChooserTomorrow();
            Console.WriteLine("Tommorow's weather MAY be " + day.weather.forecastedWeather);
            Console.WriteLine("The price of lemons are " + player.CostOfLemon);
            player.CheckLemonOrderingMoney();
            GameCheck();
            Console.WriteLine("The price of Sugar cubes are " + player.CostOfSugar);
            player.CheckSugarOrderingMoney();
            GameCheck();
            Console.WriteLine("The price of Ice are " + player.CostOfIce);
            player.CheckIceOrderingMoney();
            GameCheck();
            Console.WriteLine("The price of Cups are " + player.CostOfCup);
            player.CheckCupOrderingMoney();
            GameCheck();
            player.CanIMakeLemonade();
            player.SetPurchasePrice();
            Console.Clear();
            Console.WriteLine("Time to sell some Lemonade!");
            FlowOfCustomers();
            Console.WriteLine("No more customers for the day!");
            player.ProfitFromLemonadeSold();
            Console.WriteLine("Youre profit for the day is "+ player.profit);
            GameCheck();
            MasterMeth();
            
        }

    }
}
