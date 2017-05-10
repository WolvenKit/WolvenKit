using System;
using System.IO;

namespace SoundBankParser.Sections
{
    internal class BKHD
    {
        private readonly uint BKHD_tag = 0x44484B42;
        public uint length;
        public long offset;
        public byte[] remaining_data;
        public uint soundbank_id;
        public uint soundbank_version;
        public uint unknown1;
        public uint unknown2;

        public BKHD(BinaryReader instream)
        {
            length = instream.ReadUInt32();
            offset = instream.BaseStream.Position;
            soundbank_version = instream.ReadUInt32();
            soundbank_id = instream.ReadUInt32();
            unknown1 = instream.ReadUInt32();
            unknown2 = instream.ReadUInt32();

            if (instream.BaseStream.Position - offset < length)
                remaining_data = instream.ReadBytes((int) (length - (uint) (instream.BaseStream.Position - offset)));
            else if (instream.BaseStream.Position - offset > length)
                Console.WriteLine("BKHD - YOU READ TOO MUCH!!!");
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(BKHD_tag);
            var newsizestart = outstream.BaseStream.Position;
            outstream.Write(length);
            outstream.Write(soundbank_version);
            outstream.Write(soundbank_id);
            outstream.Write(unknown1);
            outstream.Write(unknown2);

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
            return "[BKHD] offset: " + offset + " length: " + length + " soundbank_version: " + soundbank_version +
                   " soundbank_id: " + soundbank_id + " unknown1: " + unknown1 + " unknown2: " + unknown2 +
                   (remaining_data != null ? " REMAINING DATA! " + remaining_data.Length + " bytes" : "");
        }
    }
}