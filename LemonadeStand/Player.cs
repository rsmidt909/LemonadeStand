using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {


        //member variables (HAS A)
        string recipe;
        public Inventory inventory;
        public int cupsOfLemonade;
        public int CostOfLemon;
        public int CostOfSugar;
        public int CostOfIce;
        public int CostOfCup;
        public int totalMoney;
        public int profit;
        public int loss;
        string response;
        public Customer customer;
        int costOfSupplies;
        int maxPrice;
        int priceofLemonade;




        //Constructor (BUILDS OBJECT)
        public Player()
        {
            cupsOfLemonade = 0;
            CostOfCup = 1;
            CostOfIce = 1;
            CostOfSugar = 2;
            CostOfLemon = 5;
            totalMoney = 100;
            costOfSupplies = CostOfCup + CostOfIce + CostOfSugar + CostOfLemon;
            maxPrice = costOfSupplies * 2;
            
        }



        //member methods(CAN DO)
        public void MakeLemonade()
        {
            inventory.lemons--;
            inventory.sugar =-2;
            inventory.ice =- 2;
            inventory.cups--;
            cupsOfLemonade++;
            priceofLemonade = 0;
           
        }

        public void CanIMakeLemonade()
        {
            inventory.CheckSupplies();
             if (inventory.supplies == false)
            {
                Console.WriteLine("You dont have enough supplies to make anymore lemonade");
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
            if (customer.purchaseLemonade == true)
            {
                cupsOfLemonade--;
                totalMoney = totalMoney + priceofLemonade;
            }
        }

        public void SetPurchasePrice()
        {
            Console.WriteLine("What would you like to set the prie of one cup of lemonade?");
            Console.WriteLine("YOu cannot set the price higher than 2 times the amount that the supplies cost individually.");
            response = Console.ReadLine();
            priceofLemonade = int.Parse(response);
            if (priceofLemonade > maxPrice)
            {
                Console.WriteLine("That price is higher than the allowed limit, please try again.");
                SetPurchasePrice();
            }
        }








    }   
        
        
    
}
