using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioMaterialMeleeSoundDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(0)]  [RED("entryType")] public CHandle<audioMaterialMeleeSoundDictionaryItem> EntryType { get; set; }
		[Ordinal(1)]  [RED("entries")] public CArray<audioMaterialMeleeSoundDictionaryItem> Entries { get; set; }

		public audioMaterialMeleeSoundDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
