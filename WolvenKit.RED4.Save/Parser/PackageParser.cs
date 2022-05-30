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
    public virtual void Read(BinaryReader reader, NodeEntry node) => Read(reader, node, RedPackageType.InkLibResource);

    protected void Read(BinaryReader reader, NodeEntry node, RedPackageType redPackageType)
    {
        var dummyBuffer = new RedBuffer();

        reader.ReadInt32(); // dataSize
        var subReader = new RedPackageReader(reader);
        subReader.Settings.RedPackageType = redPackageType;

        subReader.ReadBuffer(dummyBuffer);

        node.Value = new Package { Content = dummyBuffer.Data };
    }

    public virtual void Write(NodeWriter writer, NodeEntry node) => Write(writer, node, RedPackageType.InkLibResource);
    public virtual void Write(NodeWriter writer, NodeEntry node, RedPackageType redPackageType)
    {
        using var ms = new MemoryStream();
        using var subWriter = new RedPackageWriter(ms);
        subWriter.Settings.RedPackageType = redPackageType;

        subWriter.WritePackage((RedPackage)((Package)node.Value).Content);

        var bytes = ms.ToArray();

        writer.Write(bytes.Length);
        writer.Write(bytes);
    }
}
