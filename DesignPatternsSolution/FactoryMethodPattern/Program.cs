﻿using System;
using System.ComponentModel.Design;
using FactoryMethodPattern.SolidCompliantFactory;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();
            

            // Iterate over creators and create products
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }

            Console.ReadKey();


            //test intentando crear factory dinámicos y fuertemente tipados para ser utilizados por diferentes clases (carpeta solidcompliantfactory)
            Creator[] newCreators = new Creator[2];

            newCreators[0] = new ProductACreator();
            newCreators[1] = new ProductBCreator();

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }

            Console.ReadKey();
        }
    }
}