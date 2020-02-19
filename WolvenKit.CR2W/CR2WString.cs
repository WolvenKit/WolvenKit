using RED.FNV1A;
using System.IO;

namespace WolvenKit.CR2W
{
    public class CR2WString
    {
        public uint hash;
        public uint offset;
        public string str;

        public CR2WString()
        {
        }

        public CR2WString(BinaryReader file)
        {
            Read(file);
        }

        public void Read(BinaryReader file)
        {
            offset = file.ReadUInt32();
            hash = file.ReadUInt32();
        }

        public void ReadString(BinaryReader file, long baseoffset)
        {
            var pos = file.BaseStream.Position;

            file.BaseStream.Seek(offset + baseoffset, SeekOrigin.Begin);
            str = file.ReadCR2WString();
            file.BaseStream.Seek(pos, SeekOrigin.Begin);
        }

        public void Write(BinaryWriter file)
        {
            file.Write(offset);
            file.Write(FNV1A32HashAlgorithm.HashString(str));
        }

        public CR2WName ToCR2WName()
        {
            return new CR2WName
            {
                hash = FNV1A32HashAlgorithm.HashString(str),
                value = offset
            };
        }
    }
}