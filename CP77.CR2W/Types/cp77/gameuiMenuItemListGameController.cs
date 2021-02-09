using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMenuItemListGameController : gameuiSaveHandlingController
	{
		[Ordinal(1)]  [RED("menuList")] public inkCompoundWidgetReference MenuList { get; set; }
		[Ordinal(2)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(3)]  [RED("menuListController")] public wCHandle<inkListController> MenuListController { get; set; }

		public gameuiMenuItemListGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
