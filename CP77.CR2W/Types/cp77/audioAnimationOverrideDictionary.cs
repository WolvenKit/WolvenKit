using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioAnimationOverrideDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(0)]  [RED("entries")] public CArray<audioAnimationOverrideDictionaryItem> Entries { get; set; }
		[Ordinal(1)]  [RED("entryType")] public CHandle<audioAnimationOverrideDictionaryItem> EntryType { get; set; }

		public audioAnimationOverrideDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
