using Assignment2.AbstractFactory.Animals;

namespace Assignment2.AbstractFactory.Factories
{
    internal class CatFactory : IFactory
    {
        public ICat CreateAnimal(string animalName)
        {
            return new Cat(animalName);
        }
    }
}