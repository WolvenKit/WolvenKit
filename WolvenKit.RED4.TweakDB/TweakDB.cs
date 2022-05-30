using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.TweakDB
{
    /// <summary>
    /// A Tweak Database.
    /// </summary>
    /// <remarks>
    /// How to use:
    /// <code>
    /// var db = new TweakDB();
    /// 
    /// db.Add("WolvenKit.Var1", new CBool { Value = true });
    /// db.Add("WolvenKit.Var2", new CBool { Value = false });
    /// db.Add("WolvenKit.Var3", new CBool { Value = true });
    /// db.Add("WolvenKit.Var4", new CInt32 { Value = 20210818 });
    /// db.Add("WolvenKit.Var5", new CFloat { Value = 123.321f });
    /// db.Add("WolvenKit.Var6", new CName { Text = "Hello rfuzzo!" });
    /// db.Add("WolvenKit.Var7", new CString { Text = "I hate this :(" });
    /// 
    /// db.Save("tweakdb_delta.bin");
    /// </code>
    /// </remarks>
    public class TweakDB
    {
        public const uint Magic = 0x0BB1DB47;
        public const uint RecordsSeed = 0x5EEDBA5E;

        public const uint BlobVersion = 5;
        public const uint ParserVersion = 4;

        public FlatsPool Flats { get; set; } = new();
        public RecordsPool Records { get; set; } = new();
        public Dictionary<TweakDBID, List<TweakDBID>> Queries { get; set; } = new();
        public Dictionary<TweakDBID, byte> GroupTags { get; set; } = new();


        /// <summary>
        /// Add a new flat value to the pool.
        /// </summary>
        /// <param name="name">The flat's name.</param>
        /// <param name="value">The value.</param>
        public void Add(string name, IRedType value)
        {
            if (name.Length > byte.MaxValue)
            {
                throw new ArgumentException();
            }

            Flats.Add(name, value);
        }

        /// <summary>
        /// Add a new record to the pool.
        /// </summary>
        /// <param name="name">The flat's name.</param>
        /// <param name="record">The value.</param>
        public void Add(string name, gamedataTweakDBRecord record)
        {
            var typeInfo = RedReflection.GetTypeInfo(record);
            foreach (var propertyInfo in typeInfo.PropertyInfos)
            {
                var value = record.GetProperty(propertyInfo.RedName);
                if (!typeInfo.SerializeDefault && RedReflection.IsDefault(record.GetType(), propertyInfo, value))
                {
                    continue;
                }

                Add($"{name}.{propertyInfo.RedName}", value);
            }

            Records.Add(name, record.GetType());
        }

        public IRedType GetFlatValue(string path)
        {
            foreach (var (id, value) in Flats)
            {
                if (id == path)
                {
                    return value;
                }
            }

            return null;
        }

        public List<TweakDBID> GetRecords() => Records.GetResolvableRecords(true);

        public Type GetRecordType(string path)
        {
            foreach (var (id, type) in Records)
            {
                var resolvedName = id.GetResolvedText();
                if (resolvedName == null)
                {
                    continue;
                }

                if (resolvedName == path)
                {
                    return type;
                }
            }

            return null;
        }

        public gamedataTweakDBRecord GetFullRecord(string path)
        {
            var type = GetRecordType(path);
            if (type == null)
            {
                return null;
            }

            var instance = RedTypeManager.Create(type);
            var values = Flats.GetRecordValues(path);

            var typeInfo = RedReflection.GetTypeInfo(instance);
            foreach (var propertyInfo in typeInfo.PropertyInfos)
            {
                if (values.ContainsKey(propertyInfo.RedName))
                {
                    instance.SetProperty(propertyInfo.RedName, values[propertyInfo.RedName]);
                }
            }

            return (gamedataTweakDBRecord)instance;
        }
    }
}
