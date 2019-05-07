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
        public Player player;
        public string response;
        public int lemonNumber;
        public int sugarNumber;
        public int iceNumber;
        
        



        //Constructor (BUILDS OBJECT)
        public UserInterface()
        {
          
            player = new Player();
            response = null;
            lemonNumber = 0;
            sugarNumber = 0;
            iceNumber = 0;
            
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

        public void AmountOfCustomersForDay()
        {
            player.amountOfCustomers = player.customer.day.weather.RandomNumber(0, 100);
        }

        public void WhoMakesRecipe()
        {
            Console.WriteLine("Would you like to make the recipe, 'Yes' or 'No'");
            string recipeDecision = Console.ReadLine();
            switch (recipeDecision)
            {
                case "Yes":
                    MakePlayerRecipe();
                    CanIMakePlayerRecipeLemonade();
                    break;
                case "No":
                    player.CanIMakeLemonade();
                    break;
                default:
                    Console.WriteLine("That is not an option, please try again.");
                    WhoMakesRecipe();
                    break;
            }
        }

        public void CanIMakePlayerRecipeLemonade()
        {
            player.inventory.CheckSupplies();
            if (player.inventory.supplies == false)
            {
                Console.WriteLine("You have made " + player.inventory.cupsOfLemonade + " cups of Lemonade.");
            }
            else
            {
                PlayerRecipe();
                CanIMakePlayerRecipeLemonade();
            }
        }


        public void PlayerRecipe()
        {
            player.inventory.lemons=-lemonNumber;
            player.inventory.sugar=-sugarNumber;
            player.inventory.ice=-iceNumber;
            player.inventory.cups--;
            player.inventory.cupsOfLemonade++;
        }

        public void PlayerRecipeLemons()
        {
            Console.WriteLine("How many lemons would you like to go into your recipe?");
            response = Console.ReadLine();
            lemonNumber = int.Parse(response);
        }
        public void LemonCheck()
        {
            if(lemonNumber == 0)
            {
                Console.WriteLine("You need atleast 1 in your recipe. Please Try again.");
                PlayerRecipeLemons();
            }
        }
        public void PlayerRecipeSugar()
        {
            Console.WriteLine("How many Sugar Cubes would you like to go into your recipe?");
            response = Console.ReadLine();
            sugarNumber = int.Parse(response);
        }
        public void SugarCheck()
        {
            if (sugarNumber == 0)
            {
                Console.WriteLine("You need atleast 1 in your recipe. Please Try again.");
                PlayerRecipeSugar();
            }
        }
        public void PlayerRecipeIce()
        {
            Console.WriteLine("How many Ice cubes would you like to go into your recipe?");
            response = Console.ReadLine();
            iceNumber = int.Parse(response);
        }
        public void IceCheck()
        {
            if (iceNumber == 0)
            {
                Console.WriteLine("You need atleast 1 in your recipe. Please Try again.");
                PlayerRecipeIce();
            }
        }
        
        public void MakePlayerRecipe()
        {
            PlayerRecipeLemons();
            LemonCheck();
            PlayerRecipeSugar();
            SugarCheck();
            PlayerRecipeIce();
            IceCheck();
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
            WhoMakesRecipe();
            Console.WriteLine("What would you like to set the price of one cup of lemonade?");
            Console.WriteLine("You cannot set the price higher than 2 times the amount that the supplies cost individually.");
            Console.WriteLine("The max set price is " + player.maxPrice + " Dollars.");
            Console.WriteLine("*Tip* If you set the price too high, you will have a lower cance of lemonade being purchased! *Tip*");
            player.SetPurchasePrice();
            player.PriceTooHigh();
            Console.Clear();
            Console.WriteLine("Time to sell some Lemonade!");
            AmountOfCustomersForDay();
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
