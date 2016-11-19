using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Commands;

namespace Command.Invoker
{
    public class SimpleRemoteControl
    {
        private readonly List<ICommand> _onCommand;
        private readonly List<ICommand> _offCommand;
        private ICommand _undoCommand;

        public SimpleRemoteControl()
        {
            _onCommand = new List<ICommand>(7);
            _offCommand = new List<ICommand>(7);

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommand.Add(noCommand);
                _offCommand.Add(noCommand);
            }
            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCmd, ICommand offCmd)
        {
            _onCommand[slot] = onCmd;
            _offCommand[slot] = offCmd;
        }

        public void OnButtonWasPressed(int slot)
        {
            _onCommand[slot].Execute();
            _undoCommand = _onCommand[slot];
        }

        public void OffButtonWasPressed(int slot)
        {
            _offCommand[slot].Execute();
            _undoCommand = _offCommand[slot];
        }

        public void UndoButtonWasPressed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 7; i++)
            {
                sb.AppendLine(String.Format("[slot {0}] {1} {2}", i, _onCommand[i].GetType().Name, _offCommand[i].GetType().Name));
            }

            return sb.ToString();
        }
    }
}
