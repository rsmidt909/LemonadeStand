using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LemonadeStand
{
    class Player
    {


        //member variables (HAS A)
        public Inventory inventory;
        public int CostOfLemon;
        public int CostOfSugar;
        public int CostOfIce;
        public int CostOfCup;
        public int totalMoney;
        public int profit;
        string response;
        public Customer customer;
        public int costOfSupplies;
        public int maxPrice;
        int priceofLemonade;
        public int cupsOfLemonadeSold;
        public int amountOfCustomers;





        //Constructor (BUILDS OBJECT)
        public Player()
        {
            inventory = new Inventory();
            customer = new Customer();           
            CostOfCup = 1;
            CostOfIce = 1;
            CostOfSugar = 2;
            CostOfLemon = 5;
            totalMoney = 100;
            costOfSupplies = CostOfCup + CostOfIce + CostOfSugar + CostOfLemon;
            maxPrice = costOfSupplies * 2;
            profit = 0;
            cupsOfLemonadeSold = 0;
            priceofLemonade = 0;
            amountOfCustomers = 30;

        }



        //member methods(CAN DO)
        public void MakeLemonade()
        {
            inventory.lemons--;
            inventory.sugar =-2;
            inventory.ice =- 2;
            inventory.cups--;
            inventory.cupsOfLemonade++;          
           
        }

        public void CanIMakeLemonade()
        {
            inventory.CheckSupplies();
             if (inventory.supplies == false)
            {
                Console.WriteLine("You have made " + inventory.cupsOfLemonade + " cups of Lemonade.");
            } else
            {
                MakeLemonade();
                CanIMakeLemonade();
            }
        }
        //---------------------------------------------------------------------------------
        public void CheckLemonOrderingMoney()
        {
            if(totalMoney < CostOfLemon)
            {
                Console.WriteLine("You dont have enough money to order any lemons");    
            } else { OrderLemons(); }
        }

        public void OrderLemons()
        {
            
            Console.WriteLine("How many Lemons would you like to purchase?");
            response = Console.ReadLine();
            inventory.lemons = int.Parse(response);
            totalMoney = totalMoney - (int.Parse(response) * CostOfLemon);
        }
        //--------------lemons---------------------------------------------------------------------
        public void CheckSugarOrderingMoney()
        {
            if (totalMoney < CostOfSugar)
            {
                Console.WriteLine("You dont have enough money to order any Sugar");
            }
            else { OrderSugar(); }
        }

        public void OrderSugar()
        {
            Console.WriteLine("How many cubes of Sugar would you like to purchase?");
            response = Console.ReadLine();
            inventory.sugar = int.Parse(response);
            totalMoney = totalMoney - (int.Parse(response) * CostOfSugar);
        }
        //-------------Sugar-----------------------------------------------------------------------

        public void CheckIceOrderingMoney()
        {
            if (totalMoney < CostOfIce)
            {
                Console.WriteLine("You dont have enough money to order any Ice");
            }
            else { OrderIce(); }
        }

        public void OrderIce()
        {
            Console.WriteLine("How many cubes of Ice would you like to purchase?");
            response = Console.ReadLine();
            inventory.ice = int.Parse(response);
            totalMoney = totalMoney - (int.Parse(response) * CostOfIce);
        }

        //-----------Ice-------------------------------------------------------------

        public void CheckCupOrderingMoney()
        {
            if (totalMoney < CostOfCup)
            {
                Console.WriteLine("You dont have enough money to order any Cups");
            }
            else { OrderCup(); }
        }

        public void OrderCup()
        {
            Console.WriteLine("How many Cups would you like to purchase?");
            response = Console.ReadLine();
            inventory.cups = int.Parse(response);
            totalMoney = totalMoney - (int.Parse(response) * CostOfCup);
        }

        //------------Cups-----------------------------------------------------------

        public void LemonadePurchased()
        {
            if (customer.purchaseLemonade == true & inventory.cupsOfLemonade > 0)
            {
                inventory.cupsOfLemonade--;
                totalMoney = totalMoney + priceofLemonade;
                Console.WriteLine("Someone bought a cup of Lemonade!");
            }
        }

        public void SetPurchasePrice()
        {
            response = Console.ReadLine();
            priceofLemonade = int.Parse(response);
            if (priceofLemonade > maxPrice)
            {
                Console.WriteLine("That price is higher than the allowed limit, please try again.");
                SetPurchasePrice();
            }
        }

        public void ProfitFromLemonadeSold()
        {            
                profit = profit+(cupsOfLemonadeSold * priceofLemonade);                         
        }

        public void FlowOfCustomers()
        {
            for (int i = 0; i < amountOfCustomers; i++)
            {
                customer.HowMuchThirst();
                customer.BuyLemonade();
                LemonadePurchased();
                CupsOfLemonadeSold();
                Thread.Sleep(1000);
            }
        }

        public void CupsOfLemonadeSold()
        {
            if (customer.purchaseLemonade == true)
            {
                cupsOfLemonadeSold++;               
            }
        }

        



    }   
        
        
    
}
