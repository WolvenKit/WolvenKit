using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class JournalManager : IParseableBuffer
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
            public uint Unk1_PathHash { get; set; }
            public uint Unk2_State { get; set; }
            public uint Unknown3 { get; set; }
            public uint Unknown4 { get; set; }
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
        // public static string NodeName => Constants.NodeNames.JOURNAL_MANAGER;

        public void Read(SaveNode node)
        {
            throw new NotImplementedException();
            //using var ms = new MemoryStream(node.DataBytes);
            //using var br = new BinaryReader(ms);
            //var data = new JournalManager();
            //var entryCount = br.ReadUInt32();
            //for (int i = 0; i < entryCount; i++)
            //{
            //    var entry = new JournalManager.Entry1();
            //    entry.Unk1_PathHash = br.ReadUInt32();
            //    entry.Unk2_State = br.ReadUInt32();
            //    entry.Unknown3 = br.ReadUInt32();
            //    entry.Unknown4 = br.ReadUInt32();

            //    data.Entries.Add(entry);
            //}

            //data.Unk1_TrackedQuestPath = br.ReadUInt32();

            //entryCount = br.ReadUInt32();
            //for (int i = 0; i < entryCount; i++)
            //{
            //    // could be wrong, strings with length 2?
            //    data.Unknown2.Add(br.ReadUInt64());
            //}

            //entryCount = br.ReadUInt32();
            //for (int i = 0; i < entryCount; i++)
            //{
            //    var entry = new JournalManager.Entry2();
            //    entry.Unknown1 = br.ReadUInt32();
            //    entry.Unknown2 = br.ReadUInt32();
            //    entry.Unknown3 = br.ReadUInt32();
            //    entry.Unknown4 = br.ReadUInt32();

            //    data.Unknown3.Add(entry);
            //}
            //data.TrailingBytes = br.ReadBytes((int)(br.BaseStream.Length - br.BaseStream.Position));
            //node.Data = data;
        }

        public SaveNode Write() => throw new NotImplementedException();
    }

}
