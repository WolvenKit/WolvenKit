using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloorIk : animAnimNode_FloorIkBase
	{
		[Ordinal(8)] [RED("pelvis")] public animSBehaviorConstraintNodeFloorIKVerticalBoneData Pelvis { get; set; }
		[Ordinal(9)] [RED("legs")] public animSBehaviorConstraintNodeFloorIKLegsData Legs { get; set; }
		[Ordinal(10)] [RED("leftLegIK")] public animSTwoBonesIKSolverData LeftLegIK { get; set; }
		[Ordinal(11)] [RED("rightLegIK")] public animSTwoBonesIKSolverData RightLegIK { get; set; }

		public animAnimNode_FloorIk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
