using System.Collections;

namespace IteratorPattern
{
    internal class ConcreteAggregate : Aggregate
    {
        private ArrayList _items = new ArrayList();

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }

        public int Count => _items.Count;

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}