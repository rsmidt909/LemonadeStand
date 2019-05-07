using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {


        //member variables (HAS A)
        public int maxthirst;
        public int middleThirstLevel;
        
        public bool purchaseLemonade;
        public Day day;
        




        //Constructor (BUILDS OBJECT)
        public Customer()
        {
            day = new Day();
            
            maxthirst = 0;                                    // Probability of the customer choice is completely able to be extended
            middleThirstLevel = (maxthirst / 2);             // without modifcation.
            purchaseLemonade = false;
        }



        //member methods(CAN DO)
        public void HowMuchThirst()
        { if (day.weather.currentWeather == "Hot")
            {
                maxthirst = 10;
            }
            else if (day.weather.currentWeather == "Nice")
            {
                maxthirst = 25;
            }
            else if (day.weather.currentWeather == "Cold")
            {
                maxthirst = 50;
            }
            else if (day.weather.currentWeather == "Rainy")
            {
                maxthirst = 100;
            }
            else Console.WriteLine("Something went wrong at Thirst Level");

        }

        public void BuyLemonade()
        { 
            if (day.weather.RandomNumber(1, maxthirst)>(maxthirst/2) )
            {
                purchaseLemonade = true;
            }
            else { purchaseLemonade = false; }
        }

    }
}
