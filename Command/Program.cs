using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Commands;
using Command.Invoker;
using Command.Receivers;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            
            Light livingRoomLight = new Light("Living Romm");
            Light kitchenRoomLight = new Light("kitchen Romm");
            GarageDoor garageDoor = new GarageDoor("");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenRoomLightOn = new LightOnCommand(kitchenRoomLight);
            LightOffCommand kitchenRoomLightOff = new LightOffCommand(kitchenRoomLight);

            CeilingFanHighCommand ceilingFanOn = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor);

            StereoOnWithCDCommand stereoOnWithCdCommand = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenRoomLightOn, kitchenRoomLightOff);
            remote.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remote.SetCommand(3, stereoOnWithCdCommand, stereoOffCommand);

            Console.WriteLine(remote.ToString());

            remote.OnButtonWasPressed(0);
            remote.OffButtonWasPressed(0);

            remote.OnButtonWasPressed(1);
            remote.OffButtonWasPressed(1);

            remote.OnButtonWasPressed(2);
            remote.OffButtonWasPressed(2);

            remote.OnButtonWasPressed(3);
            remote.OffButtonWasPressed(3);


            Console.ReadLine();
        }
    }
}
