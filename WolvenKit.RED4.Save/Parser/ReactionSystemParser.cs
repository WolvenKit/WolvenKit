using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class ReactionSystemParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.REACTION_SYSTEM;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new ClassName();

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node) => throw new NotImplementedException();
}
