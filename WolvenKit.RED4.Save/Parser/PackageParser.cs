using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class PackageParser : INodeParser
{
    public virtual void Read(BinaryReader reader, NodeEntry node) => Read(reader, node, typeof(inkWidgetLibraryResource));

    protected void Read(BinaryReader reader, NodeEntry node, Type dummyType)
    {
        var dummyBuffer = new RedBuffer();

        var subReader = new PackageReader(reader);
        subReader.ReadBuffer(dummyBuffer, dummyType);

        node.Value = dummyBuffer.Data;
    }

    public virtual void Write(NodeWriter writer, NodeEntry node) => throw new NotImplementedException();
}
