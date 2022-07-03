using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.Core.CRC;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.TweakDB;

public class GroupTagsPool : IEnumerable<(TweakDBID id, byte val)>
{
    private readonly Dictionary<ulong, byte> _groupTags = new();

    public int Count => _groupTags.Count;

    public void Add(string name, byte val)
    {
        if (name.Length > byte.MaxValue)
        {
            throw new ArgumentException($"A flat with key must be less or equal with {byte.MaxValue} characters");
        }

        var hash = Crc32Algorithm.Compute(name) + ((ulong)name.Length << 32);
        if (_groupTags.ContainsKey(hash))
        {
            throw new ArgumentException($"A flat with key '{name}' already exists");
        }

        _groupTags.Add(hash, val);
    }

    public void Add(ulong hash, byte val)
    {
        if (_groupTags.ContainsKey(hash))
        {
            throw new ArgumentException($"A flat with the hash '{hash:X8}' already exists");
        }

        _groupTags.Add(hash, val);
    }

    public bool Exists(ulong hash)
    {
        return _groupTags.ContainsKey(hash);
    }

    public List<TweakDBID> GetResolvableRecords(bool sortByName = false)
    {
        var list = _groupTags.Keys
            .Select(x => (TweakDBID)x)
            .Where(x => x.GetResolvedText() != null)
            .ToList();

        if (sortByName)
        {
            list.Sort((a, b) => string.Compare(a.GetResolvedText(), b.GetResolvedText(), StringComparison.InvariantCulture));
        }

        return list;
    }

    public byte? GetGroupTag(ulong hash)
    {
        if (_groupTags.ContainsKey(hash))
        {
            return _groupTags[hash];
        }

        return null;
    }

    public IEnumerator<(TweakDBID id, byte val)> GetEnumerator()
    {
        foreach (var pair in _groupTags)
        {
            yield return (pair.Key, pair.Value);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
