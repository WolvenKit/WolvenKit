using WolvenKit.Core.Compression;
using WolvenKit.Core.CRC;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.TweakDB.Helper;

public class TweakDBStringHelper
{
    public const uint Magic = 0x0BB1DB57;
    public const int Version = 1;

    private readonly Dictionary<ulong, string> _recordHashes = new();
    private readonly Dictionary<ulong, string> _flatHashes = new();
    private readonly Dictionary<ulong, string> _queryHashes = new();

    public bool Load(string path)
    {
        var bytes = File.ReadAllBytes(path);
        using var ms = new MemoryStream(bytes);
        return LoadFromStream(ms);
    }

    public bool LoadFromStream(Stream stream)
    {
        Stream internalStream;
        if (Oodle.IsCompressed(stream))
        {
            Oodle.DecompressBuffer(stream, out var decompressedBytes);
            internalStream = new MemoryStream(decompressedBytes);
        }
        else
        {
            internalStream = stream;
        }

        using var br = new BinaryReader(internalStream);

        var id = br.BaseStream.ReadStruct<uint>();
        if (id != Magic)
        {
            return false;
        }

        var version = br.ReadInt32();
        if (version != Version)
        {
            return false;
        }

        var numRecords = br.ReadInt32();
        var numFlats = br.ReadInt32();
        var numQueries = br.ReadInt32();

        for (uint i = 0; i < numRecords; i++)
        {
            AddHash(_recordHashes, br.ReadLengthPrefixedString());
        }

        for (uint i = 0; i < numFlats; i++)
        {
            AddHash(_flatHashes, br.ReadLengthPrefixedString());
        }

        for (uint i = 0; i < numQueries; i++)
        {
            AddHash(_queryHashes, br.ReadLengthPrefixedString());
        }

        return true;

        void AddHash(Dictionary<ulong, string> dict, string str)
        {
            var hash = Crc32Algorithm.Compute(str) + ((ulong)str.Length << 32);
            if (!dict.ContainsKey(hash))
            {
                dict.Add(hash, str);
            }
        }
    }

    public void Save(string path)
    {
        using var ms = new MemoryStream();
        using var bw = new BinaryWriter(ms);

        bw.Write(Magic);
        bw.Write(Version);
        bw.Write(_recordHashes.Count);
        bw.Write(_flatHashes.Count);
        bw.Write(_queryHashes.Count);

        var recordHashes = _recordHashes.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        foreach (var (hash, str) in recordHashes)
        {
            bw.WriteLengthPrefixedString(str);
        }

        var flatHashes = _flatHashes.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        foreach (var (hash, str) in flatHashes)
        {
            bw.WriteLengthPrefixedString(str);
        }

        var queryHashes = _queryHashes.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        foreach (var (hash, str) in queryHashes)
        {
            bw.WriteLengthPrefixedString(str);
        }

        var buffer = RedBuffer.CreateBuffer(0, ms.ToArray());
        File.WriteAllBytes(path, buffer.GetCompressedBytes());
    }

    public void AddRecordHash(string str)
    {
        var hash = Crc32Algorithm.Compute(str) + ((ulong)str.Length << 32);
        if (!_recordHashes.ContainsKey(hash))
        {
            _recordHashes.Add(hash, str);
        }
    }

    public void AddFlatHash(string str)
    {
        var hash = Crc32Algorithm.Compute(str) + ((ulong)str.Length << 32);
        if (!_flatHashes.ContainsKey(hash))
        {
            _flatHashes.Add(hash, str);
        }
    }

    public void AddQueryHash(string str)
    {
        var hash = Crc32Algorithm.Compute(str) + ((ulong)str.Length << 32);
        if (!_queryHashes.ContainsKey(hash))
        {
            _queryHashes.Add(hash, str);
        }
    }

    public string GetString(ulong key)
    {
        if (_recordHashes.ContainsKey(key))
        {
            return _recordHashes[key];
        }
        if (_flatHashes.ContainsKey(key))
        {
            return _flatHashes[key];
        }
        if (_queryHashes.ContainsKey(key))
        {
            return _queryHashes[key];
        }

        return null;
    }
}
