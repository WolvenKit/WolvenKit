using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AISearchingLookat : AIGenericStaticLookatTask
	{
		[Ordinal(4)] [RED("minAngleDifferenceMapping")] public CHandle<AIArgumentMapping> MinAngleDifferenceMapping { get; set; }
		[Ordinal(5)] [RED("minAngleDifference")] public CFloat MinAngleDifference { get; set; }
		[Ordinal(6)] [RED("maxLookAroundAngleMapping")] public CHandle<AIArgumentMapping> MaxLookAroundAngleMapping { get; set; }
		[Ordinal(7)] [RED("maxLookAroundAngle")] public CFloat MaxLookAroundAngle { get; set; }
		[Ordinal(8)] [RED("currentTarget")] public Vector4 CurrentTarget { get; set; }
		[Ordinal(9)] [RED("lastTarget")] public Vector4 LastTarget { get; set; }
		[Ordinal(10)] [RED("targetSwitchTimeStamp")] public CFloat TargetSwitchTimeStamp { get; set; }
		[Ordinal(11)] [RED("targetSwitchCooldown")] public CFloat TargetSwitchCooldown { get; set; }
		[Ordinal(12)] [RED("sideHorizontal")] public CInt32 SideHorizontal { get; set; }
		[Ordinal(13)] [RED("sideVertical")] public CInt32 SideVertical { get; set; }

		public AISearchingLookat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
