
namespace FactoryMethodPattern
{
    class ProductACreator : Creator
    {
        public override Product FactoryMethod()
        {
            var creator = new SolidCompliantFactoryBase<ConcreteProductA>();
            return creator.Create();
        }
    }
}
