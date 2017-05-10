using System;
using System.Collections.Generic;
using System.IO;

namespace SoundBankParser.Sections
{
    internal class SoundBank
    {
        public uint id;
        public string soundbank_name;

        public SoundBank(BinaryReader instream)
        {
            id = instream.ReadUInt32();
            soundbank_name = instream.ReadString();
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(id);
            outstream.Write(soundbank_name);
        }
    }

    internal class STID
    {
        private readonly uint STID_tag = 0x44495453;
        public uint length;
        public long offset;
        public byte[] remaining_data;
        public uint soundbank_count;
        public List<SoundBank> soundbanks = new List<SoundBank>();
        public uint unknownInt1;

        public STID(BinaryReader instream)
        {
            length = instream.ReadUInt32();
            offset = instream.BaseStream.Position;
            unknownInt1 = instream.ReadUInt32();
            soundbank_count = instream.ReadUInt32();

            for (var x = 0; x < soundbank_count; x++)
                soundbanks.Add(new SoundBank(instream));

            if (instream.BaseStream.Position - offset < length)
            {
                remaining_data = instream.ReadBytes((int) (length - (uint) (instream.BaseStream.Position - offset)));
            }
            else if (instream.BaseStream.Position - offset > length)
            {
                Console.WriteLine("STID - YOU READ TOO MUCH!!!");
            }
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(STID_tag);
            var newsizestart = outstream.BaseStream.Position;
            outstream.Write(length);
            outstream.Write(unknownInt1);
            outstream.Write(soundbank_count);
            foreach (var soundbank_obj in soundbanks)
                soundbank_obj.StreamWrite(outstream);

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
            var ret_string = "[STID] offset: " + offset + " length: " + length + " unknownInt1: " + unknownInt1 +
                             " soundbank_count: " + soundbank_count +
                             (remaining_data != null ? " REMAINING DATA! " + remaining_data.Length + " bytes" : "");

            if (soundbanks.Count > 0)
            {
                foreach (var soundbank_obj in soundbanks)
                {
                    ret_string += "\r\n\t SoundBank Object [ " +
                                  "id: " + soundbank_obj.id + " " +
                                  "name: " + soundbank_obj.soundbank_name + " " +
                                  "]";
                }
            }

            return ret_string;
        }
    }
}