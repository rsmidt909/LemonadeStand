﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {


        //member variables (HAS A)
        int maxthirst;
        int middleThirstLevel;
        Weather weather;
        public bool purchaseLemonade;
        Day day;




        //Constructor (BUILDS OBJECT)
        public Customer()
        {
            day = new Day();
            weather = new Weather();
            maxthirst = 0;
            middleThirstLevel = maxthirst / 2;
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
            else if (weather.currentWeather == "Rainy")
            {
                maxthirst = 100;
            }
            else Console.WriteLine("Something went wrong at Thirst Level");

        }

        public void BuyLemonade()
        { 
            if (weather.RandomNumber(1, maxthirst)>middleThirstLevel )
            {
                purchaseLemonade = true;
            }
            else { purchaseLemonade = false; }
        }

    }
}
