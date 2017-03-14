using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
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
        public W3LanguageKey Key;
        public List<W3SoundInfo> SoundInfoList;

        public void Read(BinaryReader br)
        {
            var magic = br.ReadBytes(4);
            if (!magic.SequenceEqual(IDString))
                throw new Exception("Not a valid w3speech file!");
            Console.WriteLine("Version: " + magic);
            var version = br.ReadUInt32();
            Console.WriteLine("Version: " + version);
            var key1 = br.ReadUInt16();
            Console.WriteLine("Key1: " + key1);
            SoundInfoList = new List<W3SoundInfo>();
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
                SoundInfoList.Add(sound);
            }
            Console.WriteLine("Position after fileinfo: " + br.BaseStream.Position);
            var key2 = br.ReadUInt16();
            Console.WriteLine("Key2: " + key2);
            var magicKey = (key1 << 16 | key2);
            Console.WriteLine("Bitmagic key: " + magicKey);
            var Key = W3LanguageKey.Get((uint)magicKey);
            Console.WriteLine("Magic: " + Key.Key + " Language: " + Key.Language);
            
            SoundInfoList.OrderBy(x => x.id).ToList().ForEach(x=> x.id |= Key.Key);
            Console.WriteLine("Sorting sound entries...");
            foreach (var t in SoundInfoList)
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
            Console.WriteLine("Wave file count: " + SoundInfoList.Count(x => x.wave_size > 0));
            Console.WriteLine("CR2W file count: " + SoundInfoList.Count(x => x.cr2w_size > 0));
            Console.ReadKey();
        }

        public void Write(BinaryWriter bw)
        {

        }
    }
}