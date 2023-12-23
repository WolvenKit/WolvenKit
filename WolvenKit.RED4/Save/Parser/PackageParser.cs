using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;
using EFileReadErrorCodes = WolvenKit.RED4.Archive.IO.EFileReadErrorCodes;

namespace WolvenKit.RED4.Save;

public class Package : INodeData
{
    public IParseableBuffer Content { get; set; }
}

public class PackageParser : INodeParser, IErrorHandler
{
    public virtual void Read(BinaryReader reader, NodeEntry node) => Read(reader, node, RedPackageType.InkLibResource);

    protected void Read(BinaryReader reader, NodeEntry node, RedPackageType redPackageType)
    {
        var dummyBuffer = new RedBuffer();

        var subReader = GetSubReader(reader, node);
        subReader.Settings.RedPackageType = redPackageType;
        subReader.ParsingError += HandleParsingError;

        if (subReader.ReadBuffer(dummyBuffer) != EFileReadErrorCodes.NoError)
        {
            throw new Exception();
        }

        node.Value = new Package { Content = dummyBuffer.Data! };
    }

    protected RedPackageReader GetSubReader(BinaryReader reader, NodeEntry node)
    {
        var dataSize = reader.ReadInt32();
        var buffer = reader.ReadBytes(dataSize);

        return new RedPackageReader(new MemoryStream(buffer));
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

    public event ParsingErrorEventHandler? ParsingError;

    protected virtual bool HandleParsingError(ParsingErrorEventArgs e) => ParsingError != null && ParsingError.Invoke(e);
}
