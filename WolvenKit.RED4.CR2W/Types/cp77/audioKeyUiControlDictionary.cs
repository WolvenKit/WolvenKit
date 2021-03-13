using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioKeyUiControlDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] [RED("entries")] public CArray<audioKeyUiControlPairDictionaryItem> Entries { get; set; }
		[Ordinal(2)] [RED("entryType")] public CHandle<audioKeyUiControlPairDictionaryItem> EntryType { get; set; }

		public audioKeyUiControlDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
