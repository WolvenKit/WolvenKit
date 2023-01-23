using System.IO;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types;

public partial class scnAnimName : IRedAppendix
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
    public CArray<CUInt16> Unk2
    {
        get => GetPropertyValue<CArray<CUInt16>>();
        set => SetPropertyValue<CArray<CUInt16>>(value);
    }

    public void Read(Red4Reader reader, uint size)
    {
        if (size % 2 != 0)
        {
            throw new TodoException();
        }

        var cnt = size / 2;

        if (Type == Enums.scnAnimNameType.reference)
        {
            Unk2 = new CArray<CUInt16>();
            for (int i = 0; i < cnt; i++)
            {
                Unk2.Add(reader.BaseReader.ReadUInt16());
            }
        }
        else
        {
            Unk1 = new CArray<CName>();
            for (int i = 0; i < cnt; i++)
            {
                Unk1.Add(reader.ReadCName());
            }
        }
    }

    public void Write(Red4Writer writer)
    {
        if (Type == Enums.scnAnimNameType.reference)
        {
            foreach (var val in Unk2)
            {
                writer.Write(val);
            }
        }
        else
        {
            foreach (var val in Unk1)
            {
                writer.Write(val);
            }
        }
    }
}