using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save;

public class TimeSystemCore : INodeData
{
    public uint Unknown1 { get; set; }
    public RED4.Save.GameTime CurrentGameTime { get; set; }
    public byte[] Unknown2 { get; set; }
}
public struct GameTime
{
    public GameTime(uint value)
    {
        Value = value;
    }

    public uint Value { get; }

    public static implicit operator GameTime(uint s)
    {
        return new GameTime(s);
    }

    public static implicit operator uint(GameTime p)
    {
        return p.Value;
    }

    public string ToGameTimeString()
    {
        var time = TimeSpan.FromSeconds(Value);
        return time.ToString(@"d\:hh\:mm\:ss");
    }

    public string ToRealTimeString()
    {
        var time = TimeSpan.FromSeconds(Value / 8);
        return time.ToString(@"d\:hh\:mm\:ss");
    }

    public override string ToString()
    {
        return ToGameTimeString();
    }
}

public class TimeSystemCoreParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.TIME_CORE;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        var data = new TimeSystemCore();
        data.Unknown1 = reader.ReadUInt32();
        data.CurrentGameTime = reader.ReadUInt32();
        data.Unknown2 = reader.ReadBytes(12);

        node.Value = data;
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var value = (TimeSystemCore)node.Value;

        writer.Write(value.Unknown1);
        writer.Write(value.CurrentGameTime);
        writer.Write(value.Unknown2);
    }
}