using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save
{
    public class CAttitudeManager : IParseableBuffer
    {
        public List<CAttitudeManagerEntry> Entries { get; set; }
        public byte[] Unknown2 { get; set; }

        public CAttitudeManager()
        {
            Entries = new List<CAttitudeManagerEntry>();
        }
    }

    public class CAttitudeManagerEntry
    {
        public ulong Unk_Hash1 { get; set; }
        public uint Unknown2 { get; set; }
    }

    public class CAttitudeManagerParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.C_ATTITUDE_MANAGER;

        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var entryCount = br.ReadUInt32();
            var data = new CAttitudeManager();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new CAttitudeManagerEntry();
                entry.Unk_Hash1 = br.ReadUInt64();
                entry.Unknown2 = br.ReadUInt32();

                data.Entries.Add(entry);
            }
            data.Unknown2 = br.ReadBytes(18);

            node.Data = data;

        }

        public SaveNode Write() => throw new NotImplementedException();
    }

}
