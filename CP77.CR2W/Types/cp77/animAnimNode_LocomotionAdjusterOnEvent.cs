using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocomotionAdjusterOnEvent : animAnimNode_LocomotionAdjuster
	{
		[Ordinal(0)]  [RED("locomotionFeatureName")] public CName LocomotionFeatureName { get; set; }
		[Ordinal(1)]  [RED("startAdjustmentAfterAnimEvent")] public CName StartAdjustmentAfterAnimEvent { get; set; }
		[Ordinal(2)]  [RED("targetAnimationName")] public CName TargetAnimationName { get; set; }

		public animAnimNode_LocomotionAdjusterOnEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
