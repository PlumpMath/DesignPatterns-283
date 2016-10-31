using System;

namespace AbstractFactoryPattern
{
    internal class Lion : CarnivoreBase
    {
        public override void Eat(HerbivoreBase herbivore)
        {
            //Eat WildeBeest
            Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }
}