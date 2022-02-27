using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class PackageParser : INodeParser
{
    public virtual void Read(SaveNode node) => Read(node, typeof(inkWidgetLibraryResource));

    protected void Read(SaveNode node, Type dummyType)
    {
        using var ms = new MemoryStream(node.DataBytes[4..]);
        using var br = new BinaryReader(ms);

        var dummyBuffer = new RedBuffer();

        var reader = new PackageReader(br);
        reader.ReadBuffer(dummyBuffer, dummyType);

        node.Data = dummyBuffer.Data;
    }

    public virtual SaveNode Write() => throw new NotImplementedException();
}
