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
        public Player player;
        
        



        //Constructor (BUILDS OBJECT)
        public UserInterface()
        {
          
            player = new Player();
            
            
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

        public void StatReset()
        {
            player.cupsOfLemonadeSold = 0;
            player.profit = 0;
        }



        public void MasterMeth()
        {            
            Console.Clear();
            Console.WriteLine("Youre Total Money is " + player.totalMoney);
            Console.WriteLine("Would you like to see just 'Today's weather or the next 'Seven' days?");
            player.customer.day.weather.OneDayOrSeven();
            Console.WriteLine("Press enter....");
            Console.ReadLine();
            Console.Clear();
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
            player.FlowOfCustomers();
            Console.WriteLine("No more customers for the day!");
            Console.ReadLine();
            player.ProfitFromLemonadeSold();
            player.inventory.Perishable();
            StatReset();
            Console.WriteLine("Youre profit for the day is " + player.profit);
            GameCheck();
            MasterMeth();

        }




    }
}
