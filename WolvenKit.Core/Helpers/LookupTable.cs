using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Core.Helpers;

/// <summary>
/// Computes a hash directly from a string's UTF-8 bytes,
/// without allocating a <see cref="string"/>.
/// </summary>
public delegate ulong Utf8HashFunc(ReadOnlySpan<byte> utf8);

/// <summary>
/// A sorted hash string lookup backed by a single
/// contiguous UTF-8 <see cref="StringBlob"/>
/// plus a pointer-free array of <see cref="StringRef"/> offsets.
/// </summary>
public sealed class LookupTable : IEnumerable<KeyValuePair<ulong, string>>
{
    private readonly ulong[] _keys;
    private readonly StringRef[] _refs;
    private readonly StringBlob _blob;

    public LookupTable()
    {
        _keys = [];
        _refs = [];
        _blob = StringBlob.Empty;
    }

    /// <summary>
    /// Builds a table from explicit keys and values. Intended for small, fixed tables; the strings
    /// are transcoded into a private blob so that the representation stays uniform.
    /// </summary>
    public LookupTable(IList<ulong> keys, IList<string> values)
    {
        if (keys.Count != values.Count)
        {
            throw new ArgumentException("Keys and values must have the same length.");
        }

        _keys = new ulong[keys.Count];
        _refs = new StringRef[keys.Count];

        keys.CopyTo(_keys, 0);

        using var builder = new StringBlobBuilder(EstimateCapacity(values));
        for (var i = 0; i < values.Count; i++)
        {
            _refs[i] = builder.AddUtf16(values[i].AsSpan());
        }

        _blob = builder.Build();

        Array.Sort(_keys, _refs);
    }

    /// <summary>
    /// Convenience overload for callers that already hold strings. Prefer the
    /// <see cref="StringBlob"/> overload, which avoids creating the strings in the first place.
    /// </summary>
    public LookupTable(IList<string> values, int maxDegreeOfParallelism, Func<string, ulong> hashFunc)
    {
        _keys = new ulong[values.Count];
        _refs = new StringRef[values.Count];
        using var builder = new StringBlobBuilder(EstimateCapacity(values));

        for (var i = 0; i < values.Count; i++)
        {
            _refs[i] = builder.AddUtf16(values[i].AsSpan());
        }

        _blob = builder.Build();
        ComputeKeys(values.Count, maxDegreeOfParallelism, i => hashFunc(values[i]));
        Array.Sort(_keys, _refs);
    }

    /// <summary>
    /// Takes ownership of <paramref name="blob"/> and <paramref name="references"/> — neither is
    /// copied — hashes every entry straight from its UTF-8 bytes, and sorts in place.
    /// </summary>
    public LookupTable(StringBlob blob, StringRef[] references, int maxDegreeOfParallelism, Utf8HashFunc hashFunc)
    {
        _blob = blob;
        _refs = references;
        _keys = new ulong[references.Length];

        ComputeKeys(references.Length, maxDegreeOfParallelism, i => hashFunc(_blob.Slice(_refs[i])));

        Array.Sort(_keys, _refs);
    }

    private void ComputeKeys(int count, int maxDegreeOfParallelism, Func<int, ulong> hashAt)
    {
        if (maxDegreeOfParallelism > 1 && count > 1024)
        {
            Parallel.For(0, count, new ParallelOptions { MaxDegreeOfParallelism = maxDegreeOfParallelism },
                i => _keys[i] = hashAt(i));
        }
        else
        {
            for (var i = 0; i < count; i++)
            {
                _keys[i] = hashAt(i);
            }
        }
    }

    private static int EstimateCapacity(IList<string> values)
    {
        var estimate = 0;

        for (var i = 0; i < values.Count && i < 64; i++)
        {
            estimate += values[i].Length + 1;
        }

        return Math.Max(estimate * Math.Max(values.Count / 64, 1), 64);
    }

    public int Count => _keys.Length;

    public bool ContainsKey(ulong key) => Array.BinarySearch(_keys, key) >= 0;

    public bool TryGetValue(ulong key, out string? value)
    {
        var index = Array.BinarySearch(_keys, key);
        if (index < 0)
        {
            value = null;
            return false;
        }

        value = _blob.GetString(_refs[index]);
        return true;
    }

    /// <summary>Raw UTF-8 bytes for the entry at <paramref name="index"/>. Allocates nothing.</summary>
    public ReadOnlySpan<byte> GetUtf8(int index) => _blob.Slice(_refs[index]);

    /// <summary>Allocs the string for the entry at <paramref name="index"/>.</summary>
    public string GetString(int index) => _blob.GetString(_refs[index]);

    public ulong GetKey(int index) => _keys[index];

    public IEnumerator<KeyValuePair<ulong, string>> GetEnumerator()
    {
        for (var i = 0; i < _keys.Length; i++)
        {
            yield return new KeyValuePair<ulong, string>(_keys[i], _blob.GetString(_refs[i]));
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
