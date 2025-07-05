using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class GameSessionDesc : INodeData
{
    public GameSessionConfig GameSessionConfig { get; set; }
}

public class GameSessionDescParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.GAME_SESSION_DESC;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        if (node.Children.Count != 1 && node.Children[0].Name != "game::SessionConfig")
        {
            throw new InvalidFormatException();
        }

        ParserHelper.ReadNode(reader, node.Children[0]);
        node.Children[0].ReadByParent = true;
        node.Value = new GameSessionDesc
        {
            GameSessionConfig = (GameSessionConfig)node.Children[0].Value
        };
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        foreach (var child in node.Children)
        {
            writer.Write(child);

        }
    }
}
