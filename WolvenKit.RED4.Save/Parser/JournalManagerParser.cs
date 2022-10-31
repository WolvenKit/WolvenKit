using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class JournalManager : INodeData
    {
        public List<Entry1> Entries { get; set; }
        public uint Unk1_TrackedQuestPath { get; set; }
        // could be wrong, strings with length 2?
        public List<ulong> Unknown2 { get; set; }
        public List<Entry2> Unknown3 { get; set; }
        public byte[] TrailingBytes { get; set; }

        public JournalManager()
        {
            Entries = new List<Entry1>();
            Unknown2 = new List<ulong>();
            Unknown3 = new List<Entry2>();
        }

        public class Entry1
        {
            public byte[] UnkownBytes { get; set; }
        }

        public class Entry2
        {
            public uint Unknown1 { get; set; }
            public uint Unknown2 { get; set; }
            public uint Unknown3 { get; set; }
            public uint Unknown4 { get; set; }
        }
    }


    public class JournalManagerParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.JOURNAL_MANAGER;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var result = new JournalManager();
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                result.Entries.Add(new JournalManager.Entry1
                {
                    UnkownBytes = reader.ReadBytes(15)
                });
            }

            result.Unk1_TrackedQuestPath = reader.ReadUInt32();

            entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                // could be wrong, strings with length 2?
                result.Unknown2.Add(reader.ReadUInt64());
            }

            entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new JournalManager.Entry2();
                entry.Unknown1 = reader.ReadUInt32();
                entry.Unknown2 = reader.ReadUInt32();
                entry.Unknown3 = reader.ReadUInt32();
                entry.Unknown4 = reader.ReadUInt32();

                result.Unknown3.Add(entry);
            }

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);
            result.TrailingBytes = reader.ReadBytes(readSize);

            node.Value = result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (JournalManager)node.Value;

            writer.Write(data.Entries.Count);
            foreach (var entry in data.Entries)
            {
                writer.Write(entry.UnkownBytes);
            }
            writer.Write(data.Unk1_TrackedQuestPath);

            writer.Write(data.Unknown2.Count);
            foreach (var entry in data.Unknown2)
            {
                writer.Write(entry);
            }

            writer.Write(data.Unknown3.Count);
            foreach (var entry in data.Unknown3)
            {
                writer.Write(entry.Unknown1);
                writer.Write(entry.Unknown2);
                writer.Write(entry.Unknown3);
                writer.Write(entry.Unknown4);
            }

            writer.Write(data.TrailingBytes);
        }
    }

}
