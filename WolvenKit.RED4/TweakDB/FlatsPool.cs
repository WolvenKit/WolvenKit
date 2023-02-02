using System.Collections;
using WolvenKit.Core.CRC;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.TweakDB;

public class FlatsPool : IEnumerable<(TweakDBID id, IRedType value)>
{
    private readonly HashSet<ulong> _hashes = new();
    private readonly Dictionary<ulong, IRedType> _flatDictionary = new();

    private readonly Dictionary<string, List<string>> _recordLookUp = new();

    public IEnumerator<(TweakDBID id, IRedType value)> GetEnumerator()
    {
        foreach (var pair in _flatDictionary)
        {
            yield return (pair.Key, pair.Value);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Add(string name, IRedType value)
    {
        if (name.Length > byte.MaxValue)
        {
            throw new ArgumentException($"A flat with key must be less or equal with {byte.MaxValue} characters");
        }

        var hash = Crc32Algorithm.Compute(name) + ((ulong)name.Length << 32);
        if (!_hashes.Add(hash))
        {
            throw new ArgumentException($"A flat with key '{name}' already exists");
        }

        AddLookUp(name);
        _flatDictionary.Add(hash, value);
    }

    public void Add(TweakDBID keyHash, IRedType redType)
    {
        var hash = (ulong)keyHash;
        if (!_hashes.Add(hash))
        {
            throw new ArgumentException($"A flat with the hash '{hash:X8}' already exists");
        }

        AddLookUp(keyHash.GetResolvedText());
        _flatDictionary.Add(keyHash, redType);
    }

    private void AddLookUp(string? name)
    {
        if (name == null)
        {
            return;
        }

        var parts = name.Split('.');
        if (parts.Length != 3)
        {
            return;
        }

        var recordName = string.Join('.', parts[..2]);
        if (!_recordLookUp.ContainsKey(recordName))
        {
            _recordLookUp.Add(recordName, new List<string>());
        }
        _recordLookUp[recordName].Add(parts[2]);
    }

    public bool Exists(ulong id)
    {
        return _flatDictionary.ContainsKey(id);
    }

    public List<TweakDBID> GetRecords() =>
        _flatDictionary.Keys
            .Select(x => (TweakDBID)x)
            .ToList();

    public IRedType? GetValue(string name)
    {
        var id = Crc32Algorithm.Compute(name) + ((ulong)name.Length << 32);
        return GetValue(id);
    }

    public IRedType? GetValue(ulong id)
    {
        if (_flatDictionary.ContainsKey(id))
        {
            return _flatDictionary[id];
        }

        return null;
    }

    public Dictionary<string, IRedType> GetRecordValues(string recordName)
    {
        var result = new Dictionary<string, IRedType>();

        if (_recordLookUp.ContainsKey(recordName))
        {
            var properties = _recordLookUp[recordName];
            foreach (var property in properties)
            {
                var flatName = string.Join('.', recordName, property);
                var flatHash = Crc32Algorithm.Compute(flatName) + ((ulong)flatName.Length << 32);

                result.Add(property, _flatDictionary[flatHash]);
            }
        }

        return result;
    }
}