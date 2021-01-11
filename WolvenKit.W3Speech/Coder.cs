using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.W3Strings;

namespace WolvenKit.W3Speech
{
    public static class Coder
    {
        /*
          4 bytes for id (String), usually CPSW
          4 bytes for version (Number), usually A2 00 00 00 or A3 00 00 00
          2 bytes for key1 (Number), part of the language key
          variable amount of bytes for wavecr2w pair count
          for each wemcr2w pair:
            4 bytes for language specific id (Number)
            4 bytes for some other id (Number)
            4 bytes for absolute offset (Number), points at (a) down below 
            4 bytes of zeros
            4 bytes of (wem size + 12) (Number) (c)
            4 bytes of zeros
            4 bytes for absolute offset (Number), points at (b) down below
            4 bytes of zeros
            4 bytes of cr2w size (Number) (d)
            4 bytes of zeros
          2 bytes for key2 (Number), part of the language key
          for each wemcr2w pair:
            4 bytes for wem size (Number) (a)
            c - 12 bytes for wem (raw data)
            4 bytes for duration in seconds (Float)
            4 bytes of 04 00 00 00
            d bytes for cr2w (raw data) (b)
        */

        /// <summary>
        /// Parse information about the w3speech format from the BinaryReader.
        /// </summary>
        /// <param name="br">The stream containing the w3speech format to read from.</param>
        /// <returns>All information found inside the stream.</returns>
        /// <exception cref="Exception">Something happened.</exception>
        public static W3Speech Decode(IGameArchive parent, BinaryReader br)
        {
            var str = System.Text.Encoding.Default.GetString(br.ReadBytes(4));
            var version = br.ReadUInt32();
            var key1 = br.ReadUInt16();
            var item_count = br.ReadBit6();
            var raw_item_infos = new List<Tuple<uint, uint, uint, uint, uint, uint>>();
            for (var i = 0; i < item_count.value; i += 1)
            {
                var lang_specific_ID = br.ReadUInt32();
                var id_high = br.ReadUInt32();
                var wave_offs = br.ReadUInt32() + 4;
                br.ReadUInt32();
                var wave_size = br.ReadUInt32() - 12;
                br.ReadUInt32();
                var cr2w_offs = br.ReadUInt32();
                br.ReadUInt32();
                var cr2w_size = br.ReadUInt32();
                br.ReadUInt32();
                raw_item_infos.Add(Tuple.Create(lang_specific_ID, id_high, wave_offs, wave_size, cr2w_offs, cr2w_size));
            }
            var key2 = br.ReadUInt16(); //BUG: This break sometimes! "D:\\SteamLibrary\\steamapps\\common\\TW3\\bin\\x64\\..\\..\\DLC\\DLC1\\content\\brpc.w3speech"
            var key = new W3LanguageKey((UInt32)(key1 << 16 | key2));
            var position = 4 + 4 + 2 + ((UInt64)item_count.length) + ((UInt64)item_count.value * 10 * 4) + 2;
            var item_infos = raw_item_infos
                    .OrderBy(t => t.Item3)
                    .Select(t =>
                    {
                        var duration_offset = t.Item3 - position + t.Item4;
                        StreamTools.Skip(duration_offset, br.BaseStream);
                        position += duration_offset;
                        var duration = br.ReadSingle();
                        position += 4;
                        return new SpeechEntry(parent, new LanguageSpecificID(t.Item1), t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, duration);
                    })
                    .ToList()
                    .AsReadOnly();
            return new W3Speech(parent.ArchiveAbsolutePath, str, version, key, item_infos);
        }

        /// <summary>
        /// Write w3speech format to the BinaryWriter with CPSW for id and 163 for version.
        /// </summary>
        /// <param name="inputs">Wem and cr2w pairs to write to the stream.</param>
        /// <param name="language_key">The language key to use for the format.</param>
        /// <param name="bw">Stream to write the w3speech format to.</param>
        /// <exception cref="Exception">Something happened.</exception>
        public static void Encode(IEnumerable<WemCr2wInputPair> inputs, W3LanguageKey language_key, BinaryWriter bw)
        {
            Encode("CPSW", 163, inputs, language_key, bw);
        }

        /// <summary>
        /// Write .w3speech format to BinaryWriter.
        /// </summary>
        /// <param name="id">The id to use which usually is CPSW.</param>
        /// <param name="version">The version to use, which is usually either 163 or 162.</param>
        /// <param name="inputs">Wem and cr2w pairs to write to the stream.</param>
        /// <param name="language_key">The language key to use for the format.</param>
        /// <param name="bw">Stream to write the w3speech format to.</param>
        /// <exception cref="Exception">Something happened.</exception>
        public static void Encode(String id, UInt32 version, IEnumerable<WemCr2wInputPair> inputs, W3LanguageKey language_key, BinaryWriter bw)
        {
            var inputList = inputs.ToList();
            bw.Write(System.Text.Encoding.ASCII.GetBytes(id.Substring(0, 4).PadLeft(4)));
            bw.Write(version);
            bw.Write((UInt16)(language_key.value >> 16));
            var bytes_written_count = bw.WriteBit6(inputList.Count);
            UInt64 pos = 4 + 4 + 2 + bytes_written_count + ((UInt64)inputList.Count * 10 * 4) + 2;
            var itemInfos = inputList.Select(pair =>
            {
                var wave_offset = (UInt32)pos + 4;
                UInt32 cr2w_offset = wave_offset + pair.wem_size + 8;
                pos = cr2w_offset + pair.cr2w_size;
                return new SpeechEntry(null, pair.id, pair.id_high, wave_offset, pair.wem_size, cr2w_offset, pair.cr2w_size, pair.duration);
            }).ToList();
            byte[] zeros = new byte[] { 0, 0, 0, 0 };
            itemInfos.ForEach(info =>
            {
                bw.Write((UInt32)info.id.value);
                bw.Write((UInt32)info.id_high);
                bw.Write((UInt32)info.wem_offs - 4);
                bw.Write(zeros);
                bw.Write((UInt32)info.wem_size + 12);
                bw.Write(zeros);
                bw.Write((UInt32)info.cr2w_offs);
                bw.Write(zeros);
                bw.Write((UInt32)info.cr2w_size);
                bw.Write(zeros);
            });
            bw.Write((UInt16)(language_key.value & 0xFFFF));
            inputList.ForEach(pair =>
            {
                var wem = pair.wem.Invoke();
                bw.Write((UInt32)pair.wem_size);
                StreamTools.Transfer(pair.wem_size, wem, bw.BaseStream);
                wem.Close();
                bw.Write(pair.duration);
                bw.Write((UInt32)4);
                var cr2w = pair.cr2w.Invoke();
                StreamTools.Transfer(pair.cr2w_size, cr2w, bw.BaseStream);
                cr2w.Close();
            });
        }
    }
}
