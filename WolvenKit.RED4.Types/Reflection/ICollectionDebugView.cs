using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WolvenKit.RED4.Types;

internal sealed class ICollectionDebugView<T>
{
    private readonly ICollection<T> _collection;

    public ICollectionDebugView(ICollection<T> collection)
    {
        _collection = collection ?? throw new ArgumentNullException(nameof(collection));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public T[] Items
    {
        get
        {
            var items = new T[_collection.Count];
            _collection.CopyTo(items, 0);
            return items;
        }
    }
}
