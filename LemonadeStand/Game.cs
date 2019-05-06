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
        bool gameOver;
        public Store store;
        public Player player;
        public UserInterface userInterface;
        public Day day;





        //Constructor (BUILDS OBJECT)
        public Game()
        {
            gameOver = false;
            
        }
        


        //member methods(CAN DO)
        public void GameCheck()
        {
            if (player.totalMoney >= player.costOfSupplies)
            {
                Console.WriteLine("You ran out of money to make a single cup of lemonade! Game Over!");
                gameOver = true;
            } else
            {
                gameOver = false;
            }
        }


        public void MasterMeth()
        {
            Console.WriteLine("Youre Total Money is" + player.totalMoney);
            day.weather.WeatherChooserToday();
            Console.WriteLine("Todays weather will be" + day.weather.currentWeather);
            day.weather.WeatherChooserTomorrow();
            Console.WriteLine("Tommorow's weather MAY be" + day.weather.forecastedWeather);
            player.CheckLemonOrderingMoney();
            GameCheck();
            player.CheckSugarOrderingMoney();
            GameCheck();
            player.CheckIceOrderingMoney();
            GameCheck();
            player.CheckCupOrderingMoney();
            GameCheck();
            player.CanIMakeLemonade();
            player.SetPurchasePrice();
            Console.Clear();
            Console.WriteLine("Time to sell some Lemonade!");
            player.customer.HowMuchThirst();
            player.customer.BuyLemonade();
            player.LemonadePurchased();
            Console.WriteLine("No more customers for the day!");
            player.ProfitFromLemonadeSold();
            Console.WriteLine("Youre profit for the day is "+ player.profit);
            
        }

    }
}
