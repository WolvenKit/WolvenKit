using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class PlayerSystem : INodeData
{
    public ulong Unk_Hash { get; set; }
    public TweakDBID Unk_Id { get; set; }
}


public class PlayerSystemParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.PLAYER_SYSTEM;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new PlayerSystem();
        data.Unk_Hash = reader.ReadUInt64();
        data.Unk_Id = reader.ReadUInt64();

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (PlayerSystem)node.Value;

        writer.Write(data.Unk_Hash);
        writer.Write((ulong)data.Unk_Id);
    }
}