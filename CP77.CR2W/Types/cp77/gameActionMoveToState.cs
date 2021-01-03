using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameActionMoveToState : gameActionReplicatedState
	{
		[Ordinal(0)]  [RED("moveStyle")] public CUInt32 MoveStyle { get; set; }
		[Ordinal(1)]  [RED("rotateEntity")] public CBool RotateEntity { get; set; }
		[Ordinal(2)]  [RED("targetPos")] public Vector3 TargetPos { get; set; }
		[Ordinal(3)]  [RED("toleranceRadius")] public CFloat ToleranceRadius { get; set; }

		public gameActionMoveToState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
