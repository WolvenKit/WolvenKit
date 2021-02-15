using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerInputActiveFlags : CVariable
	{
		[Ordinal(0)] [RED("buttonHold")] public CBool ButtonHold { get; set; }
		[Ordinal(1)] [RED("buttonToggle")] public CBool ButtonToggle { get; set; }

		public PlayerVisionModeControllerInputActiveFlags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
