using System;
using System.Collections.Generic;
using System.IO;
using W3Edit.W3Strings;
using LanguageNeutralID = System.UInt32;

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
}