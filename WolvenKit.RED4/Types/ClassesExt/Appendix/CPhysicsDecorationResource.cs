using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

[REDClass(ChildLevel = 1)]
public partial class CPhysicsDecorationResource : IRedAppendix
{
    [RED("unk1")]
    [REDProperty(IsIgnored = true)]
    public CInt32 Unk1
    {
        get => GetPropertyValue<CInt32>();
        set => SetPropertyValue<CInt32>(value);
    }

    [RED("unk2")]
    [REDProperty(IsIgnored = true)]
    public DataBuffer Unk2
    {
        get => GetPropertyValue<DataBuffer>()!; // set in PostConstruct, so not nullable
        set => SetPropertyValue<DataBuffer>(value);
    }

    partial void PostConstruct()
    {
        Unk2 = new DataBuffer();
    }

    public void Read(Red4Reader reader, uint size)
    {
        Unk1 = reader.BaseReader.ReadInt32();
        Unk2 = reader.ReadDataBuffer();
    }

    public void Write(Red4Writer writer)
    {
        writer.BaseWriter.Write(Unk1);
        writer.Write(Unk2);
    }
}