using ObserverPattern_Self_Implemented.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_Self_Implemented.Observers
{
    public class ObserverTwo : Observer, Display
    {
        private Subject sub;
        private float humidity;

        public ObserverTwo(Subject sub)
        {
            this.sub = sub;
            sub.AddObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Observer Two");
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine("Humidity");
            Console.WriteLine(humidity);
            Console.WriteLine();
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.humidity = humidity;
            Display();
        }

        public void UnRegister()
        {
            sub.RemoveObserver(this);
        }
    }
}
