using System;

namespace AdapterPattern
{
    /// <summary>
    /// The 'Adapter' Class
    /// </summary>
    internal class RichCompoundAdapter : Compound
    {
        private ChemicalDataBank _bank;

        public RichCompoundAdapter(string name) : base(name)
        { }

        public override void Display()
        {
            //the adaptee
            _bank = new ChemicalDataBank();

            _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
            _boilingPoint = _bank.GetCriticalPoint(_chemical, "M");
            _molecularWeight = _bank.GetMolecularWeight(_chemical);

            base.Display();
            Console.WriteLine("Formula: {0}", _molecularFormula);
            Console.WriteLine("Weight: {0}", _molecularWeight);
            Console.WriteLine("Melting Pt: {0}", _meltingPoint);
            Console.WriteLine("Boiling Pt: {0}", _boilingPoint);
        }
    }
}