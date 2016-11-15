using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    internal class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); //Default is QuickSort
            Console.WriteLine("QuickSorted list");
        }
    }
}