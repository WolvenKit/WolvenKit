using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save
{
    public class CCoverManager : IParseableBuffer
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

        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new CCoverManager();
            var entryCount = br.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new CCoverManagerEntry();
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
