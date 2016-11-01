namespace FactoryMethodPattern
{
    interface ISolidCompliantFactory<T> where T : class
    {
        T Create();
    }
}
