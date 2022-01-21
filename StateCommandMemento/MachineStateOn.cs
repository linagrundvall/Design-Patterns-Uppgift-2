using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    class MachineStateOn : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Turning Machine Off");
            //create memento?
            //List<CommandMemento> memories = new();

        }

        public void Print(string stuff)
        {
            Console.WriteLine(stuff);
        }
    }
}
