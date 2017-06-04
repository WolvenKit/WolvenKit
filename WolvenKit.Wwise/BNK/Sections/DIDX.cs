using System;
using System.Collections.Generic;
using System.IO;

namespace WolvenKit.Wwise.BNK.Sections
{
    internal class DIDX_object
    {
        public uint data_length;
        public uint data_offset;
        public uint id;

        public DIDX_object(BinaryReader instream)
        {
            id = instream.ReadUInt32();
            data_offset = instream.ReadUInt32();
            data_length = instream.ReadUInt32();
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(id);
            outstream.Write(data_offset);
            outstream.Write(data_length);
        }
    }

    internal class DIDX
    {
        private readonly uint DIDX_tag = 0x58444944;
        public uint length;
        public List<DIDX_object> objects = new List<DIDX_object>();
        public long offset;
        public byte[] remaining_data;

        public DIDX(BinaryReader instream)
        {
            length = instream.ReadUInt32();
            offset = instream.BaseStream.Position;

            while (instream.BaseStream.Position - offset < length)
                objects.Add(new DIDX_object(instream));

            if (instream.BaseStream.Position - offset < length)
                remaining_data = instream.ReadBytes((int) (length - (uint) (instream.BaseStream.Position - offset)));
            else if (instream.BaseStream.Position - offset > length)
                Console.WriteLine("DIDX - YOU READ TOO MUCH!!!");
        }

        public void UpdateObjects(DATA data_section)
        {
            if (data_section.files.Count == 0)
                return;

            foreach (var obj in objects)
            {
                if (data_section.files.ContainsKey(obj.id))
                {
                }
            }
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(DIDX_tag);
            var newsizestart = outstream.BaseStream.Position;
            outstream.Write(length);
            foreach (var didx_obj in objects)
                didx_obj.StreamWrite(outstream);

            if (remaining_data != null)
                outstream.Write(remaining_data);

            //update section size
            var newsizeend = outstream.BaseStream.Position;
            outstream.BaseStream.Position = newsizestart;
            outstream.Write((uint) (newsizeend - (newsizestart + 4)));

            outstream.BaseStream.Position = newsizeend;
        }

        public override string ToString()
        {
            var ret_string = "[DIDX] offset: " + offset + " length: " + length + " objects count: " + objects.Count +
                             (remaining_data != null ? " REMAINING DATA! " + remaining_data.Length + " bytes" : "");

            if (objects.Count > 0)
            {
                foreach (var didx_obj in objects)
                {
                    ret_string += "\r\n\t DIDX Object [ " +
                                  "id: " + didx_obj.id + " " +
                                  "data_offset: " + didx_obj.data_offset + " " +
                                  "data_length: " + didx_obj.data_length + " " +
                                  "]";
                }
            }

            return ret_string;
        }
    }
}