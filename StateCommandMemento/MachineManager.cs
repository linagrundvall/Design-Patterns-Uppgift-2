using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class MachineManager
    {
        private Machine Machine { get; set; }
        private List<ICommand> CommandList { get; set; }
        public IMachineState MachineState { get; set; }
        public MachineManager()
        {
            CommandList = new();
        }

        public void AddCommand(String stuff, IMachine machine, IMachineState machineState)
        {
            ICommand command = new MachineCommand(stuff, machine, machineState);
            CommandList.Add(command);
            MachineState = machineState;
        }

        public void Do(IMachineState machineState)
        {

            foreach (var command in CommandList)
            {
                command.MachineState.Print(command.Stuff, machineState);
            }
        }

        public void Reset()
        {
            Console.WriteLine("Reset");
            CommandList.Clear();
            //Machine.MachineState = MachineStateOff;
        }
    }
}