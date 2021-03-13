using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGenericNameEventDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] [RED("entries")] public CArray<audioGenericNameEventItem> Entries { get; set; }
		[Ordinal(2)] [RED("entryType")] public CHandle<audioGenericNameEventItem> EntryType { get; set; }

		public audioGenericNameEventDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
