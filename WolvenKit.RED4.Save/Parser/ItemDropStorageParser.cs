using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;

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
        public static string NodeName => Constants.NodeNames.ITEM_DROP_STORAGE;

        public void Read(SaveNode node)
        {
            using var ms = new MemoryStream(node.DataBytes);
            using var br = new BinaryReader(ms);
            var data = new ItemDropStorage();

            data.Unk1 = br.ReadLengthPrefixedString();
            data.Unk2 = br.ReadBytes(16);
            data.Unk3 = br.ReadBoolean();
            data.Unk4 = br.ReadSingle();
            data.Unk5 = br.ReadSingle();
            data.Unk6 = br.ReadSingle();
            data.Unk7 = br.ReadSingle();
            data.Unk8 = br.ReadUInt32();
            data.Unk9 = br.ReadTweakDbId();
            data.Unk10 = br.ReadBytes(7);

            node.Data = data;
        }

        public SaveNode Write() => throw new NotImplementedException();
    }

}
