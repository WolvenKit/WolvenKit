using System.IO;
using WolvenKit.RED4.IO;
using System.ComponentModel;

namespace WolvenKit.RED4.Types;

public partial class worldInstancedMeshNode : IRedAppendix
{
    [RED("buffer")]
    [REDProperty(IsIgnored = true)]
    [Browsable(false)]
    public CByteArray Buffer
    {
        get => GetPropertyValue<CByteArray>();
        set => SetPropertyValue<CByteArray>(value);
    }

    public void Read(Red4Reader reader, uint size)
    {
        Buffer = reader.BaseReader.ReadBytes((int)size);
    }

    public void Write(Red4Writer writer) => writer.BaseWriter.Write(Buffer);
}