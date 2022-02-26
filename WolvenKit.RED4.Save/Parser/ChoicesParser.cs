using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save
{
    public class Choices : IParseableBuffer
    {
        public List<Entry1> Unknown1 { get; set; }

        public Choices()
        {
            Unknown1 = new List<Entry1>();
        }

        public class Entry1
        {
            public ulong Unknown1 { get; set; }
            public List<Entry2> Unknown2 { get; set; }

            public Entry1()
            {
                Unknown2 = new List<Entry2>();
            }
        }

        public class Entry2
        {
            public uint Unknown1 { get; set; }
            public uint Unknown2 { get; set; }
            public uint Unknown3 { get; set; }
        }
    }


    public class ChoicesParser : INodeParser
    {
        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new Choices();

            var entryCount = br.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new Choices.Entry1();

                entry.Unknown1 = br.ReadUInt64();

                var subEntryCount = br.ReadUInt32();
                for (int j = 0; j < subEntryCount; j++)
                {
                    var subEntry = new Choices.Entry2();

                    subEntry.Unknown1 = br.ReadUInt32();
                    subEntry.Unknown2 = br.ReadUInt32();
                    subEntry.Unknown3 = br.ReadUInt32();

                    entry.Unknown2.Add(subEntry);
                }

                data.Unknown1.Add(entry);
            }
            node.Data = data;

        }
    }

}
