using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class ContainerManager : IParseableBuffer
    {
        public List<Entry> Entries { get; set; }

        public ContainerManager()
        {
            Entries = new List<Entry>();
        }

        public class Entry
        {
            public ulong CNameHash { get; set; }
            public ushort Unknown1 { get; set; }
        }
    }


    public class ContainerManagerParser : INodeParser
    {
        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new ContainerManager();
            var entryCount = br.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new ContainerManager.Entry();

                entry.CNameHash = br.ReadUInt64();
                entry.Unknown1 = br.ReadUInt16();
                data.Entries.Add(entry);
            }
            node.Data = data;
        }
    }

}
