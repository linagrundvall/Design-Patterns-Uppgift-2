using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    class MachineCommand : ICommand
    {
        public IMachine Machine { get; set; }
        public string Stuff { get; set; }
        public IMachineState MachineState { get; set; }


        public MachineCommand(string stuff, IMachine machine, IMachineState machineState)
        {
            
            Stuff = stuff;
            Machine = machine;
            MachineState = machineState;
        }

        public IMachineState GetMachineState()
        {
            return MachineState;
        }

        //public void Reset()
        //{
        //    Console.WriteLine("Reset done");
        //}
    }
}