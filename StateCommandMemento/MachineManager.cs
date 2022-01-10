using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class MachineManager
    {
        private List<ICommand> CommandList { get; set; }

        public MachineManager()
        {
            CommandList = new();
        }

        public void Save(string stuff)
        {
            Console.WriteLine("Save");
            //CommandList.Add(stuff);
        }

        public void Reset()
        {
            Console.WriteLine("Reset");

        }
    }
}
