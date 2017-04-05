using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using W3Edit.W3Strings;
using LanguageNeutralID = System.UInt32;
using LanguageSpecificID = System.UInt32;

namespace W3Edit.W3Speech
{
    public class ItemInfo
    {
        public readonly LanguageNeutralID id; // ID that is the same across all languages (language neutral).
        public readonly UInt32 id_high;
        public readonly UInt64 wem_offs;  // Offset of the start of the raw wem data, not including the leading 4 bytes of size information.
        public readonly UInt64 wem_size;  // Size of the raw data.
        public readonly UInt64 cr2w_offs;  // Offset of the start of the raw cr2w data.
        public readonly UInt64 cr2w_size;  // Size of the raw data.

        public ItemInfo(LanguageNeutralID id, UInt32 id_high, UInt64 wem_offs, UInt64 wem_size, UInt64 cr2w_offs, UInt64 cr2w_size)
        {
            this.id = id;
            this.id_high = id_high;
            this.wem_offs = wem_offs;
            this.wem_size = wem_size;
            this.cr2w_offs = cr2w_offs;
            this.cr2w_size = cr2w_size;
        }
    }

    public class Item
    {
        public enum ItemType { Wem, Cr2w };

        public readonly LanguageNeutralID id; // ID that is the same across all languages (language neutral).
        public readonly UInt32 id_high;
        public readonly UInt64 size;  // Size of the raw data.
        public readonly ItemType item_type; // Is it wem or cr2w data?
        public readonly BinaryReader data;  // The raw data.

        public Item(LanguageNeutralID id, UInt32 id_high, UInt64 size, ItemType item_type, BinaryReader data)
        {
            this.id = id;
            this.id_high = id_high;
            this.size = size;
            this.item_type = item_type;
            this.data = data;
        }
    }

    public class Info
    {
        public readonly String id;  // Usually CPSW.
        public readonly UInt32 version;  // Usually 163 or 162.
        public readonly W3Language language;  // Language information.
        public readonly IEnumerable<ItemInfo> item_infos;  // Information about the items.
        public readonly IEnumerable<Item> items;  // The items.

        public Info(String id, uint version, W3Language language, IEnumerable<ItemInfo> item_infos, IEnumerable<Item> items)
        {
            this.id = id;
            this.version = version;
            this.language = language;
            this.item_infos = item_infos;
            this.items = items;
        }
    }

    public class WemCr2wInputPair
    {
        public readonly LanguageNeutralID id; // ID that is the same across all languages (language neutral).
        public readonly UInt32 id_high;
        public readonly BinaryReader wem;  // The raw wem data.
        public readonly UInt64 wem_size;  // Size of the wem data.
        public readonly float duration;  // Duration in seconds.
        public readonly BinaryReader cr2w;  // The raw cr2w data.
        public readonly UInt64 cr2w_size;  // Size of the cr2w data.

        public WemCr2wInputPair(LanguageNeutralID id, UInt32 id_high, BinaryReader wem, UInt64 wem_size, float duration, BinaryReader cr2w, UInt64 cr2w_size)
        {
            this.id = id;
            this.id_high = id_high;
            this.wem = wem;
            this.wem_size = wem_size;
            this.duration = duration;
            this.cr2w = cr2w;
            this.cr2w_size = cr2w_size;
        }
    }

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
            4 bytes of (wem size + 12) (Number)
            4 bytes of zeros
            4 bytes for absolute offset (Number), points at (b) down below
            4 bytes of zeros
            4 bytes of cr2w size (Number)
            4 bytes of zeros
          2 bytes for key2 (Number), part of the language key
          for each wemcr2w pair:
            4 bytes for wem size (Number) (a)
            x bytes for wem (raw data)
            4 bytes for duration in seconds (Float)
            4 bytes of 04 00 00 00
            y bytes for cr2w (raw data) (b)
        */

        private class ItemStream : Stream
        {
            private class PositionLockPair
            {
                public UInt64 current_position;
                public readonly Object position_lock;

                public PositionLockPair(UInt64 current_position, Object position_lock)
                {
                    this.current_position = current_position;
                    this.position_lock = position_lock;
                }
            }

            private readonly UInt64 size;
            private readonly UInt64 offset;
            private readonly ItemInfo info;
            private readonly BinaryReader br;
            private readonly PositionLockPair position;
            private UInt64 read_count;

            public override bool CanRead { get { return true; } }
            public override bool CanSeek { get { return false; } }
            public override bool CanWrite { get { return false; } }
            public override long Length { get { return (long)this.size; } }
            public override long Position { get { return (long)this.read_count; } set { throw new NotSupportedException(); } }
            public override void Flush() { }
            public override long Seek(long offset, SeekOrigin origin) { throw new NotSupportedException(); }
            public override void SetLength(long value) { throw new NotSupportedException(); }
            public override void Write(byte[] buffer, int offset, int count) { throw new NotSupportedException(); }

            private int ReadNextByte()
            {
                lock (this.position.position_lock)
                {
                    while (this.position.current_position < this.offset)
                    {
                        this.br.ReadByte();
                        this.position.current_position += 1;
                    }
                    if (this.read_count == this.size)
                    {
                        return -1;
                    }
                    else if (this.position.current_position != this.read_count + this.offset)
                    {
                        throw new IOException();
                    }
                    else
                    {
                        var b = br.ReadByte();
                        this.read_count += 1;
                        this.position.current_position += 1;
                        return b;
                    }
                }
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                if (buffer == null)
                {
                    throw new ArgumentNullException();
                }
                if (offset + count > buffer.Length)
                {
                    throw new ArgumentException();
                }
                if (offset < 0 || count < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                var i = 0;
                while (i < count)
                {
                    var b = this.ReadNextByte();
                    if (b == -1)
                    {
                        break;
                    }
                    buffer[i + offset] = (byte)b;
                    i += 1;
                }
                return i;
            }

            private ItemStream(Tuple<UInt64, ItemInfo> tuple, PositionLockPair position, BinaryReader br)
            {
                this.offset = tuple.Item1;
                this.info = tuple.Item2;
                this.size = offset == info.wem_offs ? info.wem_size : info.cr2w_size;
                this.read_count = 0;
                this.position = position;
                this.br = br;
            }

            public Item item()
            {
                var item_type = this.offset == this.info.wem_offs ? Item.ItemType.Wem : Item.ItemType.Cr2w;
                return new Item(this.info.id, this.info.id_high, this.size, item_type, new BinaryReader(this));
            }

            public static IEnumerable<Item> items(UInt64 current_position, IEnumerable<ItemInfo> item_infos, BinaryReader br)
            {
                var position_lock = new PositionLockPair(current_position, new object());
                return item_infos
                    .SelectMany(info => new List<Tuple<UInt64, ItemInfo>> { Tuple.Create(info.wem_offs, info), Tuple.Create(info.cr2w_offs, info) })
                    .OrderBy(t => t.Item1)
                    .Select(t => new ItemStream(t, position_lock, br).item())
                    .ToList();
            }
        }

        // Parse information about the .w3speech format from BinaryReader with default languages list.
        public static Info Info(BinaryReader br)
        {
            return Info(W3Language.languages, br);
        }

        // Parse information about the .w3speech format from BinaryReader.
        public static Info Info(IEnumerable<W3Language> languages, BinaryReader br)
        {
            var str = System.Text.Encoding.Default.GetString(br.ReadBytes(4));
            var version = br.ReadUInt32();
            var key1 = br.ReadUInt16();
            var item_count = br.ReadBit6();
            var raw_item_infos = new List<Tuple<uint, uint, uint, uint, uint, uint>>();
            for (var i = 0; i < item_count.value; i += 1)
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
                raw_item_infos.Add(Tuple.Create(langSpecificID, id_high, wave_offs, wave_size, cr2w_offs, cr2w_size));
            }
            var key2 = br.ReadUInt16();
            var key = (key1 << 16 | key2);
            var language = languages.First(lang => lang.Key == key);
            var item_infos = raw_item_infos.Select(t =>
                    new ItemInfo(W3Language.languageNeutralID(t.Item1, language), t.Item2, t.Item3, t.Item4, t.Item5, t.Item6)
                ).ToList().AsReadOnly();
            var items = ItemStream.items(4 + 4 + 2 + ((UInt64)item_count.length) + ((UInt64)item_count.value * 10 * 4) + 2, item_infos, br);
            return new Info(str, version, language, item_infos, items);
        }

        // Write .w3speech format to BinaryWriter.
        public static void Pack(IEnumerable<WemCr2wInputPair> inputs, String id, UInt32 version, W3Language language, BinaryWriter bw)
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
                var cr2w_offset = wave_offset + pair.wem_size + 8;
                pos = cr2w_offset + pair.cr2w_size;
                return new ItemInfo(pair.id, pair.id_high, wave_offset, pair.wem_size, cr2w_offset, pair.cr2w_size);
            }).ToList();
            itemInfos.ForEach(info =>
            {
                byte[] zeros = new byte[] { 0, 0, 0, 0 };
                bw.Write((UInt32)W3Language.languageSpecificID(info.id, language));
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
            bw.Write((UInt16)(language.Key & 0xFFFF));
            inputList.ForEach(pair =>
            {
                bw.Write((UInt32)pair.wem_size);
                UInt64 c = 0;
                while (c < pair.wem_size)
                {
                    bw.Write(pair.wem.ReadByte());
                    c += 1;
                }
                bw.Write(pair.duration);
                bw.Write((UInt32)4);
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