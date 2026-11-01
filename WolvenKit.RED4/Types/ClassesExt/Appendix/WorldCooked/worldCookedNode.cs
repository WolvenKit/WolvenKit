using System.Xml.Linq;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class worldCookedNode : IRedAppendix
{
    [RED("buffer")]
    [REDProperty(IsIgnored = true)]
    public DataBuffer Buffer
    {
        get => GetPropertyValue<DataBuffer>();
        set => SetPropertyValue<DataBuffer>(value);
    }

    partial void PostConstruct()
    {
        Buffer = new DataBuffer();
    }

    public virtual void Read(Red4Reader reader, uint size)
    {
        Buffer.Buffer = RedBuffer.CreateBuffer(0, reader.BaseReader.ReadBytes((int)size));
    }

    public virtual void Write(Red4Writer writer)
    {
        writer.BaseWriter.Write(Buffer.Buffer.GetBytes());
    }

    public virtual ProcessTime GetProcessTime() => ProcessTime.OnFileProcessing;

    public virtual void LoadData(RedBaseClass cls)
    {
        // throw new NotImplementedException();
    }

    public virtual void StoreData()
    {
        // throw new NotImplementedException();
    }
}
