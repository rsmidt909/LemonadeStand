using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {



        //member variables (HAS A)
        public string currentWeather;
        public string forecastedWeather;
        




        //Constructor (BUILDS OBJECT)
        public Weather()
        {
            currentWeather = null;
            forecastedWeather = null;
        }




        //member methods(CAN DO)
        public void WeatherChooserToday()
        {
            int weatherDecision = RandomNumber(1, 4);
            switch (weatherDecision)
            {
                case 1:
                    currentWeather = "Hot";
                    break;
                case 2:
                    currentWeather = "Cold";
                    break;
                case 3:
                    currentWeather = "Rainy";
                    break;
                case 4:
                    currentWeather = "Nice";
                    break;
                default:
                    currentWeather = "Something broke the weather chooser.";
                     break;
            }
        }


        public void WeatherChooserTomorrow()
        {
            int weatherDecision = RandomNumber(1, 4);
            switch (weatherDecision)
            {
                case 1:
                    forecastedWeather = "Hot";
                    break;
                case 2:
                    forecastedWeather = "Cold";
                    break;
                case 3:
                    forecastedWeather = "Rainy";
                    break;
                case 4:
                    forecastedWeather = "Nice";
                    break;
                default:
                    forecastedWeather = "Something broke the weather chooser.";
                    break;
            }
        }


        public int RandomNumber(int min, int max)
        {
            Random rando = new Random();
            return rando.Next(min, max);
        }

        public void WeekOfWeather()
        {
            WeatherChooserToday();
            Console.WriteLine("Today will be " +currentWeather);
            WeatherChooserTomorrow();
            Console.WriteLine("The next day MAY be " + forecastedWeather);
            WeatherChooserTomorrow();
            Console.WriteLine("The next day MAY be " + forecastedWeather);
            WeatherChooserTomorrow();
            Console.WriteLine("The next day MAY be " + forecastedWeather);
            WeatherChooserTomorrow();
            Console.WriteLine("The next day MAY be " + forecastedWeather);
            WeatherChooserTomorrow();
            Console.WriteLine("The next day MAY be " + forecastedWeather);
            WeatherChooserTomorrow();
            Console.WriteLine("The next day MAY be " + forecastedWeather);
        }

        public void OneDayOrSeven()
        {
            string weatherDecision = Console.ReadLine();
            switch (weatherDecision)
            {
                case "One":
                    WeatherChooserToday();
                    Console.WriteLine("Todays weather will be " + currentWeather);
                    break;
                case "Seven":
                    WeekOfWeather();
                    break;               
                default:
                    Console.WriteLine("That is not an option, please try again.");
                    OneDayOrSeven();
                    break;
            }
        }



    }   
}


