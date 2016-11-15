using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    internal class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not implemented
            Console.WriteLine("Shellsorted list - not implemented");
        }
    }
}