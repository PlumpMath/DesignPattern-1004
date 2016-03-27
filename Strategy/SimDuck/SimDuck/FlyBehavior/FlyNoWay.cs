using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    public class FlyNoWay : FlyBehavior
    {
        public override void DoFly()
        {
            Console.WriteLine("I can not fly");
        }
    }
}
