using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionDescription : ISerializable
	{
		[Ordinal(0)] [RED("targetStateIndex")] public CUInt32 TargetStateIndex { get; set; }
		[Ordinal(1)] [RED("condition")] public CHandle<animIAnimStateTransitionCondition> Condition { get; set; }
		[Ordinal(2)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(3)] [RED("interpolator")] public CHandle<animIAnimStateTransitionInterpolator> Interpolator { get; set; }
		[Ordinal(4)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(5)] [RED("priority")] public CInt32 Priority { get; set; }
		[Ordinal(6)] [RED("syncMethod")] public CHandle<animISyncMethod> SyncMethod { get; set; }
		[Ordinal(7)] [RED("isForcedToTrue")] public CBool IsForcedToTrue { get; set; }
		[Ordinal(8)] [RED("supportBlendFromPose")] public CBool SupportBlendFromPose { get; set; }
		[Ordinal(9)] [RED("canRequestInertialization")] public CBool CanRequestInertialization { get; set; }
		[Ordinal(10)] [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
		[Ordinal(11)] [RED("actionAnimDatabaseRef")] public rRef<animActionAnimDatabase> ActionAnimDatabaseRef { get; set; }
		[Ordinal(12)] [RED("isOutTransitionFromAction")] public CBool IsOutTransitionFromAction { get; set; }

		public animAnimStateTransitionDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
