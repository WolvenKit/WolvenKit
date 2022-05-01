using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save
{
    public class Choices : INodeData
    {
        public List<Entry1> Unknown1 { get; set; }

        public Choices()
        {
            Unknown1 = new List<Entry1>();
        }

        public class Entry1
        {
            public CResourceReference<scnSceneResource> Scene { get; set; }
            public List<Entry2> Unknown2 { get; set; }

            public Entry1()
            {
                Unknown2 = new List<Entry2>();
            }
        }

        public class Entry2
        {
            public uint ScnNodeId { get; set; }
            public uint Unknown2 { get; set; }
            public uint Unknown3 { get; set; }
        }
    }


    public class ChoicesParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.CHOICES;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new Choices();

            var entryCount = reader.ReadUInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var entry = new Choices.Entry1();

                entry.Scene = new CResourceReference<scnSceneResource> { DepotPath = reader.ReadUInt64() };

                var subEntryCount = reader.ReadUInt32();
                for (int j = 0; j < subEntryCount; j++)
                {
                    var subEntry = new Choices.Entry2();

                    subEntry.ScnNodeId = reader.ReadUInt32();
                    subEntry.Unknown2 = reader.ReadUInt32();
                    subEntry.Unknown3 = reader.ReadUInt32();

                    entry.Unknown2.Add(subEntry);
                }

                data.Unknown1.Add(entry);
            }

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (Choices)node.Value;

            writer.Write(data.Unknown1.Count);
            foreach (var entry in data.Unknown1)
            {
                writer.Write((ulong)entry.Scene.DepotPath);

                writer.Write(entry.Unknown2.Count);
                foreach (var subEntry in entry.Unknown2)
                {
                    writer.Write(subEntry.ScnNodeId);
                    writer.Write(subEntry.Unknown2);
                    writer.Write(subEntry.Unknown3);
                }
            }
        }
    }

}
