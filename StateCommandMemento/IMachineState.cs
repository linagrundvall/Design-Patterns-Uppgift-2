namespace Assignment2.StateCommandMemento
{
    public interface IMachineState
    {
        public void PowerSwitch();
        public void Print(string stuff, IMachineState machineState);
    }
}