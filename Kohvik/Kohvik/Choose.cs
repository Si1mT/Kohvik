using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohvik
{
    class Choose
    {
        public void ChooseMethod()
        {
            Console.WriteLine("Do you want to eat or drink");
            Console.ReadLine();
        }
        public void ChooseDrink()
        {
            Latte latte = new Latte();
            Kohv kohv = new Kohv();

            Console.WriteLine("Do you want coffee or latte");
            var answer = Console.ReadLine();
            if (answer == "coffee")
            {
                kohv.Drink();
            }
            else if (answer == "latte")
            {
                latte.Drink();
            }
        }
        public void ChooseCake()
        {
            ChocolateCake chocolate = new ChocolateCake();
            StrawberryShortCake strawberryShort = new StrawberryShortCake();

            Console.WriteLine("Do you want "+strawberryShort.Name+ " or "+chocolate.Name);
            var answer = Console.ReadLine();
            if (answer == strawberryShort.Name)
            {
               strawberryShort.Eat();
            }
            else if (answer == chocolate.Name)
            {
                chocolate.Eat();
            }
        }
    }
}
