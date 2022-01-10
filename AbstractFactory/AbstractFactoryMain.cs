using Assignment2.AbstractFactory.Factories;
using System;

namespace Assignment2.AbstractFactory
{
    internal class AbstractFactoryMain
    {
        public void Run()
        {
            Console.WriteLine("");
            Console.WriteLine("Lets create an animal!");
            Console.WriteLine("Please type the name of the animal:");
            var animalName = Console.ReadLine();

            Console.WriteLine("What animal do you want to create?");
            Console.WriteLine("");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");

            var factoryFactory = new FactoryFactory();
            var userInput = Console.ReadKey(intercept: true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    factoryFactory.GetFactory("Dog", animalName);
                    Console.WriteLine("You created a new dog called " + animalName);
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    factoryFactory.GetFactory("Cat", animalName);
                    Console.WriteLine("You created a new cat called " + animalName);
                    break;
                default:
                    Console.WriteLine("Unknown command. Please try again.");
                    break;
            }
        }
    }
}