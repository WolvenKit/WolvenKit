using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class GameSessionDesc : IParseableBuffer
{
    public GameSessionConfig GameSessionConfig { get; set; }
}

public class GameSessionDescParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.GAME_SESSION_DESC;

    public void Read(SaveNode node)
    {
        if (node.Children.Count != 1 && node.Children[0].Name != "game::SessionConfig")
        {
            throw new InvalidFormatException();
        }

        var parser = ParserHelper.GetParser(node.Children[0].Name);
        parser?.Read(node.Children[0]);

        node.Data = new GameSessionDesc
        {
            GameSessionConfig = (GameSessionConfig)node.Children[0].Data
        };
    }

    public SaveNode Write() => throw new NotImplementedException();
}
