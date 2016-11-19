using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public class Light
    {
        private readonly string _roomName;

        public Light(string roomName)
        {
            _roomName = roomName;
        }
        public void On()
        {
            Console.WriteLine("{0} Light On", _roomName);
        }

        public void Off()
        {
            Console.WriteLine("{0} Light Off", _roomName);
        }
    }
}
