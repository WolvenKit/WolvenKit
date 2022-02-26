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
        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new CommunitySystem();
            var entryCount = br.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                data.Unk_HashList.Add(br.ReadUInt64());
            }
            data.TrailingBytes = br.ReadBytes((int)(br.BaseStream.Length - br.BaseStream.Position));
            node.Data = data;

        }
    }

}
