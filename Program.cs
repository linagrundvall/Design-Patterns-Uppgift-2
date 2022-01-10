using Assignment2.AbstractFactory;
using Assignment2.Adapter;
using Assignment2.Facade;
using Assignment2.StateCommandMemento;

using System;

namespace Assignment2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("**************************");
            Console.WriteLine("Please choose a pattern");
            Console.WriteLine("");
            Console.WriteLine("1. Abstract Factory");
            Console.WriteLine("2. Facade Pattern");
            Console.WriteLine("3. Adapter Pattern");
            Console.WriteLine("4. State Command Memento");
            Console.WriteLine("");
            Console.WriteLine("*************************");

            var userInput = Console.ReadKey(intercept: true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.WriteLine("Abstract Factory");
                    AbstractFactoryMain abstractFactory = new();
                    abstractFactory.Run();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.WriteLine("Facade");
                    FacadeMain facadeMain = new();
                    facadeMain.Run();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine("Adapter");
                    AdapterMain adapterMain = new();
                    adapterMain.Run();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Console.WriteLine("State Command Memento");
                    SCMMain scmMain = new();
                    scmMain.Run();
                    break;
                default:
                    Console.WriteLine("Unknown command. Please try again.");
                    break;
            }
        }
    }
}