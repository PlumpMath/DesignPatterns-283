using System.Data.SqlTypes;

namespace AdapterPattern
{
    /// <summary>
    /// The 'adaptee' class
    /// </summary>
    internal class ChemicalDataBank
    {
        public float GetCriticalPoint(string compound, string point)
        {
            //Melting Point
            if (point == "M")
            {
                switch (compound.ToLower())
                {
                    case "water":
                        return 0.0f;

                    case "benzene":
                        return 5.5f;

                    case "ethanol":
                        return -114.1f;

                    default:
                        return 0f;
                }
            }
            else
            {
                switch (compound.ToLower())
                {
                    case "water":
                        return 100.0f;

                    case "benzene":
                        return 80.1f;

                    case "ethanol":
                        return 78.3f;

                    default:
                        return 0f;
                }
            }

        }

        public double GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "water":
                    return 18.015;

                case "benzene":
                    return 78.1134;

                case "ethanol":
                    return 46.0688;

                default:
                    return 0d;
            }
        }

        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "water":
                    return 18.015;

                case "benzene":
                    return 78.1134;

                case "ethanol":
                    return 46.0688;

                default:
                    return 0d;
            }
        }
    }
}