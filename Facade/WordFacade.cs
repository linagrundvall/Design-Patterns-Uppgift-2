using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2.Facade
{
    internal class WordFacade
    {
        public List<char> One { get; set; }
        public List<char> Two { get; set; }
        public List<char> Three { get; set; }
        public List<char> Four { get; set; }
        public List<char> Five { get; set; }

        public WordFacade()
        {
            One = new();
            Two = new();
            Three = new();
            Four = new();
            Five = new();
        }

        internal void Save(string input)
        {
            if (input.Length != 5)
            {
                Console.WriteLine("Exiting program - Error - The word needs to have EXACTLY 5 characters");
                Console.ReadKey(true);
            }
            else
            {
                One.Add(input[0]);
                Two.Add(input[1]);
                Three.Add(input[2]);
                Four.Add(input[3]);
                Five.Add(input[4]);
            }
        }

        internal void Load()
        {
            if (One.Count > 0)
            {
                char[] word = { One.Last(), Two.Last(), Three.Last(), Four.Last(), Five.Last() };
                Console.WriteLine(word);
            }
        }
    }
}