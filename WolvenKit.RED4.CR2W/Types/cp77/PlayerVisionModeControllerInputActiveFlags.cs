using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerInputActiveFlags : CVariable
	{
		[Ordinal(0)] [RED("buttonHold")] public CBool ButtonHold { get; set; }
		[Ordinal(1)] [RED("buttonToggle")] public CBool ButtonToggle { get; set; }

		public PlayerVisionModeControllerInputActiveFlags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
