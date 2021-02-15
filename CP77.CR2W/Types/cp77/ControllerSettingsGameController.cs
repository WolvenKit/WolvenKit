using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ControllerSettingsGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(4)] [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }

		public ControllerSettingsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
