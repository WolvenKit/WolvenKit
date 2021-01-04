using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAudioFoliageMaterialDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(0)]  [RED("entries")] public CArray<audioAudioFoliageMaterialDictionaryItem> Entries { get; set; }
		[Ordinal(1)]  [RED("entryType")] public CHandle<audioAudioFoliageMaterialDictionaryItem> EntryType { get; set; }

		public audioAudioFoliageMaterialDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
