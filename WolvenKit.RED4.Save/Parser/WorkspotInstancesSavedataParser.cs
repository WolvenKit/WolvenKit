using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Save
{
    public class WorkspotInstancesSavedata : IParseableBuffer
    {
        public List<WorkspotInstancesSavedataEntry> Entries { get; set; }

        public WorkspotInstancesSavedata()
        {
            Entries = new List<WorkspotInstancesSavedataEntry>();
        }

        public class WorkspotInstancesSavedataEntry
        {
            public ulong Unk_Hash1 { get; set; }
            public ulong Unk_EntityHash { get; set; }
            public byte Unknown3 { get; set; }
        }
    }


    public class WorkspotInstancesSavedataParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.WORKSPOT_INSTANCES_SAVEDATA;

        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new WorkspotInstancesSavedata();
            var entryCount = br.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new WorkspotInstancesSavedata.WorkspotInstancesSavedataEntry();
                entry.Unk_Hash1 = br.ReadUInt64();
                entry.Unk_EntityHash = br.ReadUInt64();
                entry.Unknown3 = br.ReadByte();

                data.Entries.Add(entry);
            }
            node.Data = data;
        }

        public SaveNode Write() => throw new NotImplementedException();
    }

}
