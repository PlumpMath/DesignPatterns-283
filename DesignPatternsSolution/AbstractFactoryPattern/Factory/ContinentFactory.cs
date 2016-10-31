namespace AbstractFactoryPattern
{
    abstract class ContinentFactory
    {
        public abstract HerbivoreBase CreateHerbivore();
        public abstract CarnivoreBase CreateCarnivore();
    }
}