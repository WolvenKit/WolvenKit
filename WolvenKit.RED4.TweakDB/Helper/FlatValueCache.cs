using System.Collections;
using System.Collections.Generic;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.TweakDB.Helper;

public class FlatValueCache : IEnumerable<IRedType>
{
    private HashSet<IRedType> _hashSet = new();
    private Dictionary<IRedType, int> _indexDictionary = new();

    public int Count => _hashSet.Count;

    public int GetIndex(IRedType value)
    {
        if (_hashSet.Add(value))
        {
            _indexDictionary.Add(value, _hashSet.Count - 1);
            return _hashSet.Count - 1;
        }

        return _indexDictionary[value];
    }

    public IEnumerator<IRedType> GetEnumerator()
    {
        foreach (var i in _indexDictionary)
        {
            yield return i.Key;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
