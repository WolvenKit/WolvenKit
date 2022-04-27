using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save
{
    public class CCoverManager : INodeData
    {
        public List<CCoverManagerEntry> Entries { get; set; }

        public CCoverManager()
        {
            Entries = new List<CCoverManagerEntry>();
        }
    }
    public class CCoverManagerEntry
    {
        public ulong Unk_Hash1 { get; set; }
        public ulong Unk_EntityHash { get; set; }

        // probably bool, if this is true, the hashes are also used somewhere els in the save
        public byte Unknown3 { get; set; }
    }


    public class CCoverManagerParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.C_COVER_MANAGER;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new CCoverManager();
            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new CCoverManagerEntry();
                entry.Unk_Hash1 = reader.ReadUInt64();
                entry.Unk_EntityHash = reader.ReadUInt64();
                entry.Unknown3 = reader.ReadByte();
                data.Entries.Add(entry);
            }

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (CCoverManager)node.Value;

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
