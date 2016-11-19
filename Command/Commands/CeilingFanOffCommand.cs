using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands
{
    public class CeilingFanOffCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;
        private FanSpeed _prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _prevSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.Off();
        }

        public void Undo()
        {
            switch (_prevSpeed)
            {
                case FanSpeed.High: _ceilingFan.Hight(); break;
                case FanSpeed.Medium: _ceilingFan.Medium(); break;
                case FanSpeed.Low: _ceilingFan.Low(); break;
                case FanSpeed.Off: _ceilingFan.Off(); break;
            }
        }
    }
}
