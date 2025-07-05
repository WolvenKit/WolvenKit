using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class gameCompiledSmartObjectData : IRedCustomData
{
    [RED("buffer")]
    [REDProperty(IsIgnored = true)]
    public gameCompiledSmartObjectData_Buffer Buffer
    {
        get => GetPropertyValue<gameCompiledSmartObjectData_Buffer>();
        set => SetPropertyValue<gameCompiledSmartObjectData_Buffer>(value);
    }

    partial void PostConstruct()
    {
        Buffer = new gameCompiledSmartObjectData_Buffer();
    }

    public void CustomRead(Red4Reader reader, uint size)
    {
        if (size == 0)
        {
            return;
        }

        var startPos = reader.BaseStream.Position;

        var tmp = reader.BaseReader.ReadUInt32();
        if (tmp != uint.MaxValue)
        {
            throw new Exception();
        }

        Buffer.Unk1 = reader.BaseReader.ReadByte();

        var length = reader.BaseReader.ReadVLQInt32();
        for (var i = 0; i < length; i++)
        {
            Buffer.Unk2.Add(reader.ReadCUInt16());
        }

        Buffer.Unk3 = reader.BaseReader.ReadByte();

        // Not sure if there is a flag for this. Couldn't find one yet...
        if (reader.BaseStream.Position - startPos < size)
        {
            Buffer.Unk4 = new gameCompiledSmartObjectData_Class1
            {
                Unk1 = reader.BaseReader.ReadUInt64(), 
                Unk2 = reader.ReadCFloat(), 
                Unk3 = reader.ReadCFloat(), 
                Unk4 = reader.ReadCFloat()
            };
        }
    }

    public void CustomWrite(Red4Writer writer)
    {
        writer.BaseWriter.Write(uint.MaxValue);

        writer.Write(Buffer.Unk1);

        writer.BaseWriter.WriteVLQInt32(Buffer.Unk2.Count);
        foreach (var val in Buffer.Unk2)
        {
            writer.Write(val);
        }

        writer.Write(Buffer.Unk3);

        if (Buffer.Unk4 != null)
        {
            writer.BaseWriter.Write((ulong)Buffer.Unk4.Unk1);

            writer.Write(Buffer.Unk4.Unk2);
            writer.Write(Buffer.Unk4.Unk3);
            writer.Write(Buffer.Unk4.Unk4);
        }
    }
}



public class gameCompiledSmartObjectData_Buffer : RedBaseClass
{
    [RED("unk1")]
    public CUInt8 Unk1 {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    [RED("unk2")]
    public CArray<CUInt16> Unk2 {
        get => GetPropertyValue<CArray<CUInt16>>();
        set => SetPropertyValue<CArray<CUInt16>>(value);
    }

    [RED("unk3")]
    public CUInt8 Unk3 {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    [RED("unk4")]
    public gameCompiledSmartObjectData_Class1 Unk4 {
        get => GetPropertyValue<gameCompiledSmartObjectData_Class1>();
        set => SetPropertyValue<gameCompiledSmartObjectData_Class1>(value);
    }

    public gameCompiledSmartObjectData_Buffer()
    {
        Unk2 = new();
    }
}

public class gameCompiledSmartObjectData_Class1 : RedBaseClass
{
    [RED("unk1")]
    public ResourcePath Unk1 {
        get => GetPropertyValue<ResourcePath>();
        set => SetPropertyValue<ResourcePath>(value);
    }

    [RED("unk2")]
    public CFloat Unk2 {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("unk3")]
    public CFloat Unk3 {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [RED("unk4")]
    public CFloat Unk4 {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }
}