namespace Assignment2.StateCommandMemento
{
    internal class Machine : IMachine
    {
        public IMachineState MachineState { get; set; }
        public string Stuff { get; set; }
        public MachineManager MachineManager { get; set; }

        public Machine()
        {
            MachineState = new MachineStateOff();
            MachineManager = new MachineManager();
        }

        public void PowerSwitch()
        {
            MachineState.PowerSwitch();

            if (MachineState is MachineStateOff)
            {
                MachineState = new MachineStateOn();
                MachineManager.Do(MachineState);
            }
            else
            {
                MachineState = new MachineStateOff();
            }
        }

        public void Execute(string stuff)
        {
            MachineManager.AddCommand(stuff, this, MachineState);
            MachineManager.Do(MachineState);
        }
    }
}