using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohvik
{
    class BlackCoffee:Kohv
    {
        public BlackCoffee()
        {
            Milk = true;
            Calories = 2;

        }
        public override void Drink()
        {
            Random goodOrBad = new Random();
            if (goodOrBad.Next(0, 100) <= 50)
                Console.WriteLine("This smells bad");
            else
                Console.WriteLine("This smells good");
            base.Drink();
        }
    }
}
