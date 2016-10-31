namespace AbstractFactoryPattern
{
    internal class AnimalWorld
    {
        private HerbivoreBase _herbivore;
        private CarnivoreBase _carnivoreBase;

        public AnimalWorld(ContinentFactory factory)
        {
            _carnivoreBase = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivoreBase.Eat(_herbivore);
        }
    }
}