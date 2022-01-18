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


        public MachineCommand(IMachine machine, string stuff, IMachineState machineState)
        {
            Machine = machine;
            Stuff = stuff;
            MachineState = machineState;
        }

        public void Save()
        {
            Console.WriteLine("Save done");
        }

        public void Do()
        {
            //if (MachineState.PowerSwitch == MachineStateOn)
            //{
            //    //skriva ut sista i commandlist
            //}
            //else
            //{
            //    //memento
            //}
        }

        public void Reset()
        {
            Console.WriteLine("Reset done");
        }
    }
}