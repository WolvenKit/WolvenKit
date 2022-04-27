using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class WorkspotInstancesSavedata : INodeData
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

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new WorkspotInstancesSavedata();
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new WorkspotInstancesSavedata.WorkspotInstancesSavedataEntry();
                entry.Unk_Hash1 = reader.ReadUInt64();
                entry.Unk_EntityHash = reader.ReadUInt64();
                entry.Unknown3 = reader.ReadByte();

                data.Entries.Add(entry);
            }

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (WorkspotInstancesSavedata)node.Value;

            writer.Write(data.Entries.Count);
            foreach (var entry in data.Entries)
            {
                writer.Write(entry.Unk_Hash1);
                writer.Write(entry.Unk_EntityHash);
                writer.Write(entry.Unknown3);
            }
        }
    }

}
