using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    internal class Machine : IMachine
    {
        public IMachineState MachineState { get; set; }

        public Machine()
        {
            MachineState = new MachineStateOn();
        }

        public void PowerSwitch()
        {
            MachineState.PowerSwitch();

            if (MachineState is MachineStateOff)
            {
                MachineState = new MachineStateOn();
                //och kör sparade commandon, cw commandlist?
            }
            else
            {
                MachineState = new MachineStateOff();
                //skapa memento??? 
            }
        }

        public void Print(string stuff)
        {
            MachineState.Print(stuff);
        }

    }
}
