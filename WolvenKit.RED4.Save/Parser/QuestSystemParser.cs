namespace WolvenKit.RED4.Save;

public class QuestSystemParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.QUEST_SYSTEM;

    public void Read(SaveNode node)
    {
        foreach (var child in node.Children)
        {
            var parser = ParserHelper.GetParser(child.Name);
            parser?.Read(child);
        }
    }

    public SaveNode Write() => throw new NotImplementedException();
}
