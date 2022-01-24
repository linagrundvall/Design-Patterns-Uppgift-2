using System;

namespace Assignment2.StateCommandMemento
{
    class MachineStateOn : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Turning Machine Off");
        }

        public void Print(string stuff, IMachineState machineState)
        {
                Console.WriteLine(stuff);
        }
    }
}