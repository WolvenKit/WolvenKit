using System.IO;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types;

public partial class scnAnimName : IRedAppendix
{
    [RED("animNames")]
    [REDProperty(IsIgnored = true)]
    public CArray<CName> AnimNames
    {
        get => GetPropertyValue<CArray<CName>>();
        set => SetPropertyValue<CArray<CName>>(value);
    }

    [RED("referenceIndices")]
    [REDProperty(IsIgnored = true)]
    public CArray<CUInt16> ReferenceIndices
    {
        get => GetPropertyValue<CArray<CUInt16>>();
        set => SetPropertyValue<CArray<CUInt16>>(value);
    }

    partial void PostConstruct()
    {
        AnimNames = new CArray<CName>();
        ReferenceIndices = new CArray<CUInt16>();
    }

    public void Read(Red4Reader reader, uint size)
    {
        if (size % 2 != 0)
        {
            throw new TodoException();
        }

        var cnt = size / 2;

        if (Type == Enums.scnAnimNameType.reference || Type == Enums.scnAnimNameType.container)
        {
            ReferenceIndices = new CArray<CUInt16>();
            for (int i = 0; i < cnt; i++)
            {
                ReferenceIndices.Add(reader.BaseReader.ReadUInt16());
            }
        }
        else
        {
            AnimNames = new CArray<CName>();
            for (int i = 0; i < cnt; i++)
            {
                AnimNames.Add(reader.ReadCName());
            }
        }
    }

    public void Write(Red4Writer writer)
    {
        if (Type == Enums.scnAnimNameType.reference || Type == Enums.scnAnimNameType.container)
        {
            foreach (var val in ReferenceIndices)
            {
                writer.Write(val);
            }
        }
        else
        {
            foreach (var val in AnimNames)
            {
                writer.Write(val);
            }
        }
    }
}