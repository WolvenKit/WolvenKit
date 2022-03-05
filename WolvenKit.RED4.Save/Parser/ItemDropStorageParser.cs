using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class ItemDropStorage : IParseableBuffer
    {
        public string Unk1 { get; set; }
        public byte[] Unk2 { get; set; }
        public bool Unk3 { get; set; } // Unique?

        // Vector4?
        public float Unk4 { get; set; }
        public float Unk5 { get; set; }
        public float Unk6 { get; set; }
        public float Unk7 { get; set; }

        public uint Unk8 { get; set; } // Quantity?
        public TweakDBID Unk9 { get; set; }
        public byte[] Unk10 { get; set; }
    }


    public class ItemDropStorageParser : INodeParser
    {
        //public static string NodeName => Constants.NodeNames.ITEM_DROP_STORAGE;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new ItemDropStorage();

            data.Unk1 = reader.ReadLengthPrefixedString();
            data.Unk2 = reader.ReadBytes(16);
            data.Unk3 = reader.ReadBoolean();
            data.Unk4 = reader.ReadSingle();
            data.Unk5 = reader.ReadSingle();
            data.Unk6 = reader.ReadSingle();
            data.Unk7 = reader.ReadSingle();
            data.Unk8 = reader.ReadUInt32();
            data.Unk9 = reader.ReadTweakDbId();
            data.Unk10 = reader.ReadBytes(7);

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node) => throw new NotImplementedException();
    }

}
