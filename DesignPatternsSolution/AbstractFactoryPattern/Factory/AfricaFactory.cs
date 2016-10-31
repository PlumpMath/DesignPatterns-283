namespace AbstractFactoryPattern
{
    internal class AfricaFactory : ContinentFactory
    {
        public override HerbivoreBase CreateHerbivore()
        {
            return new Wildebeest();
        }

        public override CarnivoreBase CreateCarnivore()
        {
            return new Lion();
        }
    }
}