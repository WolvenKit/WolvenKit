using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Splat;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model;
using WolvenKit.Core.Compression;
using WolvenKit.Core.CRC;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Services
{
    public class TweakDBService : ITweakDBService
    {
        private const string tweakdbstr = "WolvenKit.Common.Resources.tweakdb.str";

        private readonly Dictionary<ulong, SAsciiString> _records = new();
        private readonly Dictionary<ulong, SAsciiString> _flats = new();
        private readonly Dictionary<ulong, SAsciiString> _queries = new();

        public TweakDBService()
        {
            LoadStrings();
        }

        // new FileInfo(_settingsManager.CP77ExecutablePath)
        public void LoadRecords(FileInfo executable)
        {
            var di = executable.Directory;
            if (di?.Parent?.Parent is null)
            {
                return;
            }

            if (!di.Exists)
            {
                return;
            }

            var tweakdbbin = Path.Combine(di.Parent.Parent.FullName, "r6", "cache", "tweakdb.bin");

            using var fh = File.OpenRead(tweakdbbin);
            using var br = new BinaryReader(fh);

            var magic = br.ReadInt32();

            if (magic != 196205383)
            {
                return;
            }

            var blobVersion = br.ReadInt32();
            var parserVersion = br.ReadInt32();
            var recordsChecksum = br.ReadUInt32();
            var flatsOffset = br.ReadInt32();
            var recordsOffset = br.ReadInt32();
            var queriesOffset = br.ReadInt32();
            var groupTagsOffset = br.ReadInt32();

            var flatTypeCounts = new Dictionary<ulong, uint>();
            var numFlatTypes = br.ReadInt32();
            for (int i = 0; i< numFlatTypes; i++)
            {
                var typeHash = br.ReadUInt64();
                var typeCount = br.ReadUInt32();
                flatTypeCounts.Add(typeHash, typeCount);
            }

            var flatTypeValues = new Dictionary<ulong, List<object>>();
            var flatTypeKeys = new Dictionary<ulong, object>();
            foreach (var (typeHash, typeCount) in flatTypeCounts)
            {
                flatTypeValues[typeHash] = new List<object>();
                var numValues = br.ReadInt32();
                Debug.Assert(numValues == typeCount);

                for (int j = 0; j < numValues; j++)
                {
                    flatTypeValues[typeHash].Add(br.ReadForHashedType(typeHash));
                }

                var numKeys = br.ReadInt32();

                for (int j = 0; j < numKeys; j++)
                {
                    var keyHash = br.ReadUInt64();
                    var valueIndex = br.ReadUInt32();
                    flatTypeKeys[keyHash] = flatTypeValues[valueIndex];
                }
            }


            var numRecords = br.ReadInt32();
            for (int i = 0; i < numRecords; i++)
            {
                var recordHash = br.ReadUInt64();
                var schemaHash = br.ReadUInt32();
            }

            var numQueries = br.ReadInt32();
            for (int i = 0; i < numQueries; i++)
            {
                var tdbName = br.ReadUInt64();
                var numResults = br.ReadUInt32();
                for (int j = 0; j < numResults; j++)
                {
                    var result = br.ReadUInt64();
                }
            }

            var numGroupTags = br.ReadInt32();
            for (int i = 0; i < numGroupTags; i++)
            {
                var tag = br.ReadUInt64();
                var value = br.ReadByte();
            }
        }

        public void LoadStrings()
        {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(tweakdbstr);
            using var br = new BinaryReader(stream);

            var magic = br.ReadInt32();

            if (magic != 196205399)
            {
                return;
            }

            var version = br.ReadInt32();
            var numRecords = br.ReadInt32();
            var numFlats = br.ReadInt32();
            var numQueries = br.ReadInt32();

            _records.EnsureCapacity(numRecords);
            _flats.EnsureCapacity(numFlats);
            _queries.EnsureCapacity(numQueries);

            for (uint i = 0; i < numRecords; i++)
            {
                var str = br.ReadLengthPrefixedString();
                var hash = str.ToTweakDBHash();

                if (!_records.ContainsKey(hash))
                {
                    _records.Add(hash, new SAsciiString(str));
                }
            }

            for (uint i = 0; i < numFlats; i++)
            {
                var str = br.ReadLengthPrefixedString();
                var hash = str.ToTweakDBHash();

                if (!_flats.ContainsKey(hash))
                {
                    _flats.Add(hash, new SAsciiString(str));
                }
            }

            for (uint i = 0; i < numQueries; i++)
            {
                var str = br.ReadLengthPrefixedString();
                var hash = str.ToTweakDBHash();

                if (!_queries.ContainsKey(hash))
                {
                    _queries.Add(hash, new SAsciiString(str));
                }
            }
        }

        public string Get(ulong key)
        {
            if (_records.ContainsKey(key))
            {
                return _records[key].ToString();
            }
            if (_flats.ContainsKey(key))
            {
                return _flats[key].ToString();
            }
            if (_queries.ContainsKey(key))
            {
                return _queries[key].ToString();
            }

            return "";
        }
    }

    public static class TweakDBExtensions
    {
        public static ulong ToTweakDBHash(this string str)
        {
            return Crc32Algorithm.Compute(str) + ((ulong)str.Length << 32);
        }

        public static object ReadForHashedType(this BinaryReader br, ulong hash)
        {
            if (hash == 6391931600911426104) // String
            {
                return br.ReadLengthPrefixedString();
            }
            if (hash == 11668106722466800856) // array:Int32
            {
                var num = br.ReadInt32();
                var ary = new List<Int32>();
                for(int i = 0; i < num; i++ )
                {
                    ary.Add(br.ReadInt32());
                }
                return ary;
            }
            if (hash == 2653155825417086166) // array:CName
            {
                var num = br.ReadInt32();
                var ary = new List<CName>();
                for (int i = 0; i < num; i++)
                {
                    ary.Add(br.ReadLengthPrefixedString());
                }
                return ary;
            }
            if (hash == 15884043155579033811) // array:Vector2
            {
                var num = br.ReadInt32();
                var ary = new List<Vector2>();
                for (int i = 0; i < num; i++)
                {
                    var v = new Vector2();
                    br.ReadByte();
                    br.ReadLengthPrefixedString();
                    br.ReadLengthPrefixedString();
                    br.ReadUInt32();
                    v.X = br.ReadSingle();
                    br.ReadLengthPrefixedString();
                    br.ReadLengthPrefixedString();
                    br.ReadUInt32();
                    v.Y = br.ReadSingle();
                    br.ReadLengthPrefixedString();
                    ary.Add(v);
                }
                return ary;
            }
            // etc
            return null;
        }
    }
}
