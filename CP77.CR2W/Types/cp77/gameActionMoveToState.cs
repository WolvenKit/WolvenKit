using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameActionMoveToState : gameActionReplicatedState
	{
		[Ordinal(0)]  [RED("targetPos")] public Vector3 TargetPos { get; set; }
		[Ordinal(1)]  [RED("toleranceRadius")] public CFloat ToleranceRadius { get; set; }
		[Ordinal(2)]  [RED("rotateEntity")] public CBool RotateEntity { get; set; }
		[Ordinal(3)]  [RED("moveStyle")] public CUInt32 MoveStyle { get; set; }

		public gameActionMoveToState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
