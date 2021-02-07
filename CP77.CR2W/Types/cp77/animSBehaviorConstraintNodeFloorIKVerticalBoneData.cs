using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animSBehaviorConstraintNodeFloorIKVerticalBoneData : CVariable
	{
		[Ordinal(0)]  [RED("Min_offset")] public CFloat Min_offset { get; set; }
		[Ordinal(1)]  [RED("Max_offset")] public CFloat Max_offset { get; set; }
		[Ordinal(2)]  [RED("bone")] public animTransformIndex Bone { get; set; }
		[Ordinal(3)]  [RED("offsetToDesiredBlendTime")] public CFloat OffsetToDesiredBlendTime { get; set; }
		[Ordinal(4)]  [RED("verticalOffsetBlendTime")] public CFloat VerticalOffsetBlendTime { get; set; }
		[Ordinal(5)]  [RED("stiffness")] public CFloat Stiffness { get; set; }

		public animSBehaviorConstraintNodeFloorIKVerticalBoneData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
