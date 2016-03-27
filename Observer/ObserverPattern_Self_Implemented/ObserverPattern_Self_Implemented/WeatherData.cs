using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_Self_Implemented
{
    public class WeatherData
    {
        public readonly float temperature;
        public readonly float humdity;
        public readonly float pressure;

        public WeatherData()
        {

        }

        public WeatherData(float temp, float humdity, float pressure)
        {
            this.temperature = temp;
            this.humdity = humdity;
            this.pressure = pressure;
        }
    }
}
