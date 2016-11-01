namespace FactoryMethodPattern.SolidCompliantFactory
{
    class ProductBCreator : Creator
    {
        public override Product FactoryMethod()
        {
            var creator = new SolidCompliantFactoryBase<ConcreteProductB>();
            return creator.Create();
        }
    }
}
