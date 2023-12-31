using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class worldInstancedOccluderNode : IRedAppendix
{
    [RED("buffer")]
    [REDProperty(IsIgnored = true)]
    public CByteArray Buffer
    {
        get => GetPropertyValue<CByteArray>();
        set => SetPropertyValue<CByteArray>(value);
    }

    partial void PostConstruct()
    {
        Buffer = new CByteArray();
    }

    public void Read(Red4Reader reader, uint size)
    {
        Buffer = reader.BaseReader.ReadBytes((int)size);
    }

    public void Write(Red4Writer writer) => writer.BaseWriter.Write(Buffer);
}