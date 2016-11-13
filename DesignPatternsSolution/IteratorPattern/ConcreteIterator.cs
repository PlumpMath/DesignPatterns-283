namespace IteratorPattern
{
    internal class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _concreteAggregate;
        private int _current = 0;

        public ConcreteIterator(ConcreteAggregate concreteAggregate)
        {
            this._concreteAggregate = concreteAggregate;
        }

        public override object First()
        {
            return _concreteAggregate[0];
        }

        public override object Next()
        {
            object ret = null;

            if (_current < _concreteAggregate.Count - 1)
            {
                ret = _concreteAggregate[++_current];
            }

            return ret;
        }

        public override bool IsDone()
        {
            return _current >= _concreteAggregate.Count;
        }

        public override object CurrentItem()
        {
            return _concreteAggregate[_current];
        }
    }
}