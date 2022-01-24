namespace Assignment2.StateCommandMemento
{
    public interface ICommand
    {
        IMachine Machine { get; set; }
        string Stuff { get; set; }
        IMachineState MachineState { get; set; }
        IMachineState GetMachineState();
    }
}