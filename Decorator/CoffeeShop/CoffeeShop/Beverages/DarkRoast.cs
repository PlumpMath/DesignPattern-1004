using System;

namespace CoffeeShop.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
        }

        public override double cost()
        {
            return 0.89f;
        }
    }
}
