using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.Core.CRC;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.TweakDB;

public class QueriesPool : IEnumerable<(TweakDBID id, List<TweakDBID> val)>
{
    private readonly Dictionary<ulong, List<TweakDBID>> _queries = new();

    public int Count => _queries.Count;

    public void Add(string name, List<TweakDBID> val)
    {
        if (name.Length > byte.MaxValue)
        {
            throw new ArgumentException($"A flat with key must be less or equal with {byte.MaxValue} characters");
        }

        var hash = Crc32Algorithm.Compute(name) + ((ulong)name.Length << 32);
        if (_queries.ContainsKey(hash))
        {
            throw new ArgumentException($"A flat with key '{name}' already exists");
        }

        _queries.Add(hash, val);
    }

    public void Add(ulong hash, List<TweakDBID> val)
    {
        if (_queries.ContainsKey(hash))
        {
            throw new ArgumentException($"A flat with the hash '{hash:X8}' already exists");
        }

        _queries.Add(hash, val);
    }

    public bool Exists(ulong hash)
    {
        return _queries.ContainsKey(hash);
    }

    public List<TweakDBID> GetRecords() =>
        _queries.Keys
            .Select(x => (TweakDBID)x)
            .ToList();

    public List<TweakDBID> GetQuery(ulong hash)
    {
        if (_queries.ContainsKey(hash))
        {
            return _queries[hash];
        }

        return null;
    }

    public IEnumerator<(TweakDBID id, List<TweakDBID> val)> GetEnumerator()
    {
        foreach (var pair in _queries)
        {
            yield return (pair.Key, pair.Value);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
