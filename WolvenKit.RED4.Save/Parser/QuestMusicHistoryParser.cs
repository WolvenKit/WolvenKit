using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class QuestMusicHistory : INodeData
    {
        public List<Entry> Entries { get; set; }

        public QuestMusicHistory()
        {
            Entries = new List<Entry>();
        }

        public class Entry
        {
            public TweakDBID Unknown1 { get; set; }
            public ulong Unknown2 { get; set; }
            public ulong Unknown3 { get; set; }
            public ushort Unknown4 { get; set; }
            public ushort Unknown5 { get; set; }
            public uint Unknown6 { get; set; }
        }
    }


    public class QuestMusicHistoryParser : INodeParser
    {
        // public static string NodeName => Constants.NodeNames.QUEST_MUSIC_HISTORY;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            throw new NotImplementedException();
            //using var ms = new MemoryStream(node.DataBytes);
            //using var br = new BinaryReader(ms);
            //var data = new QuestMusicHistory();
            //var count = br.ReadUInt32();
            //for (int i = 0; i < count; i++)
            //{
            //    var entry = new QuestMusicHistory.Entry();

            //    entry.Unknown1 = br.ReadTweakDbId();
            //    entry.Unknown2 = br.ReadUInt64();
            //    entry.Unknown3 = br.ReadUInt64();
            //    entry.Unknown4 = br.ReadUInt16();
            //    entry.Unknown5 = br.ReadUInt16();
            //    entry.Unknown6 = br.ReadUInt32();

            //    data.Entries.Add(entry);
            //}
            //node.Data = data;
        }

        public void Write(NodeWriter writer, NodeEntry node) => throw new NotImplementedException();
    }

}
