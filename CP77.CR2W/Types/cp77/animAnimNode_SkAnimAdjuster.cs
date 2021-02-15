using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkAnimAdjuster : animAnimNode_SkAnim
	{
		[Ordinal(18)] [RED("targetPositionWs")] public animVectorLink TargetPositionWs { get; set; }
		[Ordinal(19)] [RED("targetDirectionWs")] public animVectorLink TargetDirectionWs { get; set; }
		[Ordinal(20)] [RED("initialForwardVector")] public Vector4 InitialForwardVector { get; set; }
		[Ordinal(21)] [RED("startAdjustmentEventName")] public CName StartAdjustmentEventName { get; set; }
		[Ordinal(22)] [RED("endAdjustmentEventName")] public CName EndAdjustmentEventName { get; set; }

		public animAnimNode_SkAnimAdjuster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
