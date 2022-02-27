using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class DynamicEntityIDSystem : IParseableBuffer
    {
        public uint Unknown1 { get; set; }
        public uint Unk_NextEntityHash { get; set; }
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

        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new DynamicEntityIDSystem();
            data.Unknown1 = br.ReadUInt32();
            data.Unk_NextEntityHash = br.ReadUInt32();
            var unkCount = br.ReadUInt32();
            for (int i = 0; i < unkCount; i++)
            {
                data.Unknown3.Add(br.ReadUInt32());
            }
            var stringCount = br.ReadUInt32();
            for (int i = 0; i < stringCount; i++)
            {
                data.Unknown4.Add(new KeyValuePair<string, uint>(br.ReadLengthPrefixedString(), br.ReadUInt32()));
            }
            data.Unk_NextListId = br.ReadUInt32();
            node.Data = data;
        }

        public SaveNode Write() => throw new NotImplementedException();
    }

}
