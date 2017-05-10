using System.IO;

namespace SoundBankParser.Sections
{
    internal class Unknown
    {
        public byte[] data;
        public uint length;
        public long offset;
        public uint tag;

        public Unknown(BinaryReader instream)
        {
            instream.BaseStream.Position -= 4; //adjust position to read the tag
            tag = instream.ReadUInt32();
            length = instream.ReadUInt32();
            offset = instream.BaseStream.Position;

            data = instream.ReadBytes((int) length);
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(tag);
            var newsizestart = outstream.BaseStream.Position;
            outstream.Write(length);
            outstream.Write(data);

            //update section size
            var newsizeend = outstream.BaseStream.Position;
            outstream.BaseStream.Position = newsizestart;
            outstream.Write((uint) (newsizeend - (newsizestart + 4)));

            outstream.BaseStream.Position = newsizeend;
        }

        public override string ToString()
        {
            return "[Unknown] tag: " + tag + " offset: " + offset + " length: " + length + " data count: " +
                   (data != null ? " REMAINING DATA! " + data.Length + " bytes" : "");
        }
    }
}