using System;

namespace Assignment2.AbstractFactory.Animals
{
    internal class Cat : ICat, IAnimal
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        
        public Cat(string name)
        {
            ID = Guid.NewGuid();
            Name = name;
        }
    }
}
