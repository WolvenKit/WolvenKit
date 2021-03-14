using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MixerSlot : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("maxNormalAnimEntriesCount")] public CUInt16 MaxNormalAnimEntriesCount { get; set; }
		[Ordinal(13)] [RED("maxAdditiveAnimEntriesCount")] public CUInt16 MaxAdditiveAnimEntriesCount { get; set; }
		[Ordinal(14)] [RED("maxOverrideAnimEntriesCount")] public CUInt16 MaxOverrideAnimEntriesCount { get; set; }

		public animAnimNode_MixerSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
