using Assignment2.AbstractFactory.Animals;

namespace Assignment2.AbstractFactory.Factories
{
    internal class DogFactory : IFactory
    {
        public IDog CreateAnimal(string animalName)
        {
            return new Dog(animalName);
        }
    }
}
