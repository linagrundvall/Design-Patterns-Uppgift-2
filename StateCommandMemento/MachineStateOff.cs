using System;

namespace Assignment2.StateCommandMemento
{
    class MachineStateOff : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Turning Machine On");
        }

        public void Print(string stuff, IMachineState machineState)
        {
            if (machineState.Equals(this))
            {
                Console.WriteLine("The machine if offline. Turn on to print.");
            }
            else
            {
                Console.WriteLine(stuff);
            }
        }
    }
}