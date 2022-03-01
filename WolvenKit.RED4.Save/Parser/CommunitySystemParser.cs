using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save
{
    public class CommunitySystem : IParseableBuffer
    {
        public List<ulong> Unk_HashList { get; set; }
        public byte[] TrailingBytes { get; set; }

        public CommunitySystem()
        {
            Unk_HashList = new List<ulong>();
        }
    }


    public class CommunitySystemParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.COMMUNITY_SYSTEM;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new CommunitySystem();
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                data.Unk_HashList.Add(reader.ReadUInt64());
            }
            data.TrailingBytes = reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position));

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node) => throw new NotImplementedException();
    }

}
