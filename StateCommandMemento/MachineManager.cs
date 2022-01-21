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
        public MachineManager()
        {
            Machine = new();
            CommandList = new();
        }

        public void Reset()
        {
            Console.WriteLine("Reset");
            CommandList.Clear();
            //Machine.MachineState = MachineStateOff;
        }
    }
}