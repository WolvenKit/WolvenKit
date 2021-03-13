using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_EffectDuration : animAnimEvent
	{
		[Ordinal(3)] [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(4)] [RED("sequenceShift")] public CUInt32 SequenceShift { get; set; }
		[Ordinal(5)] [RED("breakAllLoopsOnStop")] public CBool BreakAllLoopsOnStop { get; set; }

		public animAnimEvent_EffectDuration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
