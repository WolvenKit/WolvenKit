using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class GameSessionConfig : IParseableBuffer
{
    public ulong Hash1 { get; set; }
    public ulong Hash2 { get; set; }
    public string TextValue { get; set; }
    public ulong Hash3 { get; set; }
    public byte[] TrailingBytes { get; set; }

}

public class GameSessionConfigParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.GAME_SESSION_CONFIG_NODE;

    public void Read(SaveNode node)
    {
        using var ms = new MemoryStream(node.DataBytes);
        using var br = new BinaryReader(ms);

        node.Data = new GameSessionConfig
            {
                Hash1 = br.ReadUInt64(),
                Hash2 = br.ReadUInt64(),
                TextValue = br.ReadLengthPrefixedString(),
                Hash3 = br.ReadUInt64(),
                TrailingBytes = br.ReadBytes((int)(br.BaseStream.Length - br.BaseStream.Position))
            };
    }

    public SaveNode Write() => throw new NotImplementedException();
}
