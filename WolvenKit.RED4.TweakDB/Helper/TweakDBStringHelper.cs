using System.Collections.Generic;
using System.IO;
using WolvenKit.Core.CRC;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.TweakDB.Helper;

public class TweakDBStringHelper
{
    public const uint Magic = 0x0BB1DB57;

    private readonly Dictionary<ulong, string> _hashes = new();

    public bool Load(string path)
    {
        var bytes = File.ReadAllBytes(path);
        var buffer = RedBuffer.CreateBuffer(0, bytes);

        using var ms = new MemoryStream(buffer.GetBytes());
        using var br = new BinaryReader(ms);

        var id = br.BaseStream.ReadStruct<uint>();
        if (id != TweakDBStringHelper.Magic)
        {
            return false;
        }

        var version = br.ReadInt32();
        var numRecords = br.ReadInt32();
        var numFlats = br.ReadInt32();
        var numQueries = br.ReadInt32();

        for (uint i = 0; i < numRecords; i++)
        {
            AddHash(_hashes, br.ReadLengthPrefixedString());
        }

        for (uint i = 0; i < numFlats; i++)
        {
            AddHash(_hashes, br.ReadLengthPrefixedString());
        }

        for (uint i = 0; i < numQueries; i++)
        {
            AddHash(_hashes, br.ReadLengthPrefixedString());
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

    public string GetString(ulong key)
    {
        if (_hashes.ContainsKey(key))
        {
            return _hashes[key];
        }

        return null;
    }

    public Dictionary<ulong, string> GetDictionary() => new(_hashes);
}
