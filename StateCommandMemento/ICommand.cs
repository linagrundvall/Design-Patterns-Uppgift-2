using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public interface ICommand
    {
        IMachine Machine { get; set; }
        string Stuff { get; set; }
        IMachineState MachineState { get; set; }
        IMachineState GetMachineState();
        //void Reset();
    }
}
