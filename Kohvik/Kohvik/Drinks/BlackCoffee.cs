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
            base.Drink();
        }
    }
}
