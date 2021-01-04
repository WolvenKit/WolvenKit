using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animSBehaviorConstraintNodeFloorIKLegsData : CVariable
	{
		[Ordinal(0)]  [RED("Max angle from upright normal")] public CFloat Max_angle_from_upright_normal { get; set; }
		[Ordinal(1)]  [RED("Max angle from upright normal to revert orientation")] public CFloat Max_angle_from_upright_normal_to_revert_orientation { get; set; }
		[Ordinal(2)]  [RED("Max angle from upright normal to side")] public CFloat Max_angle_from_upright_normal_to_side { get; set; }
		[Ordinal(3)]  [RED("Max distance for trace update")] public CFloat Max_distance_for_trace_update { get; set; }
		[Ordinal(4)]  [RED("Max rel offset")] public CFloat Max_rel_offset { get; set; }
		[Ordinal(5)]  [RED("Max trace offset")] public CFloat Max_trace_offset { get; set; }
		[Ordinal(6)]  [RED("Min rel offset")] public CFloat Min_rel_offset { get; set; }
		[Ordinal(7)]  [RED("Min trace offset")] public CFloat Min_trace_offset { get; set; }
		[Ordinal(8)]  [RED("verticalOffsetBlendDownTime")] public CFloat VerticalOffsetBlendDownTime { get; set; }
		[Ordinal(9)]  [RED("verticalOffsetBlendUpTime")] public CFloat VerticalOffsetBlendUpTime { get; set; }

		public animSBehaviorConstraintNodeFloorIKLegsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
