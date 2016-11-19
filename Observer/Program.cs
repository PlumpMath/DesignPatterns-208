using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Observer.Observers;
using Observer.Subject;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasureemnts(80, 65, 30.4f);
            Thread.Sleep(1000);
            weatherData.SetMeasureemnts(82, 70, 29.2f);
            Thread.Sleep(1500);
            weatherData.SetMeasureemnts(78, 90, 29.2f);
            
            Console.ReadLine();
        }
    }
}
