using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class PlayerSystem : IParseableBuffer
    {
        public ulong Unk_Hash { get; set; }
        public TweakDBID Unk_Id { get; set; }
    }


    public class PlayerSystemParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.PLAYER_SYSTEM;

        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new PlayerSystem();
            data.Unk_Hash = br.ReadUInt64();
            data.Unk_Id = br.ReadTweakDbId();
            node.Data = data;
        }

        public SaveNode Write() => throw new NotImplementedException();
    }

}
