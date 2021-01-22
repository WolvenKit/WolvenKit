using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloorIkBase : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("blockAnimEvent")] public CName BlockAnimEvent { get; set; }
		[Ordinal(1)]  [RED("canBeDisabledDueToFrameRate")] public CBool CanBeDisabledDueToFrameRate { get; set; }
		[Ordinal(2)]  [RED("common")] public animSBehaviorConstraintNodeFloorIKCommonData Common { get; set; }
		[Ordinal(3)]  [RED("requiredAnimEvent")] public CName RequiredAnimEvent { get; set; }
		[Ordinal(4)]  [RED("slopeAngleDamp")] public CFloat SlopeAngleDamp { get; set; }
		[Ordinal(5)]  [RED("useFixedVersion")] public CBool UseFixedVersion { get; set; }

		public animAnimNode_FloorIkBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
