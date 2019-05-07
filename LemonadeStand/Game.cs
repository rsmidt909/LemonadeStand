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
        
        
        public Player player;             
        
        




        //Constructor (BUILDS OBJECT)
        public Game()
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




    }
}
