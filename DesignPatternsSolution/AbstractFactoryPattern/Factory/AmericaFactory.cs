namespace AbstractFactoryPattern
{
    internal class AmericaFactory : ContinentFactory
    {
        public override HerbivoreBase CreateHerbivore()
        {
            return new Bison();
        }

        public override CarnivoreBase CreateCarnivore()
        {
            return new Wolf();
        }
    }
}