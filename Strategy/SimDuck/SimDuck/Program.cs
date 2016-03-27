using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] duckArray = new Duck[3];
            duckArray[0] = new AfricanBlackDuck();
            duckArray[1] = new LittleYellowDuck();
            duckArray[2] = new RubberDuck();
            for(int i = 0; i < duckArray.Length; i++)
            {
                duckArray[i].ShowDisplay();
            }
            Console.Read();
        }
    }
}
