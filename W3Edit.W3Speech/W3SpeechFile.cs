using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using W3Edit.W3Strings;
using LanguageNeutralID = System.UInt32;
using LanguageSpecificID = System.UInt32;

namespace W3Edit.W3Speech
{
    public class W3SoundInfo
    {
        public readonly LanguageNeutralID id;
        public readonly UInt32 id_high;
        public readonly UInt64 wave_offs;
        public readonly UInt64 wave_size;
        public readonly UInt64 cr2w_offs;
        public readonly UInt64 cr2w_size;

        public W3SoundInfo(LanguageNeutralID id, UInt32 id_high, UInt64 wave_offs, UInt64 wave_size, UInt64 cr2w_offs, UInt64 cr2w_size)
        {
            this.id = id;
            this.id_high = id_high;
            this.wave_offs = wave_offs;
            this.wave_size = wave_size;
            this.cr2w_offs = cr2w_offs;
            this.cr2w_size = cr2w_size;
        }
    }

    public class W3Info
    {
        public readonly String id;
        public readonly uint version;
        public readonly W3Language language;
        public readonly IEnumerable<W3SoundInfo> soundInfos;

        public W3Info(String id, uint version, W3Language language, IEnumerable<W3SoundInfo> soundInfos)
        {
            this.id = id;
            this.version = version;
            this.language = language;
            this.soundInfos = soundInfos;
        }
    }

    public class WaveCr2wInputPair
    {
        public readonly LanguageNeutralID id;
        public readonly UInt32 id_high;
        public readonly BinaryReader wave;
        public readonly UInt64 wave_size;
        public readonly BinaryReader cr2w;
        public readonly UInt64 cr2w_size;

        public WaveCr2wInputPair(LanguageNeutralID id, UInt32 id_high, BinaryReader wave, UInt64 wave_size, BinaryReader cr2w, UInt64 cr2w_size)
        {
            this.id = id;
            this.id_high = id_high;
            this.wave = wave;
            this.wave_size = wave_size;
            this.cr2w = cr2w;
            this.cr2w_size = cr2w_size;
        }
    }

    public class W3Speech
    {
        /*
          4 bytes for id (String), usually CPSW
          4 bytes for version (Number), usually A2 00 00 00 or A3 00 00 00
          2 bytes for key1 (Number), part of the language key
          variable amount of bytes for wavecr2w pair count
          for each wavecr2wpair:
            4 bytes for language specific id (Number)
            4 bytes for some other id (Number)
            4 bytes for wave offset (Number)
            4 bytes of zeros
            4 bytes of (wave size + 12) (Number)
            4 bytes of zeros
            4 bytes of cr2w offset (Number)
            4 bytes of zeros
            4 bytes of cr2w size (Number)
            4 bytes of zeros
          2 bytes for key2 (Number), part of the language key
          for each wavecr2w pair:
            4 bytes for wave size (Number)
            x bytes for wave (raw data)
            8 bytes of I don't know what
            y bytes for cr2w (raw data)
        */

        public static W3Info ReadInfo(BinaryReader br)
        {
            var str = System.Text.Encoding.Default.GetString(br.ReadBytes(4));
            var version = br.ReadUInt32();
            var key1 = br.ReadUInt16();
            var count = br.ReadBit6();
            var sound_infos = new List<Tuple<uint, uint, uint, uint, uint, uint>>();
            for (var i = 0; i < count; i += 1)
            {
                var langSpecificID = br.ReadUInt32();
                var id_high = br.ReadUInt32();
                var wave_offs = br.ReadUInt32() + 4;
                br.ReadUInt32();
                var wave_size = br.ReadUInt32() - 12;
                br.ReadUInt32();
                var cr2w_offs = br.ReadUInt32();
                br.ReadUInt32();
                var cr2w_size = br.ReadUInt32();
                br.ReadUInt32();
                sound_infos.Add(Tuple.Create(langSpecificID, id_high, wave_offs, wave_size, cr2w_offs, cr2w_size));
            }
            var key2 = br.ReadUInt16();
            var key = (key1 << 16 | key2);
            var language = W3Language.languages.First(lang => lang.Key == key);
            return new W3Info(
                str,
                version,
                language,
                sound_infos.Select(t =>
                    new W3SoundInfo(W3Language.languageNeutralID(t.Item1, language), t.Item2, t.Item3, t.Item4, t.Item5, t.Item6)
                ).ToList().AsReadOnly());
        }

        public void Pack(IEnumerable<WaveCr2wInputPair> inputs, String id, UInt32 version, W3Language language, BinaryWriter bw)
        {
            var inputList = inputs.ToList();
            bw.Write(id);
            bw.Write(version);
            bw.Write((UInt16)(language.Key >> 16));
            var bytes_written_count = bw.WriteBit6(inputList.Count);
            UInt64 pos = 4 + 4 + 2 + bytes_written_count + ((UInt64)inputList.Count * 10 * 4) + 2;
            var itemInfos = inputList.Select(pair =>
            {
                var wave_offset = pos + 4;
                var cr2w_offset = wave_offset + pair.wave_size + 8;
                pos = cr2w_offset + pair.cr2w_size;
                return new W3SoundInfo(pair.id, pair.id_high, wave_offset, pair.wave_size, cr2w_offset, pair.cr2w_size);
            }).ToList();
            itemInfos.ForEach(info =>
            {
                byte[] zeros = new byte[] { 0, 0, 0, 0 };
                bw.Write((UInt32)W3Language.languageSpecificID(info.id, language));
                bw.Write((UInt32)info.id_high);
                bw.Write((UInt32)info.wave_offs - 4);
                bw.Write(zeros);
                bw.Write((UInt32)info.wave_size + 12);
                bw.Write(zeros);
                bw.Write((UInt32)info.cr2w_offs);
                bw.Write(zeros);
                bw.Write((UInt32)info.cr2w_size);
                bw.Write(zeros);
            });
            bw.Write((UInt16)(language.Key & 0xFFFF));
            inputList.ForEach(pair =>
            {
                bw.Write((UInt32)pair.wave_size);
                UInt64 c = 0;
                while (c < pair.wave_size) {
                    bw.Write(pair.wave.ReadByte());
                    c += 1;
                }
                bw.Write((UInt32) 0); //TODO: Don't know what to write here!
                bw.Write((UInt32)0); //TODO: Don't know what to write here!
                c = 0;
                while (c < pair.cr2w_size)
                {
                    bw.Write(pair.cr2w.ReadByte());
                    c += 1;
                }
            });
        }
    }
}