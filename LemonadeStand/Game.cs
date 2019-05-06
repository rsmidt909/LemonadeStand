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
            player.CheckLemonOrderingMoney();
            GameCheck();
            player.CheckSugarOrderingMoney();
            GameCheck();
            player.CheckIceOrderingMoney();
            GameCheck();
            player.CheckCupOrderingMoney();
            GameCheck();

        }

    }
}
