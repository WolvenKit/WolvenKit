using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class physicsColliderMesh : IRedAppendix
{
    [RED("unk1")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Unk1
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("unk2")]
    [REDProperty(IsIgnored = true)]
    public CArray<CUInt16> Unk2
    {
        get => GetPropertyValue<CArray<CUInt16>>();
        set => SetPropertyValue<CArray<CUInt16>>(value);
    }

    partial void PostConstruct()
    {
        Unk2 = new CArray<CUInt16>();
    }

    public void Read(Red4Reader reader, uint size)
    {
        Unk2 = new CArray<CUInt16>();

        Unk1 = reader.ReadCUInt16();

        var cnt = reader.BaseReader.ReadVLQInt32();
        for (int i = 0; i < cnt; i++)
        {
            Unk2.Add(reader.ReadCUInt16());
        }
    }

    public void Write(Red4Writer writer)
    {
        writer.Write(Unk1);
        writer.WriteVLQ(Unk2.Count);
        foreach (var entry in Unk2)
        {
            writer.Write(entry);
        }
    }
}