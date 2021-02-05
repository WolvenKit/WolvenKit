using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameActionRotateBaseState : gameActionReplicatedState
	{
		[Ordinal(0)]  [RED("angleOffset")] public CFloat AngleOffset { get; set; }
		[Ordinal(1)]  [RED("angleTolerance")] public CFloat AngleTolerance { get; set; }
		[Ordinal(2)]  [RED("keepUpdatingTarget")] public CBool KeepUpdatingTarget { get; set; }
		[Ordinal(3)]  [RED("useRotationTime")] public CBool UseRotationTime { get; set; }
		[Ordinal(4)]  [RED("rotationSpeed")] public CFloat RotationSpeed { get; set; }
		[Ordinal(5)]  [RED("rotationTime")] public CFloat RotationTime { get; set; }

		public gameActionRotateBaseState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
