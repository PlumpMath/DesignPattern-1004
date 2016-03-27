using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck.QuackBehavior
{
    public class MuteQuack : QuackBehavior
    {
        public override void DoQuack()
        {
            Console.WriteLine("Can't Quack");
        }
    }
}
