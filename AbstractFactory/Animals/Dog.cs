using System;

namespace Assignment2.AbstractFactory.Animals
{
    internal class Dog : IDog, IAnimal
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public Dog(string name)
        {
            ID = Guid.NewGuid();
            Name = name;
        }
    }
}
