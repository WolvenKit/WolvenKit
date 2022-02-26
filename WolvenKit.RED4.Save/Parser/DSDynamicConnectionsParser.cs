using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class DSDynamicConnections : IParseableBuffer
    {
        public List<Entry> Entries { get; set; }

        public DSDynamicConnections()
        {
            Entries = new List<Entry>();
        }

        public class Entry
        {
            public ulong Unknown1 { get; set; }
            public string Unknown2 { get; set; }
            public List<ulong> Unknown3 { get; set; }
            public List<ulong> Unknown4 { get; set; }
            public byte[] Unknown5 { get; set; }
            public string Unknown6 { get; set; }

            public Entry()
            {
                Unknown3 = new List<ulong>();
                Unknown4 = new List<ulong>();
            }
        }
    }


    public class DSDynamicConnectionsParser : INodeParser
    {
        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new DSDynamicConnections();
            var entryCount = br.ReadVLQInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new DSDynamicConnections.Entry();

                entry.Unknown1 = br.ReadUInt64();

                data.Entries.Add(entry);
            }

            foreach (var entry in data.Entries)
            {
                entry.Unknown2 = br.ReadLengthPrefixedString();

                var subCount = br.ReadVLQInt32();
                for (int i = 0; i < subCount; i++)
                {
                    entry.Unknown3.Add(br.ReadUInt64());
                }

                subCount = br.ReadVLQInt32();
                for (int i = 0; i < subCount; i++)
                {
                    entry.Unknown4.Add(br.ReadUInt64());
                }

                entry.Unknown5 = br.ReadBytes(12);
                entry.Unknown6 = br.ReadLengthPrefixedString();
            }
            node.Data = data;
        }
    }

}
