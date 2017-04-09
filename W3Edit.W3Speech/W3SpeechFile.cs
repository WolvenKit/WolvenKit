using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using W3Edit.W3Strings;

namespace W3Edit.W3Speech
{
    public class W3SoundInfo
    {
        public uint id;
        public uint id_high;
        public uint wave_offs;
        public uint wave_size;
        public uint cr2w_offs;
        public uint cr2w_size;
        public byte[] Wave_File;
        public byte[] CR2W_File;
    }
    public class W3Speech
    {
        public static readonly byte[] IDString = {(byte) 'C', (byte) 'P', (byte) 'S', (byte) 'W'};
        public static readonly byte[] Version1 = {0xA2, 0x00, 0x00, 0x00};
        public static readonly byte[] Version2 = {0xA1, 0x00, 0x00, 0x00};

        public static W3LanguageKey Key;
        public static List<W3SoundInfo> Files;

        public void Read(BinaryReader br,XDocument soundbanksinfo)
        {
            var magic = br.ReadBytes(4);
            if (!magic.SequenceEqual(IDString))
                throw new Exception("Not a valid w3speech file!");
            br.ReadUInt32(); //Version
            var key1 = br.ReadUInt16();
            Files = new List<W3SoundInfo>();
            var count = br.ReadBit6();
            for (var i = 0; i < count; i++)
            {
                var sound = new W3SoundInfo();
                sound.id = br.ReadUInt32();
                sound.id_high = br.ReadUInt32();
                sound.wave_offs = br.ReadUInt32();
                br.ReadUInt32();
                sound.wave_size = br.ReadUInt32();
                br.ReadUInt32();
                sound.cr2w_offs = br.ReadUInt32();
                br.ReadUInt32();
                sound.cr2w_size = br.ReadUInt32();
                br.ReadUInt32();
                Files.Add(sound);
            }
            var key2 = br.ReadUInt16();
            var magicKey = (key1 << 16 | key2);
            var languageKey = W3LanguageKey.Get((uint)magicKey);
            foreach (var w3SoundInfo in Files)
            {
                w3SoundInfo.id ^= languageKey.Key;
            }
            Files = Files.OrderBy(x => x.id).ToList();
            foreach (var t in Files)
            {
                if (t.wave_size > 0)
                {
                    br.BaseStream.Seek(t.wave_offs, SeekOrigin.Begin);                  
                    t.Wave_File = br.ReadBytes((int)t.wave_size);
                }
                if (t.cr2w_size > 0)
                {
                    br.BaseStream.Seek(t.cr2w_offs, SeekOrigin.Begin);
                    t.CR2W_File = br.ReadBytes((int)t.cr2w_size);
                }
            }
        }
        

        public void Write(BinaryWriter bw)
        {
            //TODO: Save the edited files!
        }
    }
}