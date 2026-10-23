using System.Reflection;
using System.Text;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;
using Activator = System.Activator;

namespace WolvenKit.RED4.Save;

/// <summary>
/// One persistent state object. Entries are decoded lazily: the raw payload is kept on load and only parsed when
/// <see cref="Data"/> is first read (a save holds ~100k entries, and parsing all of them dominated load time).
/// Entries that were never read are written back from their original bytes.
/// </summary>
public class PS2Entry
{
    private RedBaseClass? _data;
    private byte[]? _raw;

    public ulong Id { get; set; }

    /// <summary>Hash of the entry's class name (0 for entries without data).</summary>
    public ulong ClassHash { get; set; }

    /// <summary>The decoded object, or <see cref="UnknownRedClass"/> if it could not be decoded. Null for empty entries.</summary>
    public RedBaseClass Data
    {
        get
        {
            if (_data == null && _raw != null)
            {
                _data = Decode(ClassHash, _raw, out var trailing);
                Trailing = trailing;
                _raw = null;
            }
            return _data!;
        }
        set
        {
            _data = value;
            _raw = null;
            ClassHash = value is UnknownRedClass unknown ? unknown.Hash :
                value != null ? SaveHashHelper.GetHashFromType(value.GetType()) : 0;
        }
    }

    /// <summary>True once <see cref="Data"/> has been decoded or assigned.</summary>
    public bool IsDecoded => _raw == null;

    /// <summary>
    /// Bytes stored after the last property of <see cref="Data"/> (the terminator and any padding),
    /// kept so unmodified entries are written back unchanged.
    /// </summary>
    public byte[] Trailing { get; set; } = Array.Empty<byte>();

    internal byte[]? RawPayload => _raw;

    internal void SetRaw(ulong classHash, byte[] raw)
    {
        ClassHash = classHash;
        _raw = raw;
        _data = null;
    }

    /// <summary>True if this entry holds an object of exactly type <typeparamref name="T"/>, without decoding it.</summary>
    public bool Is<T>() where T : RedBaseClass => Id != 0 && ClassHash == SaveHashHelper.GetHashFromType(typeof(T));

    private static RedBaseClass Decode(ulong classHash, byte[] raw, out byte[] trailing)
    {
        trailing = Array.Empty<byte>();

        var type = classHash != 0 ? SaveHashHelper.GetTypeFromHash(classHash) : null;
        if (type != null)
        {
            try
            {
                var instance = RedTypeManager.Create(type);
                if (raw.Length != 0)
                {
                    using var subReader = new PersistencySystem2Reader(new MemoryStream(raw));
                    subReader.ReadClass(instance, (uint)raw.Length);
                    trailing = raw[(int)subReader.LastPropertyEnd..];
                }
                return instance;
            }
            catch (Exception)
            {
                // could not resolve a property, fall back to Unknown cls
            }
        }

        return new UnknownRedClass { Hash = classHash, Buffer = raw };
    }
}

public class PersistencySystem2 : INodeData
{
    public List<uint> Ids { get; set; } = new();
    public uint Unk1 { get; set; }
    public List<PS2Entry> Entries { get; set; } = new();

    /// <summary>Entries holding exactly type <typeparamref name="T"/>; only these are decoded.</summary>
    public IEnumerable<T> OfType<T>() where T : RedBaseClass =>
        Entries.Where(e => e.Is<T>()).Select(e => e.Data).OfType<T>();
}

public class UnknownRedClass : RedBaseClass
{
    public ulong Hash { get; set; } = 0;
    public byte[] Buffer { get; set; } = Array.Empty<byte>();
}

public class PersistencySystem2Reader : Red4Reader
{
    public PersistencySystem2Reader(Stream input) : base(input)
    {
    }

    public PersistencySystem2Reader(Stream input, Encoding encoding) : base(input, encoding)
    {
    }

    public PersistencySystem2Reader(Stream input, Encoding encoding, bool leaveOpen) : base(input, encoding, leaveOpen)
    {
    }

    public PersistencySystem2Reader(BinaryReader reader) : base(reader)
    {
    }

    public long Remaining => BaseStream.Length - BaseStream.Position;

    /// <summary>
    /// Stream position right after the last property value of the most recently finished ReadClass call.
    /// </summary>
    public long LastPropertyEnd { get; private set; }

    public override void ReadClass(RedBaseClass instance, uint size)
    {
        while (Remaining != 0)
        {
            LastPropertyEnd = BaseStream.Position;
            var propNameHash = BaseReader.ReadUInt64();
            if (propNameHash == 0)
            {
                break;
            }

            var propertyInfo = SaveHashHelper.GetPropertyInfo(instance.GetType(), propNameHash);
            ArgumentNullException.ThrowIfNull(propertyInfo?.RedName);

            var redTypeHash = SaveHashHelper.GetRedTypeHash(propertyInfo);
            var propTypeHash = BaseReader.ReadUInt64();

            if (redTypeHash != propTypeHash)
            {
                throw new Exception();
            }

            var redTypeInfos = RedReflection.GetRedTypeInfos(propertyInfo.Type, propertyInfo.Flags);

            var value = Read(redTypeInfos, (uint)Remaining);
            instance.SetProperty(propertyInfo.RedName, value);
            instance.MarkPropertySerialized(propertyInfo.RedName);
            LastPropertyEnd = BaseStream.Position;
        }
    }

    public override RedBaseClass ReadClass(Type type, uint size)
    {
        var instance = RedTypeManager.Create(type);

        ReadClass(instance, size);

        return instance;
    }

    public override CName ReadCName()
    {
        // TODO: Check this
        return BaseReader.ReadUInt64();
    }

    public override NodeRef ReadNodeRef()
    {
        // TODO: Check this
        return BaseReader.ReadUInt64();
    }

    public override IRedEnum ReadCEnum(List<RedTypeInfo> redTypeInfos, uint size)
    {
        var type = redTypeInfos[0].RedObjectType;
        var sizeType = Enum.GetUnderlyingType(type);

        var obj = Type.GetTypeCode(sizeType) switch
        {
            TypeCode.SByte => Enum.ToObject(type, BaseReader.ReadSByte()),
            TypeCode.Byte => Enum.ToObject(type, BaseReader.ReadByte()),
            TypeCode.Int16 => Enum.ToObject(type, BaseReader.ReadInt16()),
            TypeCode.UInt16 => Enum.ToObject(type, BaseReader.ReadUInt16()),
            TypeCode.Int32 => Enum.ToObject(type, BaseReader.ReadInt32()),
            TypeCode.UInt32 => Enum.ToObject(type, BaseReader.ReadUInt32()),
            TypeCode.Int64 => Enum.ToObject(type, BaseReader.ReadInt64()),
            TypeCode.UInt64 => Enum.ToObject(type, BaseReader.ReadUInt64()),
            _ => throw new ArgumentOutOfRangeException()
        };

        var fullType = RedReflection.GetFullType(redTypeInfos);
        return (IRedEnum)Activator.CreateInstance(fullType, BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { obj }, null)!;
    }

    public override IRedHandle ReadCHandle(List<RedTypeInfo> redTypeInfos, uint size)
    {
        var type = RedReflection.GetFullType(redTypeInfos);
        var clsType = SaveHashHelper.GetTypeFromHash(BaseReader.ReadUInt64())!;

        var instance = ReadClass(clsType, (uint)Remaining);
        if (Activator.CreateInstance(type, instance) is not IRedHandle result)
        {
            throw new Exception();
        }

        return result;
    }

    public override IRedArray ReadCArray(List<RedTypeInfo> redTypeInfos, uint size, bool readAdditionalBytes = true) => base.ReadCArray(redTypeInfos, size, false);
}

public class PersistencySystem2Writer : Red4Writer
{
    public PersistencySystem2Writer(Stream output) : base(output)
    {
    }

    public PersistencySystem2Writer(Stream output, Encoding encoding) : base(output, encoding)
    {
    }

    public PersistencySystem2Writer(Stream output, Encoding encoding, bool leaveOpen) : base(output, encoding, leaveOpen)
    {
    }

    public override void WriteClass(RedBaseClass instance)
    {
        var typeInfo = RedReflection.GetTypeInfo(instance.GetType());
        foreach (var (propertyInfo, force) in instance.GetPropertiesInSerializedOrder())
        {
            ArgumentNullException.ThrowIfNull(propertyInfo.RedName);

            var value = instance.GetProperty(propertyInfo.RedName);
            if (!force && !typeInfo.SerializeDefault && !propertyInfo.SerializeDefault && propertyInfo.IsDefault(value))
            {
                continue;
            }

            BaseWriter.Write(FNV1A64HashAlgorithm.HashString(propertyInfo.RedName));
            BaseWriter.Write(SaveHashHelper.GetRedTypeHash(propertyInfo));

            Write(value);
        }

        BaseWriter.Write((ulong)0);
    }

    public override void Write(CName val) => BaseWriter.Write((ulong)val);
    public override void Write(NodeRef val) => BaseWriter.Write((ulong)val);
    public override void Write(IRedEnum instance)
    {
        var sizeType = Enum.GetUnderlyingType(instance.GetInnerType());
        var value = instance.GetEnumValue();

        if (sizeType == typeof(sbyte))
        {
            BaseWriter.Write(Convert.ToSByte(value));
        }
        if (sizeType == typeof(byte))
        {
            BaseWriter.Write(Convert.ToByte(value));
        }
        if (sizeType == typeof(short))
        {
            BaseWriter.Write(Convert.ToInt16(value));
        }
        if (sizeType == typeof(ushort))
        {
            BaseWriter.Write(Convert.ToUInt16(value));
        }
        if (sizeType == typeof(int))
        {
            BaseWriter.Write(Convert.ToInt32(value));
        }
        if (sizeType == typeof(uint))
        {
            BaseWriter.Write(Convert.ToUInt32(value));
        }
        if (sizeType == typeof(long))
        {
            BaseWriter.Write(Convert.ToInt64(value));
        }
        if (sizeType == typeof(ulong))
        {
            BaseWriter.Write(Convert.ToUInt64(value));
        }
    }

    public override void Write(IRedHandle instance)
    {
        var value = instance.GetValue();

        BaseWriter.Write(SaveHashHelper.GetHashFromType(value.GetType()));
        WriteClass(value);
    }
}

public class PersistencySystem2Parser : INodeParser
{
    public static string NodeName => Constants.NodeNames.PERSISTENCY_SYSTEM_2;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var result = new PersistencySystem2();

        var cnt1 = reader.ReadInt32();
        for (var i = 0; i < cnt1; i++)
        {
            result.Ids.Add(reader.ReadUInt32());
        }

        result.Unk1 = reader.ReadUInt32();

        var cnt2 = reader.ReadInt32();
        for (var i = 0; i < cnt2; i++)
        {
            var entry = new PS2Entry();
            entry.Id = reader.ReadUInt64();
            if (entry.Id != 0)
            {
                var classHash = reader.ReadUInt64();
                var size = reader.ReadUInt32();
                entry.SetRaw(classHash, reader.ReadBytes((int)size));
            }

            result.Entries.Add(entry);
        }

        node.Value = result;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (PersistencySystem2)node.Value;

        writer.Write(data.Ids.Count);
        foreach (var id in data.Ids)
        {
            writer.Write(id);
        }

        writer.Write(data.Unk1);

        writer.Write(data.Entries.Count);
        foreach (var entry in data.Entries)
        {
            writer.Write(entry.Id);
            if (entry.Id != 0)
            {
                if (entry.RawPayload is { } raw)
                {
                    // never decoded, so unchanged
                    writer.Write(entry.ClassHash);
                    writer.Write(raw.Length);
                    writer.Write(raw);
                }
                else if (entry.Data is UnknownRedClass unk)
                {
                    writer.Write(unk.Hash);
                    writer.Write(unk.Buffer.Length);
                    writer.Write(unk.Buffer);
                }
                else
                {
                    writer.Write(SaveHashHelper.GetHashFromType(entry.Data.GetType()));

                    using var subMemory = new MemoryStream();
                    using var subWriter = new PersistencySystem2Writer(subMemory);

                    subWriter.WriteClass(entry.Data);

                    // WriteClass always appends a terminator; the original one (if any) is part of Trailing
                    var bytes = subMemory.ToArray()[..^8];
                    writer.Write(bytes.Length + entry.Trailing.Length);
                    writer.Write(bytes);
                    writer.Write(entry.Trailing);
                }
            }
        }
    }
}
