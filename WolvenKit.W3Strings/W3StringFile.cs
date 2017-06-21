using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WolvenKit.W3Strings
{
    public class W3StringFile
    {
        private static readonly byte[] IDString = { (byte)'R', (byte)'T', (byte)'S', (byte)'W' };
        private int block1count;
        private int block2count;
        private int block3count;
        private ushort key1;
        private ushort key2;
        private W3Language language;
        private uint version;
        public List<W3StringBlock1> block1 { get; set; }
        public List<W3StringBlock2> block2 { get; set; }
        public List<W3StringBlock1> block1Unsorted { get; set; }
        public bool Incomplete { get; set; }

        public void Create(List<List<string>> strings, string lang)
        {
            language = W3Language.languages.First(l => l.Handle == lang);

            var keys = new List<Tuple<string, UInt16, ushort>>();
            switch (language.Handle)
            {
                case "ar":
                case "br":
                case "esMX":
                case "kr":
                case "tr":
                    key1 = 0;
                    key2 = 0;
                    break;
                case "pl":
                    key1 = 0x8349;
                    key2 = 0x6237;
                    break;
                case "en":
                    key1 = 0x4397;
                    key2 = 0x5139;
                    break;
                case "de":
                    key1 = 0x7588;
                    key2 = 0x6138;
                    break;
                case "it":
                    key1 = 0x4593;
                    key2 = 0x1894;
                    break;
                case "fr":
                    key1 = 0x2386;
                    key2 = 0x3176;
                    break;
                case "cz":
                    key1 = 0x2498;
                    key2 = 0x7354;
                    break;
                case "es":
                    key1 = 0x1879;
                    key2 = 0x6651;
                    break;
                case "zh":
                    key1 = 0x1863;
                    key2 = 0x2176;
                    break;
                case "ru":
                    key1 = 0x6348;
                    key2 = 0x1486;
                    break;
                case "hu":
                    key1 = 0x4237;
                    key2 = 0x8932;
                    break;
                case "jp":
                    key1 = 0x5483;
                    key2 = 0x4893;
                    break;
            }

            version = 162;

            // Create block1
            block1count = strings.Count;

            block1 = new List<W3StringBlock1>();
            for (var i = 0; i < block1count; i++)
            {
                var newblock = new W3StringBlock1(Convert.ToUInt32(strings[i][0]), strings[i][2], language.Magic.value);
                block1.Add(newblock);
            }

            block1Unsorted = new List<W3StringBlock1>();
            block1Unsorted.AddRange(block1);

            block1.Sort(delegate (W3StringBlock1 b1, W3StringBlock1 b2) { return b1.str_id_hashed.CompareTo(b2.str_id_hashed); });

            // Create block2
            block2count = block1count;
            block2 = new List<W3StringBlock2>();
            for (var i = 0; i < block2count; i++)
            {
                var block = new W3StringBlock2(Convert.ToUInt32(strings[i][0]), strings[i][1], strings[i][2]);
                block2.Add(block);
            }

            block2.Sort(delegate (W3StringBlock2 b1, W3StringBlock2 b2) { return b1.str_key_hex.CompareTo(b2.str_key_hex); });
        }

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
            var key = (uint)(key1 << 16 | key2);
            language = W3Language.languages.First(lang => lang.Key.value == key);

            stream.BaseStream.Seek(10, SeekOrigin.Begin);

            // Read block 1
            // str_id and actual string
            block1count = stream.ReadBit6().value;
            block1 = new List<W3StringBlock1>();
            for (var i = 0; i < block1count; i++)
            {
                var newblock = new W3StringBlock1(stream, language.Magic.value);
                block1.Add(newblock);
            }

            // Read block 2
            // str_id and hashed key, key is only used for some variables because two identical keys may cause problems, so in vanilla files this block is much smaller than the number of strings
            block2count = stream.ReadBit6().value;
            block2 = new List<W3StringBlock2>();
            for (var i = 0; i < block2count; i++)
            {
                var block = new W3StringBlock2(stream, language.Magic.value);
                block2.Add(block);
            }


            // Read block 3
            // which seems to be just actual strings combined length
            block3count = stream.ReadBit6().value;

            var str_start = stream.BaseStream.Position;

            block1Unsorted = new List<W3StringBlock1>();
            block1Unsorted.AddRange(block1);

            

            // Read strings
            foreach (var block in block1)
            {
                var offset = block.offset * 2 + str_start;

                stream.BaseStream.Seek(offset, SeekOrigin.Begin);

                var string_key = (ushort)(language.Magic.value >> 8 & 0xffff);

                for (var i = 0; i < block.strlen; i++)
                {
                    var b1 = stream.ReadByte();
                    var b2 = stream.ReadByte();

                    var char_key = (ushort)(((block.strlen + 1) * string_key) & 0xffff);

                    b1 = (byte)(b1 ^ (byte)((char_key >> 0) & 0xff));
                    b2 = (byte)(b2 ^ (byte)((char_key >> 8) & 0xff));

                    string_key = (ushort)(((string_key << 1) | (string_key >> 15)) & 0xffff);

                    block.str += (char)(b1 + (b2 << 8));
                }
            }
            var strbuffsize = (stream.BaseStream.Length - 2) - str_start;
            stream.BaseStream.Seek((int)(block3count * 2 + str_start), SeekOrigin.Begin);
            var left = stream.BaseStream.Length - stream.BaseStream.Position - 2;
            if (left > 0)
            {
                Incomplete = true;
            }

            block1.Sort(delegate (W3StringBlock1 b1, W3StringBlock1 b2) { return b1.str_id_hashed.CompareTo(b2.str_id_hashed); });
            block2.Sort(delegate (W3StringBlock2 b1, W3StringBlock2 b2) { return b1.str_key_hex.CompareTo(b2.str_key_hex); });
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
                    var string_key = (ushort)(language.Magic.value >> 8 & 0xffff);

                    block.offset = (uint)strbufw.BaseStream.Position / 2;
                    if (block.str != null)
                        block.strlen = (uint)block.str.Length;
                    else
                        block.strlen = 0;

                    for (var i = 0; i < block.strlen; i++)
                    {
                        var b1 = block.str[i] & 255;
                        var b2 = block.str[i] >> 8;

                        var char_key = (ushort)(((block.strlen + 1) * string_key) & 0xffff);

                        b1 = (byte)(b1 ^ (byte)((char_key >> 0) & 0xff));
                        b2 = (byte)(b2 ^ (byte)((char_key >> 8) & 0xff));

                        string_key = (ushort)(((string_key << 1) | (string_key >> 15)) & 0xffff);

                        strbufw.Write((byte)b1);
                        strbufw.Write((byte)b2);
                    }

                    strbufw.Write((byte)0);
                    strbufw.Write((byte)0);
                }
            }

            stream.WriteBit6(block1.Count);
            foreach (var block in block1)
            {
                block.Write(stream, language.Magic.value);
            }

            stream.WriteBit6(block2.Count);
            foreach (var block in block2)
            {
                block.Write(stream, language.Magic.value);
            }

            //block3count
            var strbufferlen = strbufw.BaseStream.Length / 2;

            stream.WriteBit6((int)strbufferlen);

            stringbuffer.Seek(0, SeekOrigin.Begin);
            stringbuffer.WriteTo(stream.BaseStream);

            stream.Write(key2);
        }
    }
}