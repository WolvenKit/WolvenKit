using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocomotionAdjusterOnEvent : animAnimNode_LocomotionAdjuster
	{
		[Ordinal(19)] [RED("locomotionFeatureName")] public CName LocomotionFeatureName { get; set; }
		[Ordinal(20)] [RED("targetAnimationName")] public CName TargetAnimationName { get; set; }
		[Ordinal(21)] [RED("startAdjustmentAfterAnimEvent")] public CName StartAdjustmentAfterAnimEvent { get; set; }

		public animAnimNode_LocomotionAdjusterOnEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
