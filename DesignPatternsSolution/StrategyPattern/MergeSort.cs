using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    internal class MergeSort : SortStrategy
    {
        /// <summary>
        /// A 'ConcreteStrategy' class
        /// </summary>
        public override void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list - not implemented");
        }
    }
}