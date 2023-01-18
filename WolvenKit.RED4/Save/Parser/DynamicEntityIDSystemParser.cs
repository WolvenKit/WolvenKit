using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class DynamicEntityIDSystem : INodeData
{
    public uint NextNonSavableEntityID { get; set; }
    public uint NextSavableEntityID { get; set; }
    public List<uint> Unknown3 { get; set; }
    public List<KeyValuePair<string, uint>> Unknown4 { get; set; }
    public uint Unk_NextListId { get; set; }

    public DynamicEntityIDSystem()
    {
        Unknown3 = new List<uint>();
        Unknown4 = new List<KeyValuePair<string, uint>>();
    }
}


public class DynamicEntityIDSystemParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.DYNAMIC_ENTITYID_SYSTEM;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new DynamicEntityIDSystem();
        data.NextNonSavableEntityID = reader.ReadUInt32();
        data.NextSavableEntityID = reader.ReadUInt32();
        var unkCount = reader.ReadUInt32();
        for (int i = 0; i < unkCount; i++)
        {
            data.Unknown3.Add(reader.ReadUInt32());
        }
        var stringCount = reader.ReadUInt32();
        for (int i = 0; i < stringCount; i++)
        {
            data.Unknown4.Add(new KeyValuePair<string, uint>(reader.ReadLengthPrefixedString(), reader.ReadUInt32()));
        }
        data.Unk_NextListId = reader.ReadUInt32();

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var data = (DynamicEntityIDSystem)node.Value;

        writer.Write(data.NextNonSavableEntityID);
        writer.Write(data.NextSavableEntityID);

        writer.Write(data.Unknown3.Count);
        foreach (var item in data.Unknown3)
        {
            writer.Write(item);
        }

        writer.Write(data.Unknown4.Count);
        foreach (var pair in data.Unknown4)
        {
            writer.WriteLengthPrefixedString(pair.Key);
            writer.Write(pair.Value);
        }

        writer.Write(data.Unk_NextListId);
    }
}