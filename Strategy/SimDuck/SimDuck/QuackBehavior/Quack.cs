using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.QuackBehavior
{
    public class Quack : QuackBehavior
    {
        public override void DoQuack()
        {
            Console.WriteLine("Quack With Mouth");
        }
    }
}
