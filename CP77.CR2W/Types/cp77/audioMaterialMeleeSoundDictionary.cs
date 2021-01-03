using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioMaterialMeleeSoundDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(0)]  [RED("entries")] public CArray<audioMaterialMeleeSoundDictionaryItem> Entries { get; set; }
		[Ordinal(1)]  [RED("entryType")] public CHandle<audioMaterialMeleeSoundDictionaryItem> EntryType { get; set; }

		public audioMaterialMeleeSoundDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
