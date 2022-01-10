namespace Assignment2.AbstractFactory.Factories
{
    internal class FactoryFactory
    {
        public FactoryFactory()
        {
        }

        internal IFactory GetFactory(string typeOfFactory, string animalName)
        {
            if (typeOfFactory == "Dog")
            {
                return new DogFactory();
            }
            else if(typeOfFactory == "Cat")
            {
                return new CatFactory();
            }
            return null;
        }
    }
}