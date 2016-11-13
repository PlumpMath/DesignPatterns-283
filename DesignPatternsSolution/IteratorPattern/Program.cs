using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var concreteAggregate = new ConcreteAggregate();

            concreteAggregate[0] = "Item A";
            concreteAggregate[1] = "Item B";
            concreteAggregate[2] = "Item C";
            concreteAggregate[3] = "Item D";

            // Create Iterator and provide aggregate
            var iterator = concreteAggregate.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            object item = iterator.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = iterator.Next();
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}