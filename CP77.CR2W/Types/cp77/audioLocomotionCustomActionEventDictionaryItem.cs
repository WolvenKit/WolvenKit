using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioLocomotionCustomActionEventDictionaryItem : audioInlinedAudioMetadata
	{
		[Ordinal(0)]  [RED("key")] public CName Key { get; set; }
		[Ordinal(1)]  [RED("value")] public CName Value { get; set; }

		public audioLocomotionCustomActionEventDictionaryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
