using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class QuestSystemParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.QUEST_SYSTEM;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        ParserHelper.ReadChildren(reader, node);
    }

    public void Write(NodeWriter writer, NodeEntry node) => ParserHelper.WriteChildren(writer, node);
}
