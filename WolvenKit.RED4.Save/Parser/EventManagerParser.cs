using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class EventManager : IParseableBuffer
    {
        public List<Entry> Unknown { get; set; }

        public EventManager()
        {
            Unknown = new List<Entry>();
        }

        public class Entry
        {
            public ulong Unknown1 { get; set; }
            public uint Unknown2 { get; set; }
            public ushort Unknown3 { get; set; }
            public ushort Unknown4 { get; set; }
        }
    }


    public class EventManagerParser : INodeParser
    {
        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new EventManager();
            var entryCount = br.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new EventManager.Entry();
                entry.Unknown1 = br.ReadUInt64();
                entry.Unknown2 = br.ReadUInt32();
                entry.Unknown3 = br.ReadUInt16();
                entry.Unknown4 = br.ReadUInt16();
                data.Unknown.Add(entry);
            }
            node.Data = data;

        }
    }

}
