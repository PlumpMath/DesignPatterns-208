using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public enum FanSpeed
    {
        Off = 0,
        Low,
        Medium,
        High
    }

    public class CeilingFan
    {
        private readonly string _roomName;
        private FanSpeed _speed;

        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF = 0;
        
        public CeilingFan(string roomName)
        {
            _roomName = roomName;
            _speed = FanSpeed.Off;
        }

        public void Hight()
        {
            _speed = FanSpeed.High;
        }

        public void Medium()
        {
            _speed = FanSpeed.Medium;
        }

        public void Low()
        {
            _speed = FanSpeed.Low;
        }

        public void Off()
        {
            _speed = FanSpeed.Off;
        }

        public FanSpeed GetSpeed()
        {
            return _speed;
        }
    }
}
