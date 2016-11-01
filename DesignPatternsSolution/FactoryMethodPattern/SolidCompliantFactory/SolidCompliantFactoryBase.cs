using System;

namespace FactoryMethodPattern
{

    class SolidCompliantFactoryBase<T> : ISolidCompliantFactory<T> where T : class
    {
        public T Create()
        {
            return Activator.CreateInstance<T>();
        }
    }
}