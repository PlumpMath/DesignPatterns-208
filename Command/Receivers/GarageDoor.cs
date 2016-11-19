using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public class GarageDoor
    {
        private readonly string _roomName;

        public GarageDoor(string roomName)
        {
            _roomName = roomName;
        }

        public void Up()
        {
            Console.WriteLine("{0} Garage Door Is Open", _roomName);
        }

        public void Down()
        {
            Console.WriteLine("{0} Garege Door Is Down", _roomName);
        }
    }
}
