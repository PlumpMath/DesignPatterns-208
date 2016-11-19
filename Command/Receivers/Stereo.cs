using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public class Stereo
    {
        private readonly string _roomName;

        public Stereo(string roomName)
        {
            _roomName = roomName;
        }

        public void On()
        {
            Console.WriteLine("{0} Stereo On", _roomName);
        }

        public void Off()
        {
            Console.WriteLine("{0} Stereo Off", _roomName);
        }

        public void SetCD()
        {
            Console.WriteLine(" Stereo set cd");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine("Stereo set volume {0}", volume);
        }
    }
}
