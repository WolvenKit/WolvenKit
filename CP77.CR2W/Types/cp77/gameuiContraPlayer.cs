using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiContraPlayer : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		[Ordinal(1)] [RED("mass")] public CFloat Mass { get; set; }
		[Ordinal(2)] [RED("jumpForce")] public CFloat JumpForce { get; set; }
		[Ordinal(3)] [RED("movementSpeed")] public CFloat MovementSpeed { get; set; }

		public gameuiContraPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
