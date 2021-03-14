using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionAnimationState : gameActionReplicatedState
	{
		[Ordinal(5)] [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
		[Ordinal(6)] [RED("animFeature")] public CHandle<animAnimFeature_AIAction> AnimFeature { get; set; }
		[Ordinal(7)] [RED("useRootMotion")] public CBool UseRootMotion { get; set; }
		[Ordinal(8)] [RED("usePoseMatching")] public CBool UsePoseMatching { get; set; }
		[Ordinal(9)] [RED("motionDynamicObjectsCheck")] public CBool MotionDynamicObjectsCheck { get; set; }
		[Ordinal(10)] [RED("slideParams")] public gameActionAnimationSlideParams SlideParams { get; set; }
		[Ordinal(11)] [RED("targetObject")] public wCHandle<gameObject> TargetObject { get; set; }
		[Ordinal(12)] [RED("sendLoopEvent")] public CBool SendLoopEvent { get; set; }

		public gameActionAnimationState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
