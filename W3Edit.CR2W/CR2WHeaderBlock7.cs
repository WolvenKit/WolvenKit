using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.CR2W
{
    public class CR2WHeaderBlock7
    {
        public UInt32 handle_name_count;
        public UInt32 handle_name_offset;
        public UInt32 unk3 { get; set; }
        public UInt32 unk4 { get; set; }
        public UInt32 offset;
        public UInt32 size { get; set; }

        public byte[] unknowndata;

        public List<string> handles = new List<string>();

        public string Handles { get { return string.Join(", ", handles);  } }

        public CR2WHeaderBlock7()
        {
        }

        public CR2WHeaderBlock7(BinaryReader file)
        {
            Read(file);
        }


        public void ReadString(BinaryReader file, UInt32 string_buffer_start)
        {
            file.BaseStream.Seek(handle_name_offset + string_buffer_start, SeekOrigin.Begin);
            for (int i = 0; i < handle_name_count; i++)
            {
                handles.Add(file.ReadCR2WString());
            }
        }

        public void ReadData(BinaryReader file)
        {
            file.BaseStream.Seek(offset, SeekOrigin.Begin);
            unknowndata = file.ReadBytes((int)size);
        }

        public void WriteData(BinaryWriter file)
        {
            offset = (UInt32)file.BaseStream.Position;
            if (unknowndata != null)
            {
                file.Write(unknowndata);
            }
            size = (UInt32)unknowndata.Length;
        }

        public void Read(BinaryReader file)
        {
            handle_name_count = file.ReadUInt32();
            handle_name_offset = file.ReadUInt32();
            unk3 = file.ReadUInt32();
            unk4 = file.ReadUInt32();

            offset = file.ReadUInt32();
            size = file.ReadUInt32();
        }

        public void Write(BinaryWriter file)
        {
            file.Write(handle_name_count);
            file.Write(handle_name_offset);
            file.Write(unk3);
            file.Write(unk4);
            file.Write(offset);
            file.Write(size);
        }
    }
}
