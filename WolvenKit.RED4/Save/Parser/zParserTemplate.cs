using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class ClassName : INodeData
{
}


public class ClassNameParser : INodeParser
{
    // public static string NodeName => "";

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new ClassName();

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node) => throw new NotImplementedException();
}