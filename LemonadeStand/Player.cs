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





        //Constructor (BUILDS OBJECT)
        public Player()
        {
            cupsOfLemonade = 0;
            CostOfCup = 1;
            CostOfIce = 1;
            CostOfSugar = 2;
            CostOfLemon = 5;
        }



        //member methods(CAN DO)
        public void MakeLemonade()
        {
            inventory.lemons--;
            inventory.sugar =-2;
            inventory.ice =- 2;
            inventory.cups--;
            cupsOfLemonade++;
           
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



    }
}
