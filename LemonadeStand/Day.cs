using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {

        //member variables (HAS A)
        int dayCount;
        bool startDay;
        bool endDay;
        public Weather weather;
        public Customer customer;





        //Constructor (BUILDS OBJECT)
        public Day()
        {
            weather = new Weather();
            customer = new Customer();
        }



        //member methods(CAN DO)




    }
}
