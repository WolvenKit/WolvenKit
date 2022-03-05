using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Murmur3;
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

        public Dictionary<TweakDBID, IRedType> Flats { get; set; }
        public Dictionary<TweakDBID, Type> Records { get; set; }
        public Dictionary<TweakDBID, List<TweakDBID>> Queries { get; set; }
        public Dictionary<TweakDBID, byte> GroupTags { get; set; }


        /// <summary>
        /// Add a new flat value to the pool.
        /// </summary>
        /// <param name="name">The flat's name.</param>
        /// <param name="value">The value.</param>
        public void Add(string name, IRedType value) => Flats.Add(name, value);

        /// <summary>
        /// Add a new record to the pool.
        /// </summary>
        /// <param name="name">The flat's name.</param>
        /// <param name="record">The value.</param>
        public void Add(string name, gamedataTweakDBRecord record)
        {
            foreach (var propertyName in record.GetDynamicPropertyNames())
            {
                Flats.Add($"{name}.{propertyName}", record.GetObjectByRedName(propertyName));
            }

            Records.Add(name, record.GetType());
        }
    }
}
