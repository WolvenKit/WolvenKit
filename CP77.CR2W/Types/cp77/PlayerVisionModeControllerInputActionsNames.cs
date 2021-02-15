using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerInputActionsNames : CVariable
	{
		[Ordinal(0)] [RED("buttonHold")] public CName ButtonHold { get; set; }
		[Ordinal(1)] [RED("buttonToggle")] public CName ButtonToggle { get; set; }

		public PlayerVisionModeControllerInputActionsNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
