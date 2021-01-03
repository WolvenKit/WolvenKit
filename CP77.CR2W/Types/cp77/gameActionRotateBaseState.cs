using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameActionRotateBaseState : gameActionReplicatedState
	{
		[Ordinal(0)]  [RED("angleOffset")] public CFloat AngleOffset { get; set; }
		[Ordinal(1)]  [RED("angleTolerance")] public CFloat AngleTolerance { get; set; }
		[Ordinal(2)]  [RED("keepUpdatingTarget")] public CBool KeepUpdatingTarget { get; set; }
		[Ordinal(3)]  [RED("rotationSpeed")] public CFloat RotationSpeed { get; set; }
		[Ordinal(4)]  [RED("rotationTime")] public CFloat RotationTime { get; set; }
		[Ordinal(5)]  [RED("useRotationTime")] public CBool UseRotationTime { get; set; }

		public gameActionRotateBaseState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
