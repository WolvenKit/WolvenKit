using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLocomotionCustomActionEventDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] [RED("entries")] public CArray<audioLocomotionCustomActionEventDictionaryItem> Entries { get; set; }
		[Ordinal(2)] [RED("entryType")] public CHandle<audioLocomotionCustomActionEventDictionaryItem> EntryType { get; set; }

		public audioLocomotionCustomActionEventDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
