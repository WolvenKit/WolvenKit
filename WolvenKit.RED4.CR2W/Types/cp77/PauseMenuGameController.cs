using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PauseMenuGameController : gameuiMenuItemListGameController
	{
		[Ordinal(6)] [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(7)] [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(8)] [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(9)] [RED("quickSaveInProgress")] public CBool QuickSaveInProgress { get; set; }

		public PauseMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
