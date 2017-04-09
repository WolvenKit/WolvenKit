using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WolvenKit.W3Strings
{
    public class W3StringFile
    {
        private static readonly byte[] IDString = {(byte) 'R', (byte) 'T', (byte) 'S', (byte) 'W'};
        private int block1count;
        private int block2count;
        private int block3count;
        private ushort key1;
        private ushort key2;
        private W3LanguageKey magic;
        private uint version;
        public List<W3StringBlock1> block1 { get; set; }
        public List<W3StringBlock2> block2 { get; set; }
        public List<W3StringBlock1> block1Unsorted { get; set; }
        public bool Incomplete { get; set; }

        public void Read(BinaryReader stream)
        {
            var filetype = stream.ReadBytes(4);

            if (!IDString.SequenceEqual(filetype))
            {
                throw new Exception("Invalid file format");
            }

            version = stream.ReadUInt32();


            //629299
            key1 = stream.ReadUInt16();
            stream.BaseStream.Seek(-2, SeekOrigin.End);
            key2 = stream.ReadUInt16();
            var magickey = (uint) (key1 << 16 | key2);
            magic = W3LanguageKey.Get(magickey);

            stream.BaseStream.Seek(10, SeekOrigin.Begin);

            // Read block 1
            block1count = stream.ReadBit6();
            block1 = new List<W3StringBlock1>();
            for (var i = 0; i < block1count; i++)
            {
                var newblock = new W3StringBlock1(stream, magic.Key);
                block1.Add(newblock);
            }

            // Read block 2
            block2count = stream.ReadBit6();
            block2 = new List<W3StringBlock2>();
            for (var i = 0; i < block2count; i++)
            {
                var block = new W3StringBlock2(stream, magic.Key);
                block2.Add(block);
            }


            // Read block 3
            block3count = stream.ReadBit6();

            var str_start = stream.BaseStream.Position;

            block1Unsorted = new List<W3StringBlock1>();
            block1Unsorted.AddRange(block1);

            block1.Sort(delegate(W3StringBlock1 b1, W3StringBlock1 b2) { return b1.str_id.CompareTo(b2.str_id); });

            // Read strings
            foreach (var block in block1)
            {
                var offset = block.offset*2 + str_start;

                stream.BaseStream.Seek(offset, SeekOrigin.Begin);

                var string_key = (ushort) (magic.Key >> 8 & 0xffff);

                for (var i = 0; i < block.strlen; i++)
                {
                    var b1 = stream.ReadByte();
                    var b2 = stream.ReadByte();

                    var char_key = (ushort) (((block.strlen + 1)*string_key) & 0xffff);

                    b1 = (byte) (b1 ^ (byte) ((char_key >> 0) & 0xff));
                    b2 = (byte) (b2 ^ (byte) ((char_key >> 8) & 0xff));

                    string_key = (ushort) (((string_key << 1) | (string_key >> 15)) & 0xffff);

                    block.str += (char) (b1 + (b2 << 8));
                }
            }
            var strbuffsize = (stream.BaseStream.Length - 2) - str_start;
            stream.BaseStream.Seek((int) (block3count*2 + str_start), SeekOrigin.Begin);
            var left = stream.BaseStream.Length - stream.BaseStream.Position - 2;
            if (left > 0)
            {
                Incomplete = true;
            }
        }

        public void Write(BinaryWriter stream)
        {
            stream.Write(IDString);
            stream.Write(version);
            stream.Write(key1);


            var stringbuffer = new MemoryStream();
            var strbufw = new BinaryWriter(stringbuffer);

            // Write string buffer
            {
                foreach (var block in block1)
                {
                    block.Modified = false;
                    var string_key = (ushort) (magic.Key >> 8 & 0xffff);

                    block.offset = (uint) strbufw.BaseStream.Position/2;
                    block.strlen = (uint) block.str.Length;

                    for (var i = 0; i < block.strlen; i++)
                    {
                        var b1 = block.str[i] & 255;
                        var b2 = block.str[i] >> 8;

                        var char_key = (ushort) (((block.strlen + 1)*string_key) & 0xffff);

                        b1 = (byte) (b1 ^ (byte) ((char_key >> 0) & 0xff));
                        b2 = (byte) (b2 ^ (byte) ((char_key >> 8) & 0xff));

                        string_key = (ushort) (((string_key << 1) | (string_key >> 15)) & 0xffff);

                        strbufw.Write((byte) b1);
                        strbufw.Write((byte) b2);
                    }

                    strbufw.Write((byte) 0);
                    strbufw.Write((byte) 0);
                }
            }

            stream.WriteBit6(block1.Count);
            foreach (var block in block1Unsorted)
            {
                block.Write(stream, magic.Key);
            }

            stream.WriteBit6(block2.Count);
            foreach (var block in block2)
            {
                block.Write(stream, magic.Key);
            }

            //block3count
            var strbufferlen = strbufw.BaseStream.Length/2;

            stream.WriteBit6((int) strbufferlen);

            stringbuffer.Seek(0, SeekOrigin.Begin);
            stringbuffer.WriteTo(stream.BaseStream);

            stream.Write(key2);
        }
    }
}