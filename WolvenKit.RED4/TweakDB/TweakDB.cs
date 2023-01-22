using WolvenKit.Core.CRC;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.TweakDB;

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
    public QueriesPool Queries { get; set; } = new();
    public GroupTagsPool GroupTags { get; set; } = new();


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
            ArgumentNullException.ThrowIfNull(propertyInfo.RedName);

            var value = record.GetProperty(propertyInfo.RedName);
            if (!typeInfo.SerializeDefault && RedReflection.IsDefault(record.GetType(), propertyInfo, value))
            {
                continue;
            }

            ArgumentNullException.ThrowIfNull(value);

            Add($"{name}.{propertyInfo.RedName}", value);
        }

        Records.Add(name, record.GetType());
    }

    public IRedType? GetFlatValue(string path)
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

    public List<TweakDBID> GetRecords() => Records.GetRecords();
    public List<TweakDBID> GetFlats() => Flats.GetRecords();
    public List<TweakDBID> GetQueries() => Queries.GetRecords();
    public List<TweakDBID> GetGroupTags() => GroupTags.GetRecords();

    public Type? GetRecordType(TweakDBID targetId)
    {
        foreach (var (id, type) in Records)
        {
            if (id == targetId)
            {
                return type;
            }
        }

        return null;
    }

    public gamedataTweakDBRecord? GetFullRecord(TweakDBID targetId)
    {
        var type = GetRecordType(targetId);
        if (type == null)
        {
            return null;
        }

        var instance = RedTypeManager.Create(type);

        var values = new Dictionary<string, IRedType>();
        if (targetId.ResolvedText != null)
        {
            values = Flats.GetRecordValues(targetId.ResolvedText);
        }

        var typeInfo = RedReflection.GetTypeInfo(instance);
        foreach (var propertyInfo in typeInfo.PropertyInfos)
        {
            ArgumentNullException.ThrowIfNull(propertyInfo.RedName);

            if (targetId.ResolvedText != null)
            {
                if (values.ContainsKey(propertyInfo.RedName))
                {
                    instance.SetProperty(propertyInfo.RedName, values[propertyInfo.RedName]);

                    values.Remove(propertyInfo.RedName);
                }
            }
            else
            {
                var crc = ((uint)targetId & 0xFFFFFFFF);
                var length = (uint)(targetId >> 32);
                var add = System.Text.Encoding.ASCII.GetBytes("." + propertyInfo.RedName);

                var newHash = Crc32Algorithm.Append(crc, add) + ((ulong)(length + add.Length) << 32);

                var value = Flats.GetValue(newHash);
                if (value != null)
                {
                    instance.SetProperty(propertyInfo.RedName, value);
                }
            }
        }

        if (values.Count > 0)
        {
            foreach (var pair in values)
            {
                typeInfo.AddDynamicProperty(pair.Key, RedReflection.GetRedTypeFromCSType(pair.Value.GetType(), Flags.Empty));
                instance.SetProperty(pair.Key, pair.Value);
            }
        }

        return (gamedataTweakDBRecord)instance;
    }
}