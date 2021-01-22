using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetMoveState : CVariable
	{
		[Ordinal(0)]  [RED("desiredSpeed")] public CFloat DesiredSpeed { get; set; }
		[Ordinal(1)]  [RED("isDoubleJumped")] public CBool IsDoubleJumped { get; set; }
		[Ordinal(2)]  [RED("isFalling")] public CBool IsFalling { get; set; }
		[Ordinal(3)]  [RED("isJumping")] public CBool IsJumping { get; set; }
		[Ordinal(4)]  [RED("jumpStartFrameId")] public CUInt32 JumpStartFrameId { get; set; }
		[Ordinal(5)]  [RED("landFrameId")] public CUInt32 LandFrameId { get; set; }
		[Ordinal(6)]  [RED("moveStyle")] public CEnum<gameMuppetMoveStyle> MoveStyle { get; set; }

		public gameMuppetMoveState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
