using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.MemoryMappedFiles;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.W3Strings;

namespace WolvenKit.W3Speech
{
    /// <summary>
    /// Describes the items found within the w3speech format.
    /// </summary>
    public class SpeechEntry : IWitcherFile
    {
        /// <summary>
        /// ID as found in the w3speech format.
        /// </summary>
        public LanguageSpecificID id { get; set; }
        public UInt32 id_high { get; set; }
        /// <summary>
        /// Offset of the start of the raw wem data, not including the leading 4 bytes of size information.
        /// </summary>
        public UInt32 wem_offs { get; set; }
        /// <summary>
        /// Size of the raw data, not including the leading 4 bytes and the trailing 8 bytes.
        /// </summary>
        public UInt32 wem_size { get; set; }
        /// <summary>
        /// Offset of the start of the raw cr2w data.
        /// </summary>
        public UInt32 cr2w_offs { get; set; }
        /// <summary>
        /// Size of the raw data.
        /// </summary>
        public UInt32 cr2w_size { get; set; }
        /// <summary>
        /// Duration in seconds.
        /// </summary>
        public Single duration { get; set; }

        public SpeechEntry()
        {

        }

        public SpeechEntry(IWitcherArchiveType bundle, LanguageSpecificID id, UInt32 id_high, UInt32 wem_offs, UInt32 wem_size, UInt32 cr2w_offs, UInt32 cr2w_size, Single duration)
        {
            this.Bundle = bundle;
            this.id = id;
            this.id_high = id_high;
            this.wem_offs = wem_offs;
            this.wem_size = wem_size;
            this.cr2w_offs = cr2w_offs;
            this.cr2w_size = cr2w_size;
            this.duration = duration;
            this.Size = wem_size + cr2w_size;
            this.ZSize = wem_size + cr2w_size;
            this.Name = id.ToString() + ".cr2w_wem_pair";
            this.PageOFfset = cr2w_offs;
        }

        public IWitcherArchiveType Bundle { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public uint ZSize { get; set; }

        public long PageOFfset { get; set; }

        public string CompressionType => "None";

        public void Extract(Stream output)
        {
            using (var file = MemoryMappedFile.CreateFromFile(Bundle.FileName, FileMode.Open))
            {
                using (var viewstream = file.CreateViewStream(PageOFfset, ZSize, MemoryMappedFileAccess.Read))
                {
                    viewstream.CopyTo(output);
                }
            }
        }

        public void Extract(BundleFileExtractArgs e)
        {
            PageOFfset = cr2w_offs;
            ZSize = cr2w_size;
            Extract(new FileStream(Path.ChangeExtension(e.FileName, ".cr2w"), FileMode.Create));
            PageOFfset = wem_offs;
            ZSize = wem_size;
            Extract(new FileStream(Path.ChangeExtension(e.FileName, ".wem"), FileMode.Create));
        }

        public override string ToString()
        {
            return $"ItemInfo({id},{id_high},{wem_offs},{wem_size},{cr2w_offs},{cr2w_size},{duration.ToString(CultureInfo.InvariantCulture)})";
        }
    }

    /// <summary>
    /// Describes the w3speech format.
    /// </summary>
    public class W3Speech : IWitcherArchiveType
    {
        /// <summary>
        /// Usually CPSW.
        /// </summary>
        public String id { get; set; }
        /// <summary>
        /// Usually 163 or 162.
        /// </summary>
        public UInt32 version { get; set; }
        /// <summary>
        /// Language key.
        /// </summary>
        public W3LanguageKey language_key { get; set; }
        /// <summary>
        /// Information about the items.
        /// </summary>
        public IEnumerable<SpeechEntry> item_infos { get; set; }

        public W3Speech()
        {

        }

        public W3Speech(string name)
        {
            FileName = name;
        }

        public W3Speech(String filename, String id, UInt32 version, W3LanguageKey language_key, IEnumerable<SpeechEntry> item_infos)
        {
            this.FileName = filename;
            this.id = id;
            this.version = version;
            this.language_key = language_key;
            this.item_infos = item_infos;
        }

        public EBundleType TypeName => EBundleType.Speech;

        public string FileName { get; set; }

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