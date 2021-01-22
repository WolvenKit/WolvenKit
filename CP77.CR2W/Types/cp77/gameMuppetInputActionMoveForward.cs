using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionMoveForward : gameIMuppetInputAction
	{
		[Ordinal(0)]  [RED("direction")] public Vector2 Direction { get; set; }
		[Ordinal(1)]  [RED("isSprinting")] public CBool IsSprinting { get; set; }

		public gameMuppetInputActionMoveForward(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
