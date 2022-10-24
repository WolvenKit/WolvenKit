using System;
using System.Reflection;
using System.Text;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;
using Activator = System.Activator;

namespace WolvenKit.RED4.Save;

public class PS2Entry
{
    public ulong Id { get; set; }
    public RedBaseClass Data { get; set; }
}

public class PersistencySystem2 : INodeData
{
    public List<uint> Ids { get; set; } = new();
    public uint Unk1 { get; set; }
    public List<PS2Entry> Entries { get; set; } = new();
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

    public override void ReadClass(RedBaseClass instance, uint size)
    {
        while (Remaining != 0)
        {
            var propNameHash = BaseReader.ReadUInt64();
            if (propNameHash == 0)
            {
                break;
            }

            var propertyInfo = ClassHashHelper.GetPropertyInfo(instance.GetType(), propNameHash);
            if (propertyInfo == null)
            {
                throw new Exception();
            }

            var redTypeHash = ClassHashHelper.GetRedTypeHash(propertyInfo);
            var propTypeHash = BaseReader.ReadUInt64();

            if (redTypeHash != propTypeHash)
            {
                throw new Exception();
            }

            var redTypeInfos = RedReflection.GetRedTypeInfos(propertyInfo.Type, propertyInfo.Flags);

            var value = Read(redTypeInfos, (uint)Remaining);
            instance.SetProperty(propertyInfo.RedName, value);
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
        var result = (IRedHandle)Activator.CreateInstance(type);

        var clsType = ClassHashHelper.GetTypeFromHash(BaseReader.ReadUInt64())!;
        result.SetValue(ReadClass(clsType, (uint)Remaining));

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
        foreach (var propertyInfo in typeInfo.GetWritableProperties())
        {
            var value = instance.GetProperty(propertyInfo.RedName);
            if (!typeInfo.SerializeDefault && !propertyInfo.SerializeDefault && RedReflection.IsDefault(instance.GetType(), propertyInfo, value))
            {
                continue;
            }

            BaseWriter.Write(FNV1A64HashAlgorithm.HashString(propertyInfo.RedName));
            BaseWriter.Write(ClassHashHelper.GetRedTypeHash(propertyInfo));

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

        BaseWriter.Write(ClassHashHelper.GetHashFromType(value.GetType()));
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

                Type? type = null;
                if (classHash != 0)
                {
                    type = ClassHashHelper.GetTypeFromHash(classHash)!;
                }

                var startPos = reader.BaseStream.Position;
                if (type != null)
                {
                    try
                    {
                        var instance1 = RedTypeManager.Create(type);
                        if (size != 0)
                        {
                            using var subMemory = new MemoryStream(reader.ReadBytes((int)size));
                            using var subReader = new PersistencySystem2Reader(subMemory);

                            subReader.ReadClass(instance1, size);
                        }
                        entry.Data = instance1;

                        result.Entries.Add(entry);
                        continue;
                    }
                    catch (Exception)
                    {
                        // could not resolve a property, fall back to Unknown cls
                    }
                }

                reader.BaseStream.Position = startPos;

                var instance2 = new UnknownRedClass { Hash = classHash };
                if (size != 0)
                {
                    instance2.Buffer = reader.ReadBytes((int)size);
                }
                entry.Data = instance2;
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
                if (entry.Data is UnknownRedClass unk)
                {
                    writer.Write(unk.Hash);
                    writer.Write(unk.Buffer.Length);
                    writer.Write(unk.Buffer);
                }
                else
                {
                    writer.Write(ClassHashHelper.GetHashFromType(entry.Data.GetType()));

                    using var subMemory = new MemoryStream();
                    using var subWriter = new PersistencySystem2Writer(subMemory);

                    subWriter.WriteClass(entry.Data);

                    var bytes = subMemory.ToArray()[..^8];
                    writer.Write(bytes.Length);
                    writer.Write(bytes);
                }
            }
        }
    }
}
