using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class Package : INodeData
{
    public IParseableBuffer Content { get; set; }
}

public class PackageParser : INodeParser
{
    public virtual void Read(BinaryReader reader, NodeEntry node) => Read(reader, node, typeof(inkWidgetLibraryResource));

    protected void Read(BinaryReader reader, NodeEntry node, Type dummyType)
    {
        var dummyBuffer = new RedBuffer();

        reader.ReadInt32(); // dataSize
        var subReader = new PackageReader(reader);
        subReader.ReadBuffer(dummyBuffer, dummyType);

        node.Value = new Package { Content = dummyBuffer.Data };
    }

    public virtual void Write(NodeWriter writer, NodeEntry node) => Write(writer, node, typeof(inkWidgetLibraryResource));
    public virtual void Write(NodeWriter writer, NodeEntry node, Type dummyType)
    {
        using var ms = new MemoryStream();
        using var subWriter = new PackageWriter(ms);
        subWriter.WritePackage((Package04)((Package)node.Value).Content, dummyType);

        var bytes = ms.ToArray();

        writer.Write(bytes.Length);
        writer.Write(bytes);
    }
}
