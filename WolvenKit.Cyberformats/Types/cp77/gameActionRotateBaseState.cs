using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameActionRotateBaseState : gameActionReplicatedState
	{
		[Ordinal(5)] [RED("angleOffset")] public CFloat AngleOffset { get; set; }
		[Ordinal(6)] [RED("angleTolerance")] public CFloat AngleTolerance { get; set; }
		[Ordinal(7)] [RED("keepUpdatingTarget")] public CBool KeepUpdatingTarget { get; set; }
		[Ordinal(8)] [RED("useRotationTime")] public CBool UseRotationTime { get; set; }
		[Ordinal(9)] [RED("rotationSpeed")] public CFloat RotationSpeed { get; set; }
		[Ordinal(10)] [RED("rotationTime")] public CFloat RotationTime { get; set; }

		public gameActionRotateBaseState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
