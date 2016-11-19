using System;
using Observer.Interfaces;

namespace Observer.Observers
{
    public class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private float _tepmerature;
        private float _humidity;
        private readonly ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions:\r\n Temperature: {0} \r\n Humidity: {1}", _tepmerature, _humidity);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _tepmerature = temp;
            _humidity = humidity;
            Display();
        }
    }
}
