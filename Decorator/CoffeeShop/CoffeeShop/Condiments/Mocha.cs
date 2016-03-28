using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Condiments
{
    public class Mocha : Beverage
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            description = "Mocha";
        }

        public override double cost()
        {
            return 0.20f + beverage.cost();
        }
    }
}
