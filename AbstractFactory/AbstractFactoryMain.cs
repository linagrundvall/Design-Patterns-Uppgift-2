using Assignment2.AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    internal class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken
        // ska skapa en hund och den andra en katt skapa sedan en
        // abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på ett sträng argument
        
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
                    Console.WriteLine("Dog");
                    factoryFactory.GetFactory("Dog");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.WriteLine("Cat");
                    factoryFactory.GetFactory("Cat");
                    break;
                default:
                    Console.WriteLine("Unknown command. Please try again.");
                    break;
            }
        }
    }
}
