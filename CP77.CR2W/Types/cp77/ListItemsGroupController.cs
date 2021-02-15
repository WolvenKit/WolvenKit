using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ListItemsGroupController : CodexListItemController
	{
		[Ordinal(19)] [RED("menuList")] public inkCompoundWidgetReference MenuList { get; set; }
		[Ordinal(20)] [RED("foldArrowRef")] public inkWidgetReference FoldArrowRef { get; set; }
		[Ordinal(21)] [RED("foldoutButton")] public inkWidgetReference FoldoutButton { get; set; }
		[Ordinal(22)] [RED("foldoutIndipendently")] public CBool FoldoutIndipendently { get; set; }
		[Ordinal(23)] [RED("menuListController")] public wCHandle<inkListController> MenuListController { get; set; }
		[Ordinal(24)] [RED("foldoutButtonController")] public wCHandle<inkButtonController> FoldoutButtonController { get; set; }
		[Ordinal(25)] [RED("lastClickedData")] public wCHandle<IScriptable> LastClickedData { get; set; }
		[Ordinal(26)] [RED("data")] public CArray<CHandle<IScriptable>> Data { get; set; }
		[Ordinal(27)] [RED("isOpen")] public CBool IsOpen { get; set; }

		public ListItemsGroupController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
