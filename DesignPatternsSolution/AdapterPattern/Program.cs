using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Non-adapted chemical compound
            var unknown = new Compound("Unknown");
            unknown.Display();

            //Adapted chemical compounds
            var water = new RichCompoundAdapter("Water");
            water.Display();

            var benzene = new RichCompoundAdapter("Benzene");
            benzene.Display();

            var ethanol = new RichCompoundAdapter("Ethanol");
            ethanol.Display();

            Console.ReadKey();
        }
    }
}