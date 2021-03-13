using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioEventOverrideDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] [RED("entries")] public CArray<audioEventOverrideDictionaryItem> Entries { get; set; }
		[Ordinal(2)] [RED("entryType")] public CHandle<audioEventOverrideDictionaryItem> EntryType { get; set; }

		public audioEventOverrideDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
