using System.Text;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class PS2Entry
{
    public ulong Id { get; set; }
    public Type Type { get; set; }
    public RedBaseClass Data { get; set; }
}

public class PersistencySystem2 : INodeData
{
    public List<uint> Ids { get; set; } = new();
    public uint Unk1 { get; set; }
    public List<PS2Entry> Entries { get; set; } = new();
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

    public override RedBaseClass ReadClass(Type type, uint size)
    {
        var instance = RedTypeManager.Create(type);

        while (Remaining != 0)
        {
            var propNameHash = BaseReader.ReadUInt64();
            if (propNameHash == 0)
            {
                break;
            }

            var propertyInfo = ClassHashHelper.GetPropertyInfo(type, propNameHash);
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

            var value = Read(propertyInfo.Type, (uint)Remaining, propertyInfo.Flags);
            instance.SetProperty(propertyInfo.RedName, value);
        }

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

    public override CEnum<T> ReadCEnum<T>()
    {
        var remaining = Remaining;
        var sizeType = Enum.GetUnderlyingType(typeof(T));
        
        if (sizeType == typeof(sbyte))
        {
            return (Enum)Enum.ToObject(typeof(T), BaseReader.ReadSByte());
        }
        if (sizeType == typeof(byte))
        {
            return (Enum)Enum.ToObject(typeof(T), BaseReader.ReadByte());
        }
        if (sizeType == typeof(short))
        {
            return (Enum)Enum.ToObject(typeof(T), BaseReader.ReadInt16());
        }
        if (sizeType == typeof(ushort))
        {
            return (Enum)Enum.ToObject(typeof(T), BaseReader.ReadUInt16());
        }
        if (sizeType == typeof(int))
        {
            return (Enum)Enum.ToObject(typeof(T), BaseReader.ReadInt32());
        }
        if (sizeType == typeof(uint))
        {
            return (Enum)Enum.ToObject(typeof(T), BaseReader.ReadUInt32());
        }
        if (sizeType == typeof(long))
        {
            return (Enum)Enum.ToObject(typeof(T), BaseReader.ReadInt64());
        }
        if (sizeType == typeof(ulong))
        {
            return (Enum)Enum.ToObject(typeof(T), BaseReader.ReadUInt64());
        }

        throw new Exception();
    }

    public override IRedHandle<T> ReadCHandle<T>()
    {
        var clsType = ClassHashHelper.GetTypeFromHash(BaseReader.ReadUInt64())!;
        return (CHandle<T>)ReadClass(clsType, (uint)Remaining);
    }

    public override IRedArray<T> ReadCArray<T>(uint size)
    {
        var array = new CArray<T>();

        var elementCount = _reader.ReadUInt32();

        var i = 0;
        for (; i < elementCount; i++)
        {
            var element = ReadArrayItem(i, typeof(T), Flags.Empty);
            array.Add((T)element);
        }

        return array;
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

                if (classHash != 0)
                {
                    entry.Type = ClassHashHelper.GetTypeFromHash(classHash)!;
                }

                if (size != 0 && classHash != 0)
                {
                    using var subMemory = new MemoryStream(reader.ReadBytes((int)size));
                    using var subReader = new PersistencySystem2Reader(subMemory);

                    entry.Data = subReader.ReadClass(entry.Type, size);
                }
            }
            result.Entries.Add(entry);
        }

        node.Value = result;
    }

    public void Write(NodeWriter writer, NodeEntry node) => throw new NotImplementedException();
}
