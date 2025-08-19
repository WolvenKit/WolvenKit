using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class physicsMaterialLibraryResource : IRedAppendix
{
    [RED("materialNames")]
    [REDProperty(IsIgnored = true)]
    public CArray<CName> MaterialNames
    {
        get => GetPropertyValue<CArray<CName>>();
        set => SetPropertyValue<CArray<CName>>(value);
    }

    [RED("materialValues")]
    [REDProperty(IsIgnored = true)]
    public CArray<CHandle<physicsMaterialResource>> MaterialValues
    {
        get => GetPropertyValue<CArray<CHandle<physicsMaterialResource>>>();
        set => SetPropertyValue<CArray<CHandle<physicsMaterialResource>>>(value);
    }

    partial void PostConstruct()
    {
        MaterialNames = new CArray<CName>();
        MaterialValues = new CArray<CHandle<physicsMaterialResource>>();
    }

    public void Read(Red4Reader reader, uint size)
    {
        MaterialNames = new CArray<CName>();
        MaterialValues = new CArray<CHandle<physicsMaterialResource>>();

        var cnt = reader.BaseReader.ReadVLQInt32();
        for (var i = 0; i < cnt; i++)
        {
            MaterialNames.Add(reader.ReadCName());
        }

        for (var i = 0; i < cnt; i++)
        {
            MaterialValues.Add(reader.ReadCHandle<physicsMaterialResource>());
        }
    }

    public void Write(Red4Writer writer)
    {

        writer.WriteVLQ(MaterialNames.Count);
        foreach (var materialName in MaterialNames)
        {
            writer.Write(materialName);
        }

        foreach (var materialValue in MaterialValues)
        {
            writer.Write((IRedHandle)materialValue);
        }
    }
}
