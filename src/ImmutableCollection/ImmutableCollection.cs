using System;
using System.Collections.Generic;

namespace src.ImmutableCollection
{
    public class ImmutableCollection<T>: IImmutableCollection<T>
    {
        private readonly List<T> _immutableCollection;
        public ImmutableCollection(List<T> collection)
        {
            this._immutableCollection = collection;
        }
        public IImmutableCollection<T> Add(T e)
        {
            throw new NotImplementedException("Add");
        }

        public IImmutableCollection<T> Remove(T e)
        {
            throw new NotImplementedException("Remove");
        }

        public int Size()
        {
            return _immutableCollection.Count;
        }
    }
}
