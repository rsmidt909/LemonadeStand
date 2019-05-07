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
        
        
        
        public UserInterface userInterface;
        
        




        //Constructor (BUILDS OBJECT)
        public Game()
        {


            userInterface = new UserInterface();

            
            


        }
        


        //member methods(CAN DO)
        public void GameCheck()
        {
            if (userInterface.player.totalMoney <= userInterface.player.costOfSupplies)
            {
                Console.WriteLine("You ran out of money to make a single cup of lemonade! Game Over!");
                Console.ReadLine();
                Environment.Exit(0);
            } 
        }

        public void StatReset()
        {
            userInterface.player.cupsOfLemonadeSold = 0;
            userInterface.player.profit = 0;
        }




    }
}
