using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class gameCompiledSmartObjectData : IRedCustomData
{
    [RED("buffer")]
    [REDProperty(IsIgnored = true)]
    public CByteArray Buffer
    {
        get => GetPropertyValue<CByteArray>();
        set => SetPropertyValue<CByteArray>(value);
    }

    public void CustomRead(Red4Reader reader, uint size) => Buffer = reader.BaseReader.ReadBytes((int)size);

    public void CustomWrite(Red4Writer writer) => writer.BaseWriter.Write(Buffer);
}