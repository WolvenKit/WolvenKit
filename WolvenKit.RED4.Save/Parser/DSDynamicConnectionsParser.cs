using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

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
        public static string NodeName => Constants.NodeNames.DS_DYNAMIC_CONNECTIONS;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new DSDynamicConnections();
            var entryCount = reader.ReadVLQInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new DSDynamicConnections.Entry();

                entry.Unknown1 = reader.ReadUInt64();

                data.Entries.Add(entry);
            }

            foreach (var entry in data.Entries)
            {
                entry.Unknown2 = reader.ReadLengthPrefixedString();

                var subCount = reader.ReadVLQInt32();
                for (int i = 0; i < subCount; i++)
                {
                    entry.Unknown3.Add(reader.ReadUInt64());
                }

                subCount = reader.ReadVLQInt32();
                for (int i = 0; i < subCount; i++)
                {
                    entry.Unknown4.Add(reader.ReadUInt64());
                }

                entry.Unknown5 = reader.ReadBytes(12);
                entry.Unknown6 = reader.ReadLengthPrefixedString();
            }

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node) => throw new NotImplementedException();
    }

}
