using CoffeeShop.Beverages;
using CoffeeShop.Condiments;
using System;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription()
                + " $" + beverage.cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            Console.WriteLine(beverage2.getDescription()
                + " $" + beverage2.cost());

            Console.ReadLine();
        }
    }
}
