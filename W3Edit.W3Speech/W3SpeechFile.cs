using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Media;
using System.Xml.Linq;
using W3Edit.W3Strings;

namespace W3Edit.W3Speech
{
    public class W3SoundInfo
    {
        public string Filename;
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

        public void Read(BinaryReader br,XDocument soundbanksinfo)
        {
            var magic = br.ReadBytes(4);
            if (!magic.SequenceEqual(IDString))
                throw new Exception("Not a valid w3speech file!");
            var version = br.ReadUInt32();
            var key1 = br.ReadUInt16();
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
            var key2 = br.ReadUInt16();
            var magicKey = (key1 << 16 | key2);
            var languageKey = W3LanguageKey.Get((uint)magicKey);
            foreach (var w3SoundInfo in SoundInfoList)
            {
                w3SoundInfo.id |= languageKey.Key; //TODO: Fix this then the xml thing can be enabled
            }
            SoundInfoList = SoundInfoList.OrderBy(x => x.id).ToList();
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
                t.Filename = GetSoundBankName(t.id, soundbanksinfo);
            }
        }

        public string GetSoundBankName(uint id, XDocument soundbanksinfo)
        {
            return "";
            //TODO: Finish this after the magic bitoperation is fixed
            try
            {
                return soundbanksinfo.Descendants("File")
                        .First(x => x.Attributes().Any(y => int.Parse(y.Value) == id))
                        .Element("ShortName")
                        .Value;
            }
            catch { return ""; } 
        }
        

        public void Write(BinaryWriter bw)
        {

        }
    }
}