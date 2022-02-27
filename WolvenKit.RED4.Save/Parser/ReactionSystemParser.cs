namespace WolvenKit.RED4.Save;

public class ReactionSystemParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.REACTION_SYSTEM;

    public void Read(SaveNode node)
    {
        using var ms = new MemoryStream(node.DataBytes);
        using var br = new BinaryReader(ms);
        var data = new ClassName();
        node.Data = data;
    }

    public SaveNode Write() => throw new NotImplementedException();
}
