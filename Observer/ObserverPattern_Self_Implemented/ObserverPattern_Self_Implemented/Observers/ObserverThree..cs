using ObserverPattern_Self_Implemented.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_Self_Implemented.Observers
{
    public class ObserverThree : Observer, Display
    {
        private Subject sub;
        private float pressure;

        public ObserverThree(Subject sub)
        {
            this.sub = sub;
            sub.AddObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Observer Three");
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine("Pressure");
            Console.WriteLine(pressure);
            Console.WriteLine();
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.pressure = pressure;
            Display();
        }

        public void UnRegister()
        {
            sub.RemoveObserver(this);
        }

    }
}
