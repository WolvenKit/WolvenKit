using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class moveComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(3)] [RED("position")] public Vector3 Position { get; set; }
		[Ordinal(4)] [RED("linearVelocity")] public Vector3 LinearVelocity { get; set; }
		[Ordinal(5)] [RED("teleportCount")] public CInt16 TeleportCount { get; set; }
		[Ordinal(6)] [RED("touchesGround")] public CBool TouchesGround { get; set; }
		[Ordinal(7)] [RED("touchesWalls")] public CBool TouchesWalls { get; set; }
		[Ordinal(8)] [RED("physicalMove")] public CBool PhysicalMove { get; set; }
		[Ordinal(9)] [RED("inputTimestamp")] public netTime InputTimestamp { get; set; }

		public moveComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
