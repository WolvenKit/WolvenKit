using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class physicsMaterialLibraryResource : IRedAppendix
{
    [RED("unk1")]
    [REDProperty(IsIgnored = true)]
    public CArray<CName> Unk1
    {
        get => GetPropertyValue<CArray<CName>>();
        set => SetPropertyValue<CArray<CName>>(value);
    }

    [RED("unk2")]
    [REDProperty(IsIgnored = true)]
    public CArray<CHandle<physicsMaterialResource>> Unk2
    {
        get => GetPropertyValue<CArray<CHandle<physicsMaterialResource>>>();
        set => SetPropertyValue<CArray<CHandle<physicsMaterialResource>>>(value);
    }

    partial void PostConstruct()
    {
        Unk1 = new CArray<CName>();
        Unk2 = new CArray<CHandle<physicsMaterialResource>>();
    }

    public void Read(Red4Reader reader, uint size)
    {
        Unk1 = new CArray<CName>();
        Unk2 = new CArray<CHandle<physicsMaterialResource>>();

        var cnt = reader.BaseReader.ReadVLQInt32();
        for (int i = 0; i < cnt; i++)
        {
            Unk1.Add(reader.ReadCName());
        }

        for (int i = 0; i < cnt; i++)
        {
            Unk2.Add(reader.ReadCHandle<physicsMaterialResource>());
        }
    }

    public void Write(Red4Writer writer)
    {

        writer.WriteVLQ(Unk1.Count);
        foreach (var unk in Unk1)
        {
            writer.Write(unk);
        }

        foreach (var unk in Unk2)
        {
            writer.Write((IRedHandle)unk);
        }
    }
}