using System.Security.Cryptography.X509Certificates;

namespace FactoryMethodPattern
{
    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}