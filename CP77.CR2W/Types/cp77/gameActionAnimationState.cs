using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameActionAnimationState : gameActionReplicatedState
	{
		[Ordinal(0)]  [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
		[Ordinal(1)]  [RED("animFeature")] public CHandle<animAnimFeature_AIAction> AnimFeature { get; set; }
		[Ordinal(2)]  [RED("useRootMotion")] public CBool UseRootMotion { get; set; }
		[Ordinal(3)]  [RED("usePoseMatching")] public CBool UsePoseMatching { get; set; }
		[Ordinal(4)]  [RED("motionDynamicObjectsCheck")] public CBool MotionDynamicObjectsCheck { get; set; }
		[Ordinal(5)]  [RED("slideParams")] public gameActionAnimationSlideParams SlideParams { get; set; }
		[Ordinal(6)]  [RED("targetObject")] public wCHandle<gameObject> TargetObject { get; set; }
		[Ordinal(7)]  [RED("sendLoopEvent")] public CBool SendLoopEvent { get; set; }

		public gameActionAnimationState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
