using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using W3Edit.W3Strings;

namespace W3Edit.W3Speech
{
    /// <summary>
    /// Describes the items found within the w3speech format.
    /// </summary>
    public class ItemInfo
    {
        /// <summary>
        /// ID as found in the w3speech format.
        /// </summary>
        public readonly LanguageSpecificID id;
        public readonly UInt32 id_high;
        /// <summary>
        /// Offset of the start of the raw wem data, not including the leading 4 bytes of size information.
        /// </summary>
        public readonly UInt32 wem_offs;
        /// <summary>
        /// Size of the raw data, not including the leading 4 bytes and the trailing 8 bytes.
        /// </summary>
        public readonly UInt32 wem_size;
        /// <summary>
        /// Offset of the start of the raw cr2w data.
        /// </summary>
        public readonly UInt32 cr2w_offs;
        /// <summary>
        /// Size of the raw data.
        /// </summary>
        public readonly UInt32 cr2w_size;
        /// <summary>
        /// Duration in seconds.
        /// </summary>
        public readonly Single duration;

        public ItemInfo(LanguageSpecificID id, UInt32 id_high, UInt32 wem_offs, UInt32 wem_size, UInt32 cr2w_offs, UInt32 cr2w_size, Single duration)
        {
            this.id = id;
            this.id_high = id_high;
            this.wem_offs = wem_offs;
            this.wem_size = wem_size;
            this.cr2w_offs = cr2w_offs;
            this.cr2w_size = cr2w_size;
            this.duration = duration;
        }

        public override string ToString()
        {
            return $"ItemInfo({id},{id_high},{wem_offs},{wem_size},{cr2w_offs},{cr2w_size},{duration.ToString(CultureInfo.InvariantCulture)})";
        }
    }

    /// <summary>
    /// Describes the w3speech format.
    /// </summary>
    public class Info
    {
        /// <summary>
        /// Usually CPSW.
        /// </summary>
        public readonly String id;
        /// <summary>
        /// Usually 163 or 162.
        /// </summary>
        public readonly UInt32 version;
        /// <summary>
        /// Language key.
        /// </summary>
        public readonly W3LanguageKey language_key;
        /// <summary>
        /// Information about the items.
        /// </summary>
        public readonly IEnumerable<ItemInfo> item_infos;

        public Info(String id, UInt32 version, W3LanguageKey language_key, IEnumerable<ItemInfo> item_infos)
        {
            this.id = id;
            this.version = version;
            this.language_key = language_key;
            this.item_infos = item_infos;
        }

        public override string ToString()
        {
            return $"Info({id},{version},{language_key},[{String.Join(",", item_infos)}])";
        }
    }

    /// <summary>
    /// Used by Coder.Encode to describe the items to encode.
    /// </summary>
    public class WemCr2wInputPair
    {
        /// <summary>
        /// ID as found in the w3speech format.
        /// </summary>
        public readonly LanguageSpecificID id;
        public readonly UInt32 id_high;
        /// <summary>
        /// The raw wem data.
        /// </summary>
        public readonly Func<Stream> wem;
        /// <summary>
        /// Size of the wem data.
        /// </summary>
        public readonly UInt32 wem_size;
        /// <summary>
        /// Duration in seconds.
        /// </summary>
        public readonly Single duration;
        /// <summary>
        /// The raw cr2w data.
        /// </summary>
        public readonly Func<Stream> cr2w;
        /// <summary>
        /// Size of the cr2w data.
        /// </summary>
        public readonly UInt32 cr2w_size;

        public WemCr2wInputPair(LanguageSpecificID id, UInt32 id_high, Func<Stream> wem, UInt32 wem_size, Single duration, Func<Stream> cr2w, UInt32 cr2w_size)
        {
            this.id = id;
            this.id_high = id_high;
            this.wem = wem;
            this.wem_size = wem_size;
            this.duration = duration;
            this.cr2w = cr2w;
            this.cr2w_size = cr2w_size;
        }

        public override string ToString()
        {
            return $"WemCr2wInputPair({id},{id_high},{wem},{wem_size},{duration.ToString(CultureInfo.InvariantCulture)},{cr2w},{cr2w_size})";
        }
    }

    /// <summary>
    /// ID that is the same across all languages (language neutral).
    /// </summary>
    public class LanguageNeutralID
    {
        public readonly UInt32 value;

        public LanguageNeutralID(UInt32 value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"LanguageNeutralID({value})";
        }
    }

    /// <summary>
    /// The language specific id as found in w3speech files.
    /// </summary>
    public class LanguageSpecificID
    {
        public readonly UInt32 value;

        public LanguageSpecificID(UInt32 value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"LanguageSpecificID({value})";
        }
    }
}