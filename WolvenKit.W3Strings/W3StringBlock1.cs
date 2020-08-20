using System.IO;
using System.Collections.Generic;
using System;
using ProtoBuf;

namespace WolvenKit.W3Strings
{
    [ProtoContract]
    public class W3StringBlock1
    {
        [ProtoMember(1)]
        public uint offset;
        [ProtoMember(2)]
        public string str;
        [ProtoMember(3)]
        public uint str_id;
        [ProtoMember(4)]
        public uint str_id_hashed;
        [ProtoMember(5)]
        public uint strlen;

        public W3StringBlock1()
        {
        }

        public W3StringBlock1(uint id, string s, uint magic)
        {
            Create(id, s, magic);
        }

        public W3StringBlock1(BinaryReader stream, uint magic)
        {
            Read(stream, magic);
        }

        public bool Modified { get; set; }

        public void Create(uint id, string s, uint magic)
        {
            str_id = id;
            str_id_hashed = str_id ^ magic;
            str = s;
            offset = 0; //test
            strlen = (uint)s.Length;
        }

        public void Read(BinaryReader stream, uint magic)
        {
            str_id_hashed = stream.ReadUInt32();
            str_id = (str_id_hashed ^ magic); 
            offset = stream.ReadUInt32(); 
            strlen = stream.ReadUInt32();
        }

        public void Write(BinaryWriter stream, uint magic)
        {
            var str_id_n = str_id ^ magic;

            stream.Write(str_id_n);
            stream.Write(offset);
            stream.Write(strlen);
        }
    }
}