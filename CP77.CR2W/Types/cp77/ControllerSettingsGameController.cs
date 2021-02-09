using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ControllerSettingsGameController : gameuiMenuGameController
	{
		[Ordinal(1)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(2)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }

		public ControllerSettingsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
