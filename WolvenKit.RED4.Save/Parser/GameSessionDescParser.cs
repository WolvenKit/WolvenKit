using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class GameSessionDescParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.GAME_SESSION_DESC;

    public void Read(SaveNode node)
    {
        using var ms = new MemoryStream(node.DataBytes);
        using var br = new BinaryReader(ms);
        var data = new ClassName();
        node.Data = data;
    }

    public SaveNode Write() => throw new NotImplementedException();
}
