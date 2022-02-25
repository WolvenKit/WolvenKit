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
using System.Text.RegularExpressions;
using System.Collections.Concurrent;

namespace WolvenKit.Common.Services
{
    public class TweakDBService // : ITweakDBService
    {
        private const string tweakdbstr = "WolvenKit.Common.Resources.tweakdb.str";
        private const string tweakdbbin = "WolvenKit.Common.Resources.tweakdb.bin";

        private const uint s_recordSeed = 0x5EEDBA5E;
        private readonly Dictionary<uint, Type> _typeHashes = new();

        private readonly Dictionary<ulong, SAsciiString> _recordHashes = new();
        private readonly Dictionary<ulong, SAsciiString> _flatHashes = new();
        private readonly Dictionary<ulong, SAsciiString> _queryHashes = new();

        private readonly Dictionary<SAsciiString, Type> _recordTypes = new();
        private readonly Dictionary<SAsciiString, uint> _unknownRecordTypes = new();
        private readonly Dictionary<ulong, uint> _unknownRecordHashes = new();

        private readonly Dictionary<SAsciiString, object> _flatValues = new();

        private static readonly ConcurrentDictionary<SAsciiString, Lazy<RedBaseClass>> _recordCache = new();

        public TweakDBService()
        {
            LoadTypes();
            LoadStrings();
            LoadDB();
        }

        public void LoadTypes()
        {
            var classes = Assembly.GetAssembly(typeof(RedBaseClass)).GetTypes()
                .Where(t => t.IsSubclassOf(typeof(RedBaseClass)) && !t.IsAbstract);
            foreach (var t in classes)
            {
                var match = Regex.Match(t.Name, "gamedata(.*)_Record");
                if (match != null && match.Value != "")
                {
                    _typeHashes[Core.Murmur3.Murmur32.Hash(match.Groups[1].Value, s_recordSeed)] = t;
                }
            }
        }

        // new FileInfo(_settingsManager.CP77ExecutablePath)
        public void LoadDB() //FileInfo executable)
        {
            //var di = executable.Directory;
            //if (di?.Parent?.Parent is null)
            //{
            //    return;
            //}

            //if (!di.Exists)
            //{
            //    return;
            //}

            //var tweakdbbin = Path.Combine(di.Parent.Parent.FullName, "r6", "cache", "tweakdb.bin");

            //using var fh = File.OpenRead(tweakdbbin);
            //using var br = new BinaryReader(fh);

            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(tweakdbbin);
            using var br = new BinaryReader(stream);

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

            br.BaseStream.Seek(flatsOffset, SeekOrigin.Begin);

            var flatTypeCounts = new Dictionary<ulong, uint>();
            var numFlatTypes = br.ReadInt32();
            for (int i = 0; i< numFlatTypes; i++)
            {
                var typeHash = br.ReadUInt64();
                var typeCount = br.ReadUInt32();
                flatTypeCounts.Add(typeHash, typeCount);
            }

            var flatTypeValues = new Dictionary<ulong, List<object>>();
            //var flatTypeKeys = new Dictionary<ulong, object>();
            foreach (var (typeHash, typeCount) in flatTypeCounts)
            {
                flatTypeValues[typeHash] = new List<object>();
                var numValues = br.ReadUInt32();
                //Debug.Assert(numValues == typeCount);

                for (int j = 0; j < numValues; j++)
                {
                    var value = br.ReadForHashedType(typeHash);
                    if (value != null)
                    { 
                        flatTypeValues[typeHash].Add(value);
                    }
                    else
                    {
                        
                    }
                }

                var numKeys = br.ReadUInt32();

                for (int j = 0; j < numKeys; j++)
                {
                    var keyHash = br.ReadUInt64();
                    var valueIndex = br.ReadInt32();
                    if (flatTypeValues[typeHash].Count > valueIndex && _flatHashes.ContainsKey(keyHash))
                    {
                        _flatValues[_flatHashes[keyHash]] = flatTypeValues[typeHash][valueIndex];
                    }
                }
            }

            //ReadRecords:

            br.BaseStream.Seek(recordsOffset, SeekOrigin.Begin);

            var numRecords = br.ReadInt32();
            for (int i = 0; i < numRecords; i++)
            {
                var recordHash = br.ReadUInt64();
                var typeHash = br.ReadUInt32();
                if (_recordHashes.ContainsKey(recordHash))
                {
                    if (_typeHashes.ContainsKey(typeHash))
                    {
                        _recordTypes.Add(_recordHashes[recordHash], _typeHashes[typeHash]);
                    }
                    else
                    {
                        _unknownRecordTypes.Add(_recordHashes[recordHash], typeHash);
                    }
                }
                else
                {
                    _unknownRecordHashes.Add(recordHash, typeHash);
                }
            }

            br.BaseStream.Seek(queriesOffset, SeekOrigin.Begin);

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

            br.BaseStream.Seek(groupTagsOffset, SeekOrigin.Begin);

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

            _recordHashes.EnsureCapacity(numRecords);
            _flatHashes.EnsureCapacity(numFlats);
            _queryHashes.EnsureCapacity(numQueries);

            for (uint i = 0; i < numRecords; i++)
            {
                var str = br.ReadLengthPrefixedString();
                var hash = str.ToTweakDBHash();

                if (!_recordHashes.ContainsKey(hash))
                {
                    _recordHashes.Add(hash, new SAsciiString(str));
                }
            }

            for (uint i = 0; i < numFlats; i++)
            {
                var str = br.ReadLengthPrefixedString();
                var hash = str.ToTweakDBHash();

                if (!_flatHashes.ContainsKey(hash))
                {
                    _flatHashes.Add(hash, new SAsciiString(str));
                }
            }

            for (uint i = 0; i < numQueries; i++)
            {
                var str = br.ReadLengthPrefixedString();
                var hash = str.ToTweakDBHash();

                if (!_queryHashes.ContainsKey(hash))
                {
                    _queryHashes.Add(hash, new SAsciiString(str));
                }
            }
        }

        public string GetString(ulong key)
        {
            if (_recordHashes.ContainsKey(key))
            {
                return _recordHashes[key].ToString();
            }
            if (_flatHashes.ContainsKey(key))
            {
                return _flatHashes[key].ToString();
            }
            if (_queryHashes.ContainsKey(key))
            {
                return _queryHashes[key].ToString();
            }

            return "";
        }

        public RedBaseClass GetRecord(TweakDBID tdb)
        {
            if (_recordHashes.ContainsKey((ulong)tdb))
            {
                return GetRecord(_recordHashes[(ulong)tdb]);
            }
            else
            {
                return null;
            }
        }

        public Type GetType(TweakDBID tdb)
        {
            if (_recordHashes.ContainsKey((ulong)tdb))
            {
                return _recordTypes[_recordHashes[(ulong)tdb]];
            }
            else
            {
                return null;
            }
        }

        public RedBaseClass GetRecord(SAsciiString path)
        {
            if (_recordTypes.ContainsKey(path))
            {
                return _recordCache.GetOrAdd(path, (path) =>
                {
                    var type = _recordTypes[path];
                    var cls = RedTypeManager.Create(type);

                    var keys = new Dictionary<string, object>();
                    foreach (var (flat, value) in _flatValues)
                    {
                        var match = Regex.Match(flat.ToString(), path.ToString() + "\\.(.+)");
                        if (match.Success)
                        {
                            var name = match.Groups[1].Value;
                            RedReflection.AddDynamicProperty(cls, name, (IRedType)value);
                        }
                    }

                    return new Lazy<RedBaseClass>(cls);
                }).Value;
            }
            else
            {
                return null;
            }
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
                return (CString)br.ReadLengthPrefixedString();
            }
            if (hash == 11668106722466800856) // array:Int32
            {
                var num = br.ReadInt32();
                var ary = new CArray<CInt32>();
                for(int i = 0; i < num; i++ )
                {
                    ary.Add(br.ReadInt32());
                }
                return ary;
            }
            if (hash == 2653155825417086166) // array:CName
            {
                var num = br.ReadInt32();
                var ary = new CArray<CName>();
                for (int i = 0; i < num; i++)
                {
                    ary.Add(br.ReadLengthPrefixedString());
                }
                return ary;
            }
            if (hash == 15884043155579033811) // array:Vector2
            {
                var num = br.ReadInt32();
                var ary = new CArray<Vector2>();
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
            if (hash == 13406927278374487654) // array:Float
            {
                var num = br.ReadInt32();
                var ary = new CArray<CFloat>();
                for (int i = 0; i < num; i++)
                {
                    ary.Add(br.ReadSingle());
                }
                return ary;
            }
            if (hash == 13805995923452593981) // array:raRef:CResource
            {
                var num = br.ReadInt32();
                var ary = new CArray<CResourceReference<RedBaseClass>>();
                for (int i = 0; i < num; i++)
                {
                    var v = new CResourceReference<RedBaseClass>();
                    v.DepotPath = Locator.Current.GetService<IHashService>().Get(br.ReadUInt64());
                    ary.Add(v);
                }
                return ary;
            }
            if (hash == 10513770639939565077) // array:String
            {
                var num = br.ReadInt32();
                var ary = new CArray<CName>();
                for (int i = 0; i < num; i++)
                {
                    ary.Add((CName)br.ReadLengthPrefixedString());
                }
                return ary;
            }
            if (hash == 15884042056067405600) // array:Vector3
            {
                var num = br.ReadInt32();
                var ary = new CArray<Vector3>();
                for (int i = 0; i < num; i++)
                {
                    var v = new Vector3();
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
                    br.ReadLengthPrefixedString();
                    br.ReadUInt32();
                    v.Z = br.ReadSingle();
                    br.ReadLengthPrefixedString();
                    ary.Add(v);
                }
                return ary;
            }
            if (hash == 17419964233870898637) // Quaternion
            {
                var v = new Quaternion();
                br.ReadByte();
                br.ReadLengthPrefixedString();
                br.ReadLengthPrefixedString();
                br.ReadUInt32();
                v.I = br.ReadSingle();
                br.ReadLengthPrefixedString();
                br.ReadLengthPrefixedString();
                br.ReadUInt32();
                v.J = br.ReadSingle();
                br.ReadLengthPrefixedString();
                br.ReadLengthPrefixedString();
                br.ReadUInt32();
                v.K = br.ReadSingle();
                br.ReadLengthPrefixedString();
                br.ReadLengthPrefixedString();
                br.ReadUInt32();
                v.R = br.ReadSingle();
                br.ReadLengthPrefixedString();
                return v;
            }
            if (hash == 2822982213297947788) // array:bool
            {
                var num = br.ReadInt32();
                var ary = new CArray<CBool>();
                for (int i = 0; i < num; i++)
                {
                    ary.Add((CBool)br.ReadByte());
                }
                return ary;
            }
            if (hash == 3339382240749630511) // array:TweakDBID
            {
                var num = br.ReadInt32();
                var ary = new CArray<TweakDBID>();
                for (int i = 0; i < num; i++)
                {
                    ary.Add((TweakDBID)br.ReadUInt64());
                }
                return ary;
            }
            if (hash == 5941472664459999062) // EulerAngles
            {
                var v = new EulerAngles();
                br.ReadByte();
                br.ReadLengthPrefixedString();
                br.ReadLengthPrefixedString();
                br.ReadUInt32();
                v.Pitch = br.ReadSingle();
                br.ReadLengthPrefixedString();
                br.ReadLengthPrefixedString();
                br.ReadUInt32();
                v.Yaw = br.ReadSingle();
                br.ReadLengthPrefixedString();
                br.ReadLengthPrefixedString();
                br.ReadUInt32();
                v.Roll = br.ReadSingle();
                br.ReadLengthPrefixedString();
                return v;
            }
            if (hash == 7466806054564151715) // Vector3
            {
                br.ReadByte();
                var v = new Vector3();
                br.ReadLengthPrefixedString();
                br.ReadLengthPrefixedString();
                br.ReadUInt32();
                v.X = br.ReadSingle();
                br.ReadLengthPrefixedString();
                br.ReadLengthPrefixedString();
                br.ReadUInt32();
                v.Y = br.ReadSingle();
                br.ReadLengthPrefixedString();
                br.ReadLengthPrefixedString();
                br.ReadUInt32();
                v.Z = br.ReadSingle();
                br.ReadLengthPrefixedString();
                return v;
            }
            if (hash == 12644094645938822750) // raRef:CResource
            {
                var v = new CResourceReference<RedBaseClass>();
                //v.DepotPath = br.ReadUInt64();
                v.DepotPath = Locator.Current.GetService<IHashService>().Get(br.ReadUInt64());
                return v;
            }
            if (hash == 7466804955052523504) // Vector2
            {
                br.ReadByte();
                var v = new Vector2();
                br.ReadLengthPrefixedString();
                br.ReadLengthPrefixedString();
                br.ReadUInt32();
                v.X = br.ReadSingle();
                br.ReadLengthPrefixedString();
                br.ReadLengthPrefixedString();
                br.ReadUInt32();
                v.Y = br.ReadSingle();
                br.ReadLengthPrefixedString();
                return v;
            }
            if (hash == 11953184404591180537) // CName
            {
                return (CName)br.ReadLengthPrefixedString();
            }
            if (hash == 4643797392751916988) // TweakDBID
            {
                return (TweakDBID)br.ReadUInt64();
            }
            if (hash == 14218562033234752749) // gamedataLocKeyWrapper
            {
                return (CUInt64)br.ReadUInt64();
            }
            if (hash == 13376016304518341055) // Int32
            {
                return (CInt32)br.ReadInt32();
            }
            if (hash == 13136800048308857029) // Float
            {
                return (CFloat)br.ReadSingle();
            }
            if (hash == 17851659414560344221) // Bool
            {
                return (CBool)br.ReadByte();
            }
            // etc
            return null;
        }
    }
}
