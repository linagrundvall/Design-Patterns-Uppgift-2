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
            MachineState = new MachineStateOff();
        }

        public void PowerSwitch()
        {
            MachineState.PowerSwitch();

            if (MachineState is MachineStateOff)
            {
                MachineState = new MachineStateOn();
            }
            else
            {
                MachineState = new MachineStateOff();
            }
        }

        //public MachineOperation(char machineOperation)
        //{

        //}
    }
}
