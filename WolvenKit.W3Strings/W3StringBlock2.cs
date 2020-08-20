using System.IO;
using System.Collections.Generic;

namespace WolvenKit.W3Strings
{
    public class W3StringBlock2
    {
        public uint str_id;
        public uint str_key_hex;

        public W3StringBlock2()
        {
        }

        public W3StringBlock2(uint id, string str_key, string s)
        {
            Create(id, str_key, s);
        }

        public W3StringBlock2(BinaryReader stream, uint magic)
        {
            Read(stream, magic);
        }

        public void Create(uint id, string str_key, string s)
        {
            str_id = id;
            str_key_hex = HashKey(str_key);
        }

        public void Read(BinaryReader stream, uint magic)
        {
            str_key_hex = stream.ReadUInt32();

            var str_id_n = stream.ReadUInt32();
            //1106107 = 2032334632 ^ 2033325971
            str_id = (str_id_n ^ magic);
        }

        public void Write(BinaryWriter stream, uint magic)
        {
            stream.Write(str_key_hex);
            //2032334632 = 1106107 ^ 2033325971
            var str_id_n = str_id ^ magic;
            stream.Write(str_id_n);
        }

        private uint HashKey(string key)
        {
            char[] keyConverted = key.ToCharArray();
            uint hash = 0;
            foreach (char c in keyConverted)
            {
                hash *= 31;
                hash += (uint)c;
            }
            return hash;
        }
    }
}