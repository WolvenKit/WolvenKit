using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioGenericNameEventDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(0)]  [RED("entries")] public CArray<audioGenericNameEventItem> Entries { get; set; }
		[Ordinal(1)]  [RED("entryType")] public CHandle<audioGenericNameEventItem> EntryType { get; set; }

		public audioGenericNameEventDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
