using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class moveSecureFootingParameters : CVariable
	{
		[Ordinal(0)] [RED("unsecureCollisionFilterName")] public CName UnsecureCollisionFilterName { get; set; }
		[Ordinal(1)] [RED("maxVerticalDistanceForCentreRaycast")] public CFloat MaxVerticalDistanceForCentreRaycast { get; set; }
		[Ordinal(2)] [RED("maxAngularDistanceForOtherRaycasts")] public CFloat MaxAngularDistanceForOtherRaycasts { get; set; }
		[Ordinal(3)] [RED("standingMinNumberOfRaycasts")] public CUInt32 StandingMinNumberOfRaycasts { get; set; }
		[Ordinal(4)] [RED("standingMinCollisionHorizontalDistance")] public CFloat StandingMinCollisionHorizontalDistance { get; set; }
		[Ordinal(5)] [RED("fallingMinNumberOfRaycasts")] public CUInt32 FallingMinNumberOfRaycasts { get; set; }
		[Ordinal(6)] [RED("fallingMinCollisionHorizontalDistance")] public CFloat FallingMinCollisionHorizontalDistance { get; set; }
		[Ordinal(7)] [RED("maxStaticGroundFactor")] public CFloat MaxStaticGroundFactor { get; set; }
		[Ordinal(8)] [RED("needsCentreRaycast")] public CBool NeedsCentreRaycast { get; set; }
		[Ordinal(9)] [RED("minVelocityForFalling")] public CFloat MinVelocityForFalling { get; set; }
		[Ordinal(10)] [RED("slopeCurveName")] public CName SlopeCurveName { get; set; }

		public moveSecureFootingParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
