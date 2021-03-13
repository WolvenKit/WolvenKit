using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveFollowSplineTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		[Ordinal(1)] [RED("useKinematic")] public CHandle<AIArgumentMapping> UseKinematic { get; set; }
		[Ordinal(2)] [RED("needDriver")] public CHandle<AIArgumentMapping> NeedDriver { get; set; }
		[Ordinal(3)] [RED("spline")] public CHandle<AIArgumentMapping> Spline { get; set; }
		[Ordinal(4)] [RED("secureTimeOut")] public CHandle<AIArgumentMapping> SecureTimeOut { get; set; }
		[Ordinal(5)] [RED("backwards")] public CHandle<AIArgumentMapping> Backwards { get; set; }
		[Ordinal(6)] [RED("reverse")] public CHandle<AIArgumentMapping> Reverse { get; set; }
		[Ordinal(7)] [RED("closest")] public CHandle<AIArgumentMapping> Closest { get; set; }
		[Ordinal(8)] [RED("forcedStartSpeed")] public CHandle<AIArgumentMapping> ForcedStartSpeed { get; set; }
		[Ordinal(9)] [RED("stopAtPathEnd")] public CHandle<AIArgumentMapping> StopAtPathEnd { get; set; }
		[Ordinal(10)] [RED("keepDistanceParamBool")] public CHandle<AIArgumentMapping> KeepDistanceParamBool { get; set; }
		[Ordinal(11)] [RED("keepDistanceParamCompanion")] public CHandle<AIArgumentMapping> KeepDistanceParamCompanion { get; set; }
		[Ordinal(12)] [RED("keepDistanceParamDistance")] public CHandle<AIArgumentMapping> KeepDistanceParamDistance { get; set; }
		[Ordinal(13)] [RED("rubberBandingBool")] public CHandle<AIArgumentMapping> RubberBandingBool { get; set; }
		[Ordinal(14)] [RED("rubberBandingTargetRef")] public CHandle<AIArgumentMapping> RubberBandingTargetRef { get; set; }
		[Ordinal(15)] [RED("rubberBandingMinDistance")] public CHandle<AIArgumentMapping> RubberBandingMinDistance { get; set; }
		[Ordinal(16)] [RED("rubberBandingMaxDistance")] public CHandle<AIArgumentMapping> RubberBandingMaxDistance { get; set; }
		[Ordinal(17)] [RED("rubberBandingStopAndWait")] public CHandle<AIArgumentMapping> RubberBandingStopAndWait { get; set; }
		[Ordinal(18)] [RED("rubberBandingTeleportToCatchUp")] public CHandle<AIArgumentMapping> RubberBandingTeleportToCatchUp { get; set; }

		public AIbehaviorDriveFollowSplineTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
