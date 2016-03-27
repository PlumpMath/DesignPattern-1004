using ObserverPattern_Self_Implemented.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_Self_Implemented
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
            ObserverOne observerOne = new ObserverOne(weatherStation);
            ObserverTwo observerTwo = new ObserverTwo(weatherStation);
            ObserverThree observerThree = new ObserverThree(weatherStation);

            weatherStation.BeginCollectWeatherData();

            Console.ReadLine();
        }
    }
}
