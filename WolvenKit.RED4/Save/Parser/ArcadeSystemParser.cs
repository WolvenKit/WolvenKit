using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class ArcadeSystem : INodeData
{
    public List<float> HighScores { get; set; } = new();
}

public class ArcadeSystemParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.ARCADE_SYSTEM;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new ArcadeSystem();

        var cnt = reader.ReadUInt32();
        for (var i = 0; i < cnt; i++)
        {
            data.HighScores.Add(reader.ReadSingle());
        }

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (ArcadeSystem)node.Value;

        writer.Write(data.HighScores.Count);
        foreach (var highScore in data.HighScores)
        {
            writer.Write(highScore);
        }
    }
}
