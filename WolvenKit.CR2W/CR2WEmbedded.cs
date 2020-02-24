using System.Collections.Generic;
using System.IO;

namespace WolvenKit.CR2W
{
    public class CR2WEmbedded
    {
        public uint handle_name_count;
        public uint handle_name_offset;
        public List<string> handles = new List<string>();
        public uint offset;
        public byte[] unknowndata;

        public CR2WEmbedded()
        {
        }

        public CR2WEmbedded(BinaryReader file)
        {
            Read(file);
        }

        public ulong pathHash { get; set; }
        public uint size { get; set; }

        public string Handles => string.Join(", ", handles);

        public void ReadString(BinaryReader file, uint string_buffer_start)
        {
            file.BaseStream.Seek(handle_name_offset + string_buffer_start, SeekOrigin.Begin);
            for (var i = 0; i < handle_name_count; i++)
            {
                handles.Add(file.ReadCR2WString());
            }
        }

        public void ReadData(BinaryReader file)
        {
            file.BaseStream.Seek(offset, SeekOrigin.Begin);
            unknowndata = file.ReadBytes((int) size);
        }

        public void WriteData(BinaryWriter file)
        {
            offset = (uint) file.BaseStream.Position;
            if (unknowndata != null)
            {
                file.Write(unknowndata);
            }
            size = (uint) unknowndata.Length;
        }

        public void Read(BinaryReader file)
        {
            handle_name_count = file.ReadUInt32();
            handle_name_offset = file.ReadUInt32();
            pathHash = file.ReadUInt64();

            offset = file.ReadUInt32();
            size = file.ReadUInt32();
        }

        public void Write(BinaryWriter file)
        {
            file.Write(handle_name_count);
            file.Write(handle_name_offset);
            file.Write(pathHash);
            file.Write(offset);
            file.Write(size);
        }

        public CR2WEmbeddedHeader ToCR2WEmbedded()
        {
            return new CR2WEmbeddedHeader
            {
                importIndex = handle_name_count,
                path = handle_name_offset,
                pathHash = pathHash,
                dataOffset = offset,
                dataSize = size
            };
        }
    }
}