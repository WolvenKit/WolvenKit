using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class EventManager : INodeData
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
        public static string NodeName => Constants.NodeNames.EVENT_MANAGER;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new EventManager();
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new EventManager.Entry();
                entry.Unknown1 = reader.ReadUInt64();
                entry.Unknown2 = reader.ReadUInt32();
                entry.Unknown3 = reader.ReadUInt16();
                entry.Unknown4 = reader.ReadUInt16();
                data.Unknown.Add(entry);
            }

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (EventManager)node.Value;

            writer.Write(data.Unknown.Count);
            foreach (var entry in data.Unknown)
            {
                writer.Write(entry.Unknown1);
                writer.Write(entry.Unknown2);
                writer.Write(entry.Unknown3);
                writer.Write(entry.Unknown4);
            }
        }
    }

}
