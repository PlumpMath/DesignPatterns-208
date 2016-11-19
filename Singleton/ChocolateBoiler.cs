using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ChocolateBoiler
    {
        private string _name;
        private bool _empty;
        private bool _boiled;
        private static ChocolateBoiler _instance = null;
        private static readonly Object _lockObject = new Object();

        private ChocolateBoiler(string name)
        {
            _name = name;
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler GetInstance(string name)
        {
            lock (_lockObject)
            {
                if (_instance != null) return _instance;
                _instance = new ChocolateBoiler(name);
                return _instance;
            }
        }

        public string GetName()
        {
            return _name;
        }
    }
}
