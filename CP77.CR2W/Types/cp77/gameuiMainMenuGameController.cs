using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMainMenuGameController : gameuiMenuItemListGameController
	{
		[Ordinal(0)]  [RED("baseEventDispatcher")] public wCHandle<inkMenuEventDispatcher> BaseEventDispatcher { get; set; }
		[Ordinal(1)]  [RED("menuList")] public inkCompoundWidgetReference MenuList { get; set; }
		[Ordinal(2)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(3)]  [RED("menuListController")] public wCHandle<inkListController> MenuListController { get; set; }
		[Ordinal(4)]  [RED("backgroundContainer")] public inkCompoundWidgetReference BackgroundContainer { get; set; }

		public gameuiMainMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
