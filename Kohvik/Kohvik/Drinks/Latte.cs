using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohvik
{
    class Latte : Kohv
    {
        public Latte()
        {
            Milk = true;
            Calories = 220;

        }
        public override void Drink()
        {
            base.Drink();
        }
    }
}
