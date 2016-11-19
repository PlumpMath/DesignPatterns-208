using System.Collections.Generic;
using Observer.Interfaces;

namespace Observer.Subject
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers;

        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(observer => observer.Update(_temperature, _humidity, _pressure));
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasureemnts(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}
