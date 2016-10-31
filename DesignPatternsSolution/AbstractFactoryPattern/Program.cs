using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld animalWorld = new AnimalWorld(africa);
            animalWorld.RunFoodChain();

            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            animalWorld = new AnimalWorld(america);
            animalWorld.RunFoodChain();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
