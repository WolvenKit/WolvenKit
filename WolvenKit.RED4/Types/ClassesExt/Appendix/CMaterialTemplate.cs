using System.IO;
using WolvenKit.RED4.IO;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types;

[REDClass(ChildLevel = 1)]
public partial class CMaterialTemplate : IRedAppendix
{
    [RED("parameterInfo")]
    [REDProperty(IsIgnored = true)]
    public CArray<CArray<CMaterialParameterInfo>> ParameterInfo
    {
        get => GetPropertyValue<CArray<CArray<CMaterialParameterInfo>>>()!; // set in PostConstruct, so not nullable
        set => SetPropertyValue<CArray<CArray<CMaterialParameterInfo>>>(value);
    }

    partial void PostConstruct()
    {
        ParameterInfo = new CArray<CArray<CMaterialParameterInfo>>();
    }

    public void Read(Red4Reader reader, uint size)
    {
        ParameterInfo = new();
        var start = reader.BaseStream.Position;
        while (reader.BaseStream.Position < (start + size))
        {
            CArray<CMaterialParameterInfo> s = new();
            var count = reader.BaseReader.ReadByte();
            for (int i = 0; i < count; i++)
            {
                var p = new CMaterialParameterInfo();
                p.Type = reader.BaseReader.ReadByte();
                p.Offset = reader.BaseReader.ReadUInt16();
                p.Name = reader.ReadCName();
                s.Add(p);
            }
            ParameterInfo.Add(s);
        }
    }

    public void Write(Red4Writer writer)
    {
        foreach (var cArr1 in ParameterInfo)
        {
            writer.BaseWriter.Write((byte)cArr1.Count);
            foreach (var parameterInfo in cArr1)
            {
                writer.Write(parameterInfo.Type);
                writer.Write(parameterInfo.Offset);
                writer.Write(parameterInfo.Name);
            }
        }
    }
}

public class CMaterialParameterInfo : RedBaseClass
{
    // enum for type
    // 1 texture
    // 2 colort = 
    // 4 vector
    // 5 scalar
    [RED("type")]
    [REDProperty(IsIgnored = true)]
    [DisplayAsEnum<IMaterialDataProviderDescEParameterType>]
    public CUInt8 Type
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }

    [RED("offset")]
    [REDProperty(IsIgnored = true)]
    public CUInt16 Offset
    {
        get => GetPropertyValue<CUInt16>();
        set => SetPropertyValue<CUInt16>(value);
    }

    [RED("name")]
    [REDProperty(IsIgnored = true)]
    public CName Name
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

}