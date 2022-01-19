using System;

namespace Assignment2.Facade
{
    class FacadeMain
    {
        public WordFacade WordFacade { get; set; }

        public FacadeMain()
        {
            WordFacade = new WordFacade();
        }

        public void Run()
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter one word with exactly 5 characters");
            string input = Console.ReadLine();

            WordFacade.Save(input);
            Console.WriteLine("What do you want to do now?");
            Console.WriteLine("");
            Console.WriteLine("1. Save more words");
            Console.WriteLine("2. Load the last word");
            Console.WriteLine("3. Exit the program");

            var userInput = Console.ReadKey(intercept: true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Run();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    WordFacade.Load();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Unknown command. Please try again.");
                    break;
            }
        }
    }
}