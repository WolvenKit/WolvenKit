using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WolvenKit.Core.Helpers;

public class LookupTable : IEnumerable<KeyValuePair<ulong, string>>
{
    private readonly ulong[] _keys;
    private readonly string[] _values;

    public LookupTable()
    {
        _keys = [];
        _values = [];
    }

    public LookupTable(IList<ulong> keys, IList<string> values)
    {
        if (keys.Count != values.Count)
        {
            throw new ArgumentException("Keys and values must have the same length.");
        }

        _keys = new ulong[keys.Count];
        _values = new string[keys.Count];

        keys.CopyTo(_keys, 0);
        values.CopyTo(_values, 0);

        Array.Sort(_keys, _values);
    }

    public LookupTable(IList<string> values, int maxDegreeOfParallelism, Func<string, ulong> hashFunc)
    {
        _keys = new ulong[values.Count];
        _values = new string[values.Count];

        values.CopyTo(_values, 0);

        if (maxDegreeOfParallelism > 1)
        {
            Parallel.For(0, values.Count, new ParallelOptions { MaxDegreeOfParallelism = maxDegreeOfParallelism }, i =>
            {
                _keys[i] = hashFunc(values[i]);
            });
        }
        else
        {
            for (var i = 0; i < values.Count; i++)
            {
                _keys[i] = hashFunc(values[i]);
            }
        }

        Array.Sort(_keys, _values);
    }

    public bool ContainsKey(ulong key) => Array.BinarySearch(_keys, key) >= 0;

    public bool TryGetValue(ulong key, out string? value)
    {
        var index = Array.BinarySearch(_keys, key);
        if (index < 0)
        {
            value = null;
            return false;
        }
        value = _values[index];
        return true;
    }

    public IEnumerator<KeyValuePair<ulong, string>> GetEnumerator()
    {
        for (var i = 0; i < _keys.Length; i++)
        {
            yield return new KeyValuePair<ulong, string>(_keys[i], _values[i]);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}