using ObserverPattern_Self_Implemented.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_Self_Implemented.Observers
{
    class ObserverOne : Observer, Display
    {
        private Subject sub;
        public float temperature;

        public ObserverOne(Subject sub)
        {
            this.sub = sub;
            sub.AddObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Observer One");
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine("Temperature");
            Console.WriteLine(temperature);
            Console.WriteLine();
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            Display();
        }

        public void UnRegister()
        {
            sub.RemoveObserver(this);
        }
      
    }
}
