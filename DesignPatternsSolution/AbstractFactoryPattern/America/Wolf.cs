using System;

namespace AbstractFactoryPattern
{
    internal class Wolf : CarnivoreBase
    {
        public override void Eat(HerbivoreBase herbivore)
        {
            //Eat Bison
            Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }
}