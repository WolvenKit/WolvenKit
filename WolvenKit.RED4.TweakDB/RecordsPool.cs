using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.Core.CRC;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.TweakDB;

public class RecordsPool : IEnumerable<(TweakDBID id, Type type)>
{
    private readonly Dictionary<ulong, Type> _records = new();

    public int Count => _records.Count;

    public void Add(string name, Type type)
    {
        if (name.Length > byte.MaxValue)
        {
            throw new ArgumentException($"A flat with key must be less or equal with {byte.MaxValue} characters");
        }

        var hash = Crc32Algorithm.Compute(name) + ((ulong)name.Length << 32);
        if (_records.ContainsKey(hash))
        {
            throw new ArgumentException($"A flat with key '{name}' already exists");
        }

        _records.Add(hash, type);
    }

    public void Add(ulong hash, Type type)
    {
        if (_records.ContainsKey(hash))
        {
            throw new ArgumentException($"A flat with the hash '{hash:X8}' already exists");
        }

        _records.Add(hash, type);
    }

    public bool Exists(ulong hash)
    {
        return _records.ContainsKey(hash);
    }

    public List<TweakDBID> GetRecords(bool sortByName = false)
    {
        var list = _records.Keys
            .Select(x => (TweakDBID)x)
            .ToList();

        if (sortByName)
        {
            list.Sort((a, b) => string.Compare(a.GetResolvedText(), b.GetResolvedText(), StringComparison.InvariantCulture));
        }

        return list;
    }

    public Type GetRecord(ulong hash)
    {
        if (_records.ContainsKey(hash))
        {
            return _records[hash];
        }

        return null;
    }

    public IEnumerator<(TweakDBID id, Type type)> GetEnumerator()
    {
        foreach (var pair in _records)
        {
            yield return (pair.Key, pair.Value);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
