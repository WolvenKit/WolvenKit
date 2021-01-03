using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldCurvePathNode : worldSplineNode
	{
		[Ordinal(0)]  [RED("animSets")] public CArray<rRef<animAnimSet>> AnimSets { get; set; }
		[Ordinal(1)]  [RED("defaultForwardVector")] public Vector4 DefaultForwardVector { get; set; }
		[Ordinal(2)]  [RED("defaultPoseAnimationName")] public CName DefaultPoseAnimationName { get; set; }
		[Ordinal(3)]  [RED("defaultPoseSampleTime")] public CFloat DefaultPoseSampleTime { get; set; }
		[Ordinal(4)]  [RED("globalInBlendTime")] public CFloat GlobalInBlendTime { get; set; }
		[Ordinal(5)]  [RED("globalOutBlendTime")] public CFloat GlobalOutBlendTime { get; set; }
		[Ordinal(6)]  [RED("initialDiffYaw")] public CFloat InitialDiffYaw { get; set; }
		[Ordinal(7)]  [RED("rig")] public rRef<animRig> Rig { get; set; }
		[Ordinal(8)]  [RED("timeDeltaMultiplier")] public CFloat TimeDeltaMultiplier { get; set; }
		[Ordinal(9)]  [RED("turnCharacterToMatchVelocity")] public CBool TurnCharacterToMatchVelocity { get; set; }
		[Ordinal(10)]  [RED("userInput")] public animCurvePathBakerUserInput UserInput { get; set; }

		public worldCurvePathNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
