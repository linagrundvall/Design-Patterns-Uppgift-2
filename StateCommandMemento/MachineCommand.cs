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
    }
}