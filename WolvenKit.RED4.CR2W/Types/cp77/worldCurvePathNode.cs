using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCurvePathNode : worldSplineNode
	{
		[Ordinal(9)] [RED("userInput")] public animCurvePathBakerUserInput UserInput { get; set; }
		[Ordinal(10)] [RED("defaultForwardVector")] public Vector4 DefaultForwardVector { get; set; }
		[Ordinal(11)] [RED("globalInBlendTime")] public CFloat GlobalInBlendTime { get; set; }
		[Ordinal(12)] [RED("globalOutBlendTime")] public CFloat GlobalOutBlendTime { get; set; }
		[Ordinal(13)] [RED("defaultPoseAnimationName")] public CName DefaultPoseAnimationName { get; set; }
		[Ordinal(14)] [RED("defaultPoseSampleTime")] public CFloat DefaultPoseSampleTime { get; set; }
		[Ordinal(15)] [RED("initialDiffYaw")] public CFloat InitialDiffYaw { get; set; }
		[Ordinal(16)] [RED("turnCharacterToMatchVelocity")] public CBool TurnCharacterToMatchVelocity { get; set; }
		[Ordinal(17)] [RED("rig")] public rRef<animRig> Rig { get; set; }
		[Ordinal(18)] [RED("animSets")] public CArray<rRef<animAnimSet>> AnimSets { get; set; }
		[Ordinal(19)] [RED("timeDeltaMultiplier")] public CFloat TimeDeltaMultiplier { get; set; }

		public worldCurvePathNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
