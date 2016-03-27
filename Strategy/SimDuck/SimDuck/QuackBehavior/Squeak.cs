using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.QuackBehavior
{
    public class Squeak : QuackBehavior
    {
        public override void DoQuack()
        {
            Console.WriteLine("Squeak Squeak Squeak");
        }
    }
}
