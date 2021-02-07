using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animLookAtStateMachineSettings : CVariable
	{
		[Ordinal(0)]  [RED("partName")] public CName PartName { get; set; }
		[Ordinal(1)]  [RED("partAlias")] public CName PartAlias { get; set; }
		[Ordinal(2)]  [RED("sphereAttachmentBone")] public CName SphereAttachmentBone { get; set; }
		[Ordinal(3)]  [RED("sphereRadius")] public CFloat SphereRadius { get; set; }
		[Ordinal(4)]  [RED("followingSpeedFactor")] public CFloat FollowingSpeedFactor { get; set; }
		[Ordinal(5)]  [RED("followingSpeedByAngleCurve")] public curveData<CFloat> FollowingSpeedByAngleCurve { get; set; }
		[Ordinal(6)]  [RED("enableFloatTrack")] public CName EnableFloatTrack { get; set; }
		[Ordinal(7)]  [RED("eyesOverrideFloatTrack")] public CName EyesOverrideFloatTrack { get; set; }
		[Ordinal(8)]  [RED("transitionSpeedMultiplier")] public CFloat TransitionSpeedMultiplier { get; set; }
		[Ordinal(9)]  [RED("blendWeightPowFactor")] public CFloat BlendWeightPowFactor { get; set; }
		[Ordinal(10)]  [RED("coneLimitReached")] public CName ConeLimitReached { get; set; }

		public animLookAtStateMachineSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
