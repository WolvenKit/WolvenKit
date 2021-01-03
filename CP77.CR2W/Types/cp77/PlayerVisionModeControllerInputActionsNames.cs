using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerInputActionsNames : CVariable
	{
		[Ordinal(0)]  [RED("buttonHold")] public CName ButtonHold { get; set; }
		[Ordinal(1)]  [RED("buttonToggle")] public CName ButtonToggle { get; set; }

		public PlayerVisionModeControllerInputActionsNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
