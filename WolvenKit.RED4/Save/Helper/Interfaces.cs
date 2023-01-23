using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public interface INodeData
{
}

public interface INodeParser
{
    public void Read(BinaryReader reader, NodeEntry node);
    public void Write(NodeWriter writer, NodeEntry node);
}
