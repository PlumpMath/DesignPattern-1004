using ObserverPattern_Self_Implemented.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ObserverPattern_Self_Implemented
{
    public class WeatherStation : Subject
    {
        private List<Observer> _observers;
        private Timer _timer;
        private DateTime _startTime;

        private WeatherData _newWeatherData;

        public WeatherStation()
        {
            _observers = new List<Observer>();
        }

        public WeatherData GetNewWeatherData()
        {
            return _newWeatherData;
        }

        public void BeginCollectWeatherData()
        {
            // Simulate the weather data collection, create new weather every one seconds;
            _startTime = DateTime.Now;
            _timer = new Timer(1000);
            _timer.Elapsed += UpdateNewWeather;
            _timer.Enabled = true;
        }

        private Random _rand;
        private void UpdateNewWeather(object sender, ElapsedEventArgs e)
        {
            InitRandom();
            _newWeatherData = new WeatherData(GetFakeTemperature(), GetFakeHumidity(), GetFakePressure());
            NotifyObserver();
        }

        private void InitRandom()
        {
            if (_rand == null)
            {
                _rand = new Random();
            }
        }

        private float GetFakeTemperature()
        {
            const float MAX_TEMP = 50.0f;
            const float MIN_TEMP = -30.0f;
            return MIN_TEMP + (float)_rand.NextDouble() * (MAX_TEMP - MIN_TEMP);
        }

        private float GetFakeHumidity()
        {
            const float MAX_HUM = 100.00f;
            const float MIN_HUM = 0.00f;
            return MIN_HUM + (MAX_HUM - MIN_HUM) * (float)_rand.NextDouble();
        }

        private float GetFakePressure()
        {
            const float MAX_PRESSURE = 1050.0f;
            const float MIN_PRESSURE = 800.0f;
            return MIN_PRESSURE + (MAX_PRESSURE - MIN_PRESSURE) * (float)_rand.NextDouble();
        }

        public void StopCollectWeatherData()
        {
            _timer.Elapsed -= UpdateNewWeather;
            _timer.Enabled = false;
        }

        public void AddObserver(Observer o)
        {
            if(_observers.Contains(o) == false)
            {
                _observers.Add(o);
            }
        }

        public void RemoveObserver(Observer o)
        {
            int index = _observers.IndexOf(o);
            if(index > -1)
            {
                _observers.RemoveAt(index);
            }
        }

        public void NotifyObserver()
        {
            for(int i = 0; i < _observers.Count; i++)
            {
                _observers[i].Update(_newWeatherData.temperature, _newWeatherData.humdity, _newWeatherData.pressure);
            }
        }
    }
}
